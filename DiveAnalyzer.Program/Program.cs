using System;
using System.Collections.Generic;
using System.Linq;

namespace DiveAnalyzer.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dives = Loader.Loader.GetDives();

            //foreach (Entities.Dive dive in dives)
            //{
            //    DAL.DAL.InsertDive(dive);
            //}

            List<Entities.Dive> Dives = DAL.DAL.GetDives();
            Entities.Dive dive = Dives.FirstOrDefault();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("****ALL DONE****");
            Console.ReadLine();
        }
    }
}
