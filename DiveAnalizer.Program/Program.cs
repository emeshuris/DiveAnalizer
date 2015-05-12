using System;
using System.Collections.Generic;

namespace DiveAnalyzer.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dives> Dives = Loader.Loader.ReadFiles();

            foreach (dives dives in Dives)
            {
                foreach (divesDiveSample diveDiveSample in dives.dive.samples)
                {
                    Console.WriteLine(diveDiveSample);
                }
            }

            Console.ReadLine();
        }
    }
}
