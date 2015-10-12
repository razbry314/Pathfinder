using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.Items
{
    class Item
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Currency BuyValue { get; set; }
        public virtual Currency SellValue { get { return new Currency() { Value = BuyValue.Value / 2 };}}
        public double Weight { get; set; }
        public bool Broken { get; set; }

    }
}
