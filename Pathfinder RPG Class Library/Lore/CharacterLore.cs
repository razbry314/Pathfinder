using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Lore
{
    class CharacterLore : Lore
    {
        public LoreEntry Age { get; set; }
        public LoreEntry Height { get; set; }
        public LoreEntry Weight { get; set; }
        public LoreEntry Gender { get; set; }
        public LoreEntry Race { get; set; }
        public LoreEntry Homeland { get; set; }
        public LoreEntry Occupation { get; set; }
        public LoreEntry PhysicalDescription { get; set; }
        public LoreEntry Personality { get; set; }
        public LoreEntry History1Childhood { get; set; }
        public LoreEntry History2Adolescence { get; set; }
        public LoreEntry History3Education { get; set; }
        public LoreEntry History4EarlyAdventures { get; set; }
    }
}
