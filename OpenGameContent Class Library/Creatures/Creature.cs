using OpenGameContent_Class_Library.Ability_Scores;
using OpenGameContent_Class_Library.Items;
using OpenGameContent_Class_Library.Lore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.Creatures
{
    class Creature
    {
        public CreatureLore Lore { get; set; }
        public AbilityScores AbilityScores { get; set; }

        public Inventory Inventory { get; set; }
        public long CR { get; set; }
        public int Initiative { get; set; }
        public int Armor_Class { get; set; }
        public int Touch_Armor_Class { get; set; }
        public int Flat_Footed_Armor_Class { get; set; }
        public int Speed { get; set; }

    }
}
