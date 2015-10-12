using OpenGameContent_Class_Library.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.Items
{
    class Weapon
    {
        //The damage for this weapon.
        public Die Damage { get; set; }
        public WeaponSize Size { get; set; }
        public int CritMultiplier { get; set; }
        public int CritRoll { get; set; }
        public int Range { get; set; }
        //As some wespons have multiple damage types (like firearms), I made this a list.
        public List<DamageType> DmgTypes { get; set; }

        //public List<SpecialWeaponFeatures> Features { get; set; }

    }
}
