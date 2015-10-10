using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Lore
{
    class ItemLore
    {
        /// <summary>
        /// Whether or not an item has been identified.
        /// </summary>
        public bool Itentified { get; set; }
        /// <summary>
        /// The item's name until it has been identified.
        /// </summary>
        public string UnidentifiedName { get; set; }
        /// <summary>
        /// The item's description until it's been identified.
        /// </summary>
        public string UnidentifiedDescription { get; set; }
        /// <summary>
        /// What needs to be done to identify an item.
        /// Usually an appraise or a knowledge check.
        /// </summary>
        public string IdentificationRequirements { get; set; }
    }
}
