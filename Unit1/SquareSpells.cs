using System;

namespace Otus.Algo2021.Unit1
{
    class SquareSpells
    {
        static void Main(string[] args)
        {
            foreach(var kv in Fillers.FillersByName)
            {
                Helpers.Print(kv.Key, Helpers.Generate(kv.Value));
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
