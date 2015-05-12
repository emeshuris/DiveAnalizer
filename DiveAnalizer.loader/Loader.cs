using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DiveAnalyzer.Loader
{
    public static class Loader
    {
        public static List<dives> Dives = new List<dives>();
        public const string DIVE_DIR_PATH = @"C:\Users\edward\Desktop\Dives";

        public static List<dives> ReadFiles()
        {
            foreach (string file in Directory.GetFiles(DIVE_DIR_PATH, "*.xml"))
            {
                Dives.Add(ReadFile(file));
            }

            return Dives;
        }

        public static dives ReadFile(string filePath)
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
