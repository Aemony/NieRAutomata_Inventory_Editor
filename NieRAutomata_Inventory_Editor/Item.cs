using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NieRAutomata_Inventory_Editor
{
    class Item
    {
        public Item()
        {

        }

        public int Slot { get; set; }
        public UInt32 ID { get; set; }
        public UInt32 Count { get; set; }
        public UInt32 Status { get; set; }
    }
}
