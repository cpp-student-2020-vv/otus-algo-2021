using System;
using System.Collections.Generic;

namespace Otus.Algo2021.Unit1
{
    public static class Fillers
    {
        public const int DefaultSize = 25;
        public const int MaxIndex = DefaultSize - 1;

        public static readonly Dictionary<string, Func<int, int, bool>> FillersByName = new Dictionary<string, Func<int, int, bool>> {
            { "Filler1", (x,y) => x > y },
            { "Filler2", (x,y) => x==y },
            { "Filler3", (x,y) => x == MaxIndex -y },
            { "Filler4", (x,y) => x < MaxIndex -y + 5 },
            {
                "Filler5-missed",
                (x,y) => (x % 2 == 1)
                    ? (x-1)/2 == y
                    : x/2 == y
            },
            { "Filler6", (x,y) => x < 10 || y < 10 },
            { "Filler7", (x,y) => x > 15 && y > 15 },
            { "Filler8", (x,y) => x == 0 || y == 0 },
            { "Filler9", (x,y) => Math.Abs(x - y) > 10 },
            { "Filler10", (x,y) => Math.Floor ((double)x / (y + 1)) == 1.0D },
            { "Filler11", (x,y) => x==1 || y==1 || x==23 || y == 23 },
            { "Filler12-missed", (x,y) => x*x + y*y <= 400 },
            { "Filler13-missed", (x,y) => x + y >= 20 && x + y <= 28 },
            { "Filler14-missed", (x,y) => x*x + y*y > 400  },
            { "Filler15-missed", (x,y) => Math.Abs(x - y) >= 10 && Math.Abs (x - y) <= 20  },
            { "Filler16-missed", (x,y) => Math.Abs(x - 12) + Math.Abs(y - 12) < 10  },
            { "Filler17-missed", (x,y) => Math.Sin(x/3.0) <= y / 8 - 2  },
            { "Filler18", (x,y) => (x<=1 || y<=1) && !(x==0 && y==0) },
            { "Filler19", (x,y) => x==0 || x==MaxIndex || y == 0 || y==MaxIndex },
            { "Filler20", (x,y) => (x + y) % 2 == 0 },
            { "Filler21-missed", (x,y) => x % (y + 1) == 0 },
            { "Filler22-missed", (x,y) => (x + y) % 3 == 0 },
            { "Filler23-missed", (x,y) => x % 2 + y % 3 > 0 },
            { "Filler24", (x,y) => x == y || x == MaxIndex - y },
            { "Filler25-missed", (x,y) => x % 6 == 0 || y % 6 == 0 },
        };
    }
}
