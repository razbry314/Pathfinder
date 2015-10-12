using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.Creatures
{
    public enum CreatureSize
    {
        Fine = 8,           //Size Mod +8
        Diminuitive = 4,    //Size Mod +4
        Tiny = 2,           //Size Mod +2
        Small = 1,          //Size Mod +1
        Medium = 0,         //Size Mod +0
        Large = -1,          //Size Mod -1
        Huge = -2,           //Size Mod -2
        Gargantuan = -4,     //Size Mod -4
        Colossal = -8        //Size Mod -8
    }
}
