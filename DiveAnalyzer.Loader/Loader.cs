using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DiveAnalyzer.Loader
{
    public static class Loader
    {
        public static List<dives> Dives = new List<dives>();
        public const string DIVE_DIR_PATH = @"C:\Users\edward\Documents\Visual Studio 2015\Projects\DiveAnalyzer\Dives";

        public static List<Entities.Dive> GetDives()
        {
            List<Entities.Dive> dives = new List<Entities.Dive>();

            foreach (dives macDive in ReadFiles())
            {
                Entities.Dive dive = new Entities.Dive();

                dive.Identifier = macDive.dive.identifier;
                dive.Units = macDive.units;
                dive.DiveStart = Convert.ToDateTime(string.Format("{0:MM/dd/yyyy}", macDive.dive.date));
                dive.DecoModel = macDive.dive.decoModel;

                dive.DivePoints = new List<Entities.DivePoint>();

                foreach (divesDiveSample sample in macDive.dive.samples)
                {
                    Entities.DivePoint divePoint = new Entities.DivePoint();

                    divePoint.Time = sample.time;
                    divePoint.Depth = sample.depth;
                    divePoint.Pressure = sample.pressure;
                    divePoint.Alarm = sample.alarm ?? null;
                    divePoint.Extra = sample.extra;
                    divePoint.Temperature = sample.temperature;
                    divePoint.PPO2 = sample.ppo2;
                    divePoint.NDT = sample.ndt;

                    dive.DivePoints.Add(divePoint);
                }

                dives.Add(dive);
            }

            return dives;
        }

        private static List<dives> ReadFiles()
        {
            foreach (string file in Directory.GetFiles(DIVE_DIR_PATH, "*.xml"))
            {
                Dives.Add(ReadFile(file));
            }

            return Dives;
        }

        private static dives ReadFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(dives));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                dives dives = (dives)serializer.Deserialize(fileStream);
                fileStream.Close();
                return dives;
            }
        }
    }
}
