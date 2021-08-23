using System;
using System.Text;

namespace Otus.Algo2021.Unit1
{
    public static class Helpers
    {
        public static string[] Generate(Func<int, int, bool> checker, int squareSize = Fillers.DefaultSize, char empty = '.', char filled = '#')
        {
            var result = new string[squareSize];
            for (var r = 0; r < squareSize; r++)
            {
                var buf = new StringBuilder();
                for (var c = 0; c < squareSize; c++)
                {
                    var symbol = checker(c, r)
                     ? filled
                     : empty;
                    buf.Append(symbol);
                }
                result[r] = buf.ToString();
            }
            return result;
        }

        public static void Print(string name, string[] rows)
        {
            Console.WriteLine($"Fill algo: {name}");
            foreach (var row in rows)
                Console.WriteLine(row);
        }
    }
}
