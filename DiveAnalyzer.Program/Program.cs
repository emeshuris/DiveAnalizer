using System;

namespace DiveAnalyzer.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dives = Loader.Loader.GetDives();

                foreach (Entities.Dive dive in dives)
                {
                    DAL.DAL.InsertDive(dive);
                }

                //List<Entities.Dive> Dives = DAL.DAL.GetDives();
                //Entities.Dive dive = Dives.FirstOrDefault();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("****ALL DONE****");
            Console.ReadLine();
        }
    }
}
