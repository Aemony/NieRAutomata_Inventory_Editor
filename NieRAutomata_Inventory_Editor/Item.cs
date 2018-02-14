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

        /*
         * 458752 = post-Prologue "Used Item Slot" / "Collected Item", aka "Active" ?
         * 4294967295 = "Unused Item Slot" aka "Inactive" ?
         */
        
        public int Slot { get; set; }
        public UInt32 ID { get; set; }
        public UInt32 Amount { get; set; }
        public Boolean Enabled
        {
            get => (Status == 458752) ? true : false;
            set => throw new NotImplementedException();
        }
        public UInt32 Status { get; set; }
    }
}
