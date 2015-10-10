using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library
{
    public abstract class Effect
    {
        public String Name { get; set; }
        public String Description { get; set; }
        protected bool Active { get; set; }
        public abstract void Activate();
        public abstract void Deactivate();
    }
}
