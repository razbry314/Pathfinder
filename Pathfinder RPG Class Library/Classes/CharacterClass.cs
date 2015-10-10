using Pathfinder_RPG_Class_Library.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_RPG_Class_Library.Classes;
using Pathfinder_RPG_Class_Library.Races;
using Pathfinder_RPG_Class_Library.Skills;

namespace Pathfinder_RPG_Class_Library
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
