using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinder_RPG_Class_Library.Races
{
    public class RacialTrait
    {
        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// The trait that this trait replaces. Leave null if this is a default trait.
        /// </summary>
        public string Replaces { get; set; }
    }
}
