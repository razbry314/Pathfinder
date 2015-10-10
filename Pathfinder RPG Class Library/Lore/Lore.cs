using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Lore
{
    /// <summary>
    /// Nouns have lore. People, places, and things all have lore.
    /// </summary>
    class Lore
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public byte[] IconImage { get; set; }
    }

    class LoreEntry
    {
        /// <summary>
        /// Whether or not the content of this piece of lore is known.
        /// </summary>
        public bool Known { get; set; }
        /// <summary>
        /// The title of this piece of lore.
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// The content of this piece of lore.
        /// </summary>
        public String Content { get; set; }
        /// <summary>
        /// What needs to be done to learn this piece of lore.
        /// Usually a skill check or plot thing.
        /// </summary>
        public String UnlockRequirement { get; set; }
    }

}
