using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library
{
    static class StaticRandom
    {
        private static Random random = new Random();

        public static int NextInt(int maxExclusive)
        {
            return random.Next(maxExclusive);
        }
    }
}
