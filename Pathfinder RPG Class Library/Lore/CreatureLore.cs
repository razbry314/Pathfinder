using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Lore
{
    class CreatureLore
    {
        public LoreEntry CreatureType { get; set; }
        public LoreEntry Environment { get; set; }
        public LoreEntry Organization { get; set; }
        public List<LoreEntry> SpecialAbilities { get; set; }
        public List<LoreEntry> MiscFacts { get; set; }
    }
}
