using OpenGameContent_Class_Library.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenGameContent_Class_Library.Classes;
using OpenGameContent_Class_Library.Races;
using OpenGameContent_Class_Library.Skills;

namespace OpenGameContent_Class_Library
{
    class CharacterClass
    {
        public string Name { get; set; }

        //Flavor Text
        public string Description { get; set; }
        public string Role { get; set; }

        //Allignment Restrictions?

        public Die HitDie { get; set; }

        public List<ClassFeature> Features { get; set; }
        public List<Skill> Skills { get; set; }
        public Dictionary<Race, Effect> FavoredClassBonuses { get; set; }
    }
}
