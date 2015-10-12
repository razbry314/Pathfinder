using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.Items
{
    class Container : Item
    {
        public Inventory Contents { get; set; }
        public double TotalWeight
        {
            get
            {
                double result = Weight;
                foreach (Item item in Contents.Items)
                {
                    result += item.Weight;
                }
                return result;
            }
        }
    }
}
