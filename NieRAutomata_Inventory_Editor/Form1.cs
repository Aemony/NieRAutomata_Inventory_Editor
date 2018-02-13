using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NieRAutomata_Inventory_Editor
{
    public partial class Form1 : Form
    {
        // block 30570 -> 31D6F - 6 144 bytes = 512 items (6 144 / 12)
        /* 12 bytes per item
         * 0-3 - ItemID
         * 4-7 - "Item Status" ? 458752 = post-Prologue "Used Item Slot" / "Collected Item" ?  | 4294967295 = "Unused Item Slot" ?
         * 8-11 - Item Count | Max Count == 99
         */
        // 0-255 - Main Inventory
        // 256-512 - Secondary Inventory (lost body) ?
        private static int _intBlockOffset = 198000;
        private static int _intBlockLength = 6144;
        private byte[] _byteInventory = new byte[_intBlockLength];
        private Item[] _itemInventoryActive = new Item[256];
        private Item[] _itemInventoryCorpse = new Item[256];
        private string _filePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\NieR_Automata";
            dlg.Filter = "Save file (*.dat)|SlotData_*.dat";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _filePath = dlg.FileName;

                using (FileStream stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
                {
                    stream.Position = _intBlockOffset;
                    stream.Read(_byteInventory, 0, _intBlockLength);
                }

                // Populate the active/main inventory
                for(int i = 0; i < 256; i++)
                {
                    _itemInventoryActive[i] = new Item
                    {
                        Slot = i,
                        ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                        Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                        Count = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
                    };
                }

                // Populate the inactive/corpse inventory
                for (int i = 256; i < 512; i++)
                {
                    _itemInventoryCorpse[i -256] = new Item
                    {
                        Slot = i -256,
                        ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                        Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                        Count = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
                    };
                }

#if DEBUG
                Console.WriteLine("Read:");
                Console.WriteLine(BitConverter.ToString(_byteInventory));
#endif

                // Populate the view
                fastObjectListView1.SetObjects(_itemInventoryActive);
                fastObjectListView2.SetObjects(_itemInventoryCorpse);

                // Enable the buttons
                buttonSave.Enabled = true;
                buttonResetActive.Enabled = true;
                buttonResetCorpse.Enabled = true;
            }
        }

        private void buttonResetActive_Click(object sender, EventArgs e)
        {
            fastObjectListView1.ClearObjects();
            for (int i = 0; i < 256; i++)
            {
                _itemInventoryActive[i] = new Item
                {
                    Slot = i,
                    ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                    Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                    Count = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
                };
            }
            fastObjectListView1.SetObjects(_itemInventoryActive);
        }

        private void buttonResetCorpse_Click(object sender, EventArgs e)
        {
            fastObjectListView2.ClearObjects();
            for (int i = 256; i < 512; i++)
            {
                _itemInventoryCorpse[i - 256] = new Item
                {
                    Slot = i - 256,
                    ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                    Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                    Count = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
                };
            }
            fastObjectListView2.SetObjects(_itemInventoryActive);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            byte[] byteInventoryChanged = new byte[_intBlockLength];

            for (int i = 0; i < 256; i++)
            {
                BitConverter.GetBytes(_itemInventoryActive[i].ID).CopyTo(byteInventoryChanged, i * 12);
                BitConverter.GetBytes(_itemInventoryActive[i].Status).CopyTo(byteInventoryChanged, i * 12 + 4);
                BitConverter.GetBytes(_itemInventoryActive[i].Count).CopyTo(byteInventoryChanged, i * 12 + 8);
            }

            for (int i = 256; i < 512; i++)
            {
                BitConverter.GetBytes(_itemInventoryCorpse[i - 256].ID).CopyTo(byteInventoryChanged, i * 12);
                BitConverter.GetBytes(_itemInventoryCorpse[i - 256].Status).CopyTo(byteInventoryChanged, i * 12 + 4);
                BitConverter.GetBytes(_itemInventoryCorpse[i - 256].Count).CopyTo(byteInventoryChanged, i * 12 + 8);
            }
            
#if DEBUG
            Console.WriteLine("Wrote:");
            Console.WriteLine(BitConverter.ToString(byteInventoryChanged));
#endif

            // Create a backup first
            File.Copy(_filePath, _filePath + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss.bak"));

            // Now overwrite the data
            using (Stream stream = File.Open(_filePath, FileMode.Open, FileAccess.Write))
            {
                stream.Position = _intBlockOffset;
                stream.Write(byteInventoryChanged, 0, _intBlockLength);
            }
        }
    }
}
