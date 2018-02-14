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
        private byte[] _byteInventoryImportedActive = null;
        private byte[] _byteInventoryImportedCorpse = null;
        private Item[] _itemInventoryActive = new Item[256];
        private Item[] _itemInventoryCorpse = new Item[256];
        private string _filePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;

            if (_filePath == null && fastObjectListView1.GetItemCount() > 0)
            {
                dialogResult = MessageBox.Show("You already have an inventory list imported. Opening a slot file will discard all unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else if (_filePath != null)
            {
                dialogResult = MessageBox.Show("You already have a file opened. Opening another will discard all unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if (dialogResult == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\NieR_Automata",
                    Filter = "Save File (SlotData_#.dat)|SlotData_*.dat",
                    Title = "Open slot file"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = openFileDialog.FileName;
                    textBoxFilePath.Text = _filePath;
                    textBoxFilePath.SelectionStart = textBoxFilePath.Text.Length;
                    // Ensure that the view is empty
                    fastObjectListView1.ClearObjects();
                    fastObjectListView2.ClearObjects();

                    // Read the file
                    using (Stream stream = openFileDialog.OpenFile())
                    {
                        stream.Position = _intBlockOffset;
                        stream.Read(_byteInventory, 0, _intBlockLength);
                    }

                    // Populate the active/main inventory
                    for (int i = 0; i < 256; i++)
                    {
                        _itemInventoryActive[i] = new Item
                        {
                            Slot = i,
                            ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                            Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                            Amount = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
                        };
                    }

                    // Populate the inactive/corpse inventory
                    for (int i = 256; i < 512; i++)
                    {
                        _itemInventoryCorpse[i - 256] = new Item
                        {
                            Slot = i - 256,
                            ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                            Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                            Amount = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
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
                    buttonExport.Enabled = true;

                    // Finally update the background stuff to reflect the new file
                    _byteInventoryImportedActive = null;
                    _byteInventoryImportedCorpse = null;
                    textBoxInventoryPath.Text = "No inventory list imported...";
                }
            }
        }

        private void buttonResetActive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (_byteInventoryImportedCorpse != null)
            {
                dialogResult = MessageBox.Show("You currently have an imported inventory list active. Resetting will discard the imported inventory list and any unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                dialogResult = MessageBox.Show("Are you sure you want to reset your changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if (dialogResult == DialogResult.Yes)
            {
                // Empty the imported inventory list, if one is loaded
                _byteInventoryImportedActive = null;

                fastObjectListView1.ClearObjects();
                for (int i = 0; i < 256; i++)
                {
                    _itemInventoryActive[i] = new Item
                    {
                        Slot = i,
                        ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                        Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                        Amount = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
                    };
                }
                fastObjectListView1.SetObjects(_itemInventoryActive);

                if (_byteInventoryImportedActive == null && _byteInventoryImportedCorpse == null)
                {
                    textBoxInventoryPath.Text = "No inventory list imported...";
                }
            }
        }

        private void buttonResetCorpse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (_byteInventoryImportedCorpse != null)
            {
                dialogResult = MessageBox.Show("You currently have an imported inventory list active. Resetting will discard the imported inventory list and and any unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            } else
            {
                dialogResult = MessageBox.Show("Are you sure you want to reset your changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if (dialogResult == DialogResult.Yes)
            {
                // Empty the imported inventory list, if one is loaded
                _byteInventoryImportedCorpse = null;

                fastObjectListView2.ClearObjects();
                for (int i = 256; i < 512; i++)
                {
                    _itemInventoryCorpse[i - 256] = new Item
                    {
                        Slot = i - 256,
                        ID = BitConverter.ToUInt32(_byteInventory, i * 12),
                        Status = BitConverter.ToUInt32(_byteInventory, i * 12 + 4),
                        Amount = BitConverter.ToUInt32(_byteInventory, i * 12 + 8)
                    };
                }
                fastObjectListView2.SetObjects(_itemInventoryCorpse);

                if (_byteInventoryImportedActive == null && _byteInventoryImportedCorpse == null)
                {
                    textBoxInventoryPath.Text = "No inventory list imported...";
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (_byteInventoryImportedActive != null || _byteInventoryImportedCorpse != null)
            {
                dialogResult = MessageBox.Show("You currently have an imported inventory list active that have overwritten the original inventory list of the opened slot file. Saving will make the change permanent.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            } else {
                dialogResult = MessageBox.Show("Are you sure you want to save your changes to the slot file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if(dialogResult == DialogResult.Yes)
            {
                byte[] byteInventoryChanged = new byte[_intBlockLength];

                for (int i = 0; i < 256; i++)
                {
                    BitConverter.GetBytes(_itemInventoryActive[i].ID).CopyTo(byteInventoryChanged, i * 12);
                    BitConverter.GetBytes(_itemInventoryActive[i].Status).CopyTo(byteInventoryChanged, i * 12 + 4);
                    BitConverter.GetBytes(_itemInventoryActive[i].Amount).CopyTo(byteInventoryChanged, i * 12 + 8);
                }

                for (int i = 256; i < 512; i++)
                {
                    BitConverter.GetBytes(_itemInventoryCorpse[i - 256].ID).CopyTo(byteInventoryChanged, i * 12);
                    BitConverter.GetBytes(_itemInventoryCorpse[i - 256].Status).CopyTo(byteInventoryChanged, i * 12 + 4);
                    BitConverter.GetBytes(_itemInventoryCorpse[i - 256].Amount).CopyTo(byteInventoryChanged, i * 12 + 8);
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

                // Finally update the background stuff to reflect the new file
                _byteInventory = byteInventoryChanged;
                _byteInventoryImportedActive = null;
                _byteInventoryImportedCorpse = null;
                textBoxInventoryPath.Text = "No inventory list imported...";

                MessageBox.Show("Changes were saved!", "Save complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            byte[] byteInventoryExport = new byte[_intBlockLength];

            for (int i = 0; i < 256; i++)
            {
                BitConverter.GetBytes(_itemInventoryActive[i].ID).CopyTo(byteInventoryExport, i * 12);
                BitConverter.GetBytes(_itemInventoryActive[i].Status).CopyTo(byteInventoryExport, i * 12 + 4);
                BitConverter.GetBytes(_itemInventoryActive[i].Amount).CopyTo(byteInventoryExport, i * 12 + 8);
            }

            for (int i = 256; i < 512; i++)
            {
                BitConverter.GetBytes(_itemInventoryCorpse[i - 256].ID).CopyTo(byteInventoryExport, i * 12);
                BitConverter.GetBytes(_itemInventoryCorpse[i - 256].Status).CopyTo(byteInventoryExport, i * 12 + 4);
                BitConverter.GetBytes(_itemInventoryCorpse[i - 256].Amount).CopyTo(byteInventoryExport, i * 12 + 8);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\NieR_Automata",
                Title = "Export inventory to file",
                Filter = "Binary Data (*.bin)|*.bin|All Files|*",
                FileName = "inventory.bin"
            };

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Now export the data
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    stream.Position = 0;
                    stream.Write(byteInventoryExport, 0, _intBlockLength);
                }
                
#if DEBUG
                Console.WriteLine("Wrote:");
                Console.WriteLine(BitConverter.ToString(byteInventoryExport));
#endif

                MessageBox.Show("Inventory was exported!", "Export complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;

            if (_filePath != null && fastObjectListView1.GetItemCount() > 0)
            {
                dialogResult = MessageBox.Show("You already have a slot file opened. Importing an inventory list will overwrite the one from the slot file and discard any unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            } else if (_byteInventoryImportedActive != null || _byteInventoryImportedCorpse != null)
            {
                dialogResult = MessageBox.Show("You already have an inventory list imported. Importing another will discard any unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if(dialogResult == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\NieR_Automata",
                    Filter = "Binary Data (*.bin)|*.bin|All Files|*",
                    Title = "Import inventory to editor",
                    FileName = "inventory.bin"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                    if(fileInfo.Length == _intBlockLength)
                    {
                        // Initialize the array if it isn't
                        if (_byteInventoryImportedActive == null)
                        {
                            _byteInventoryImportedActive = new byte[_intBlockLength/2];
                        }
                        if (_byteInventoryImportedCorpse == null)
                        {
                            _byteInventoryImportedCorpse = new byte[_intBlockLength/2];
                        }

                        // Read file
                        using (Stream stream = openFileDialog.OpenFile())
                        {
                            stream.Position = 0;
                            stream.Read(_byteInventoryImportedActive, 0, _intBlockLength/2);
                            stream.Read(_byteInventoryImportedCorpse, 0, _intBlockLength/2);
                        }

                        // Populate the active/main inventory
                        for (int i = 0; i < 256; i++)
                        {
                            _itemInventoryActive[i] = new Item
                            {
                                Slot = i,
                                ID = BitConverter.ToUInt32(_byteInventoryImportedActive, i * 12),
                                Status = BitConverter.ToUInt32(_byteInventoryImportedActive, i * 12 + 4),
                                Amount = BitConverter.ToUInt32(_byteInventoryImportedActive, i * 12 + 8)
                            };
                        }

                        // Populate the inactive/corpse inventory
                        for (int i = 0; i < 256; i++)
                        {
                            _itemInventoryCorpse[i] = new Item
                            {
                                Slot = i,
                                ID = BitConverter.ToUInt32(_byteInventoryImportedCorpse, i * 12),
                                Status = BitConverter.ToUInt32(_byteInventoryImportedCorpse, i * 12 + 4),
                                Amount = BitConverter.ToUInt32(_byteInventoryImportedCorpse, i * 12 + 8)
                            };
                        }

#if DEBUG
                Console.WriteLine("Read:");
                        Console.WriteLine(BitConverter.ToString(_byteInventoryImportedActive) + BitConverter.ToString(_byteInventoryImportedCorpse));
#endif

                        // Ensure that the view is empty
                        fastObjectListView1.ClearObjects();
                        fastObjectListView2.ClearObjects();

                        // Populate the view
                        fastObjectListView1.SetObjects(_itemInventoryActive);
                        fastObjectListView2.SetObjects(_itemInventoryCorpse);

                        // Enable the buttons
                        buttonExport.Enabled = true;

                        // List the path
                        textBoxInventoryPath.Text = openFileDialog.FileName;
                        textBoxInventoryPath.SelectionStart = openFileDialog.FileName.Length;
                    }
                    else
                    {
                        MessageBox.Show("Wrong size of the file you are trying to import!", "Import canceled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
