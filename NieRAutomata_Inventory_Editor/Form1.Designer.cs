namespace NieRAutomata_Inventory_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.olvActiveColumnSlot = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvActiveColumnEnabled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvActiveColumnID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvActiveColumnAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvActiveColumnStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fastObjectListView2 = new BrightIdeasSoftware.FastObjectListView();
            this.olvInactiveColumnSlot = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvInactiveColumnEnabled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvInactiveColumnID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvInactiveColumnAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvInactiveColumnStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonResetActive = new System.Windows.Forms.Button();
            this.buttonResetCorpse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(140, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open SlotData_#.dat...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(41, 47);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(304, 20);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.olvActiveColumnSlot);
            this.fastObjectListView1.AllColumns.Add(this.olvActiveColumnEnabled);
            this.fastObjectListView1.AllColumns.Add(this.olvActiveColumnID);
            this.fastObjectListView1.AllColumns.Add(this.olvActiveColumnAmount);
            this.fastObjectListView1.AllColumns.Add(this.olvActiveColumnStatus);
            this.fastObjectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvActiveColumnSlot,
            this.olvActiveColumnEnabled,
            this.olvActiveColumnID,
            this.olvActiveColumnAmount,
            this.olvActiveColumnStatus});
            this.fastObjectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListView1.Location = new System.Drawing.Point(12, 107);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(325, 451);
            this.fastObjectListView1.TabIndex = 2;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            // 
            // olvActiveColumnSlot
            // 
            this.olvActiveColumnSlot.AspectName = "Slot";
            this.olvActiveColumnSlot.AspectToStringFormat = "";
            this.olvActiveColumnSlot.IsEditable = false;
            this.olvActiveColumnSlot.Text = "Slot";
            this.olvActiveColumnSlot.Width = 35;
            // 
            // olvActiveColumnEnabled
            // 
            this.olvActiveColumnEnabled.AspectName = "Enabled";
            this.olvActiveColumnEnabled.AspectToStringFormat = "";
            this.olvActiveColumnEnabled.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.olvActiveColumnEnabled.CheckBoxes = true;
            this.olvActiveColumnEnabled.Text = "Enabled";
            this.olvActiveColumnEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvActiveColumnEnabled.Width = 55;
            // 
            // olvActiveColumnID
            // 
            this.olvActiveColumnID.AspectName = "ID";
            this.olvActiveColumnID.AutoCompleteEditor = false;
            this.olvActiveColumnID.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvActiveColumnID.CellEditUseWholeCell = true;
            this.olvActiveColumnID.Text = "Item ID";
            this.olvActiveColumnID.Width = 80;
            // 
            // olvActiveColumnAmount
            // 
            this.olvActiveColumnAmount.AspectName = "Amount";
            this.olvActiveColumnAmount.CellEditUseWholeCell = true;
            this.olvActiveColumnAmount.Text = "Amount";
            this.olvActiveColumnAmount.Width = 50;
            // 
            // olvActiveColumnStatus
            // 
            this.olvActiveColumnStatus.AspectName = "Status";
            this.olvActiveColumnStatus.Text = "Status";
            this.olvActiveColumnStatus.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Active Inventory";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(322, 564);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inactive Inventory (corpse)";
            // 
            // fastObjectListView2
            // 
            this.fastObjectListView2.AllColumns.Add(this.olvInactiveColumnSlot);
            this.fastObjectListView2.AllColumns.Add(this.olvInactiveColumnEnabled);
            this.fastObjectListView2.AllColumns.Add(this.olvInactiveColumnID);
            this.fastObjectListView2.AllColumns.Add(this.olvInactiveColumnAmount);
            this.fastObjectListView2.AllColumns.Add(this.olvInactiveColumnStatus);
            this.fastObjectListView2.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.fastObjectListView2.CellEditUseWholeCell = false;
            this.fastObjectListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvInactiveColumnSlot,
            this.olvInactiveColumnEnabled,
            this.olvInactiveColumnID,
            this.olvInactiveColumnAmount,
            this.olvInactiveColumnStatus});
            this.fastObjectListView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListView2.Location = new System.Drawing.Point(383, 107);
            this.fastObjectListView2.Name = "fastObjectListView2";
            this.fastObjectListView2.ShowGroups = false;
            this.fastObjectListView2.Size = new System.Drawing.Size(325, 451);
            this.fastObjectListView2.TabIndex = 3;
            this.fastObjectListView2.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView2.View = System.Windows.Forms.View.Details;
            this.fastObjectListView2.VirtualMode = true;
            // 
            // olvInactiveColumnSlot
            // 
            this.olvInactiveColumnSlot.AspectName = "Slot";
            this.olvInactiveColumnSlot.IsEditable = false;
            this.olvInactiveColumnSlot.Text = "Slot";
            this.olvInactiveColumnSlot.Width = 35;
            // 
            // olvInactiveColumnEnabled
            // 
            this.olvInactiveColumnEnabled.AspectName = "Enabled";
            this.olvInactiveColumnEnabled.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.olvInactiveColumnEnabled.CheckBoxes = true;
            this.olvInactiveColumnEnabled.Text = "Enabled";
            this.olvInactiveColumnEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvInactiveColumnEnabled.Width = 55;
            // 
            // olvInactiveColumnID
            // 
            this.olvInactiveColumnID.AspectName = "ID";
            this.olvInactiveColumnID.CellEditUseWholeCell = true;
            this.olvInactiveColumnID.Text = "Item ID";
            this.olvInactiveColumnID.Width = 80;
            // 
            // olvInactiveColumnAmount
            // 
            this.olvInactiveColumnAmount.AspectName = "Amount";
            this.olvInactiveColumnAmount.CellEditUseWholeCell = true;
            this.olvInactiveColumnAmount.Text = "Amount";
            this.olvInactiveColumnAmount.Width = 50;
            // 
            // olvInactiveColumnStatus
            // 
            this.olvInactiveColumnStatus.AspectName = "Status";
            this.olvInactiveColumnStatus.Text = "Status";
            this.olvInactiveColumnStatus.Width = 80;
            // 
            // buttonResetActive
            // 
            this.buttonResetActive.Enabled = false;
            this.buttonResetActive.Location = new System.Drawing.Point(12, 564);
            this.buttonResetActive.Name = "buttonResetActive";
            this.buttonResetActive.Size = new System.Drawing.Size(68, 24);
            this.buttonResetActive.TabIndex = 4;
            this.buttonResetActive.Text = "Reset";
            this.buttonResetActive.UseVisualStyleBackColor = true;
            this.buttonResetActive.Click += new System.EventHandler(this.buttonResetActive_Click);
            // 
            // buttonResetCorpse
            // 
            this.buttonResetCorpse.Enabled = false;
            this.buttonResetCorpse.Location = new System.Drawing.Point(640, 564);
            this.buttonResetCorpse.Name = "buttonResetCorpse";
            this.buttonResetCorpse.Size = new System.Drawing.Size(68, 24);
            this.buttonResetCorpse.TabIndex = 8;
            this.buttonResetCorpse.Text = "Reset";
            this.buttonResetCorpse.UseVisualStyleBackColor = true;
            this.buttonResetCorpse.Click += new System.EventHandler(this.buttonResetCorpse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Work in progress! USE AT YOUR OWN RISK!";
            // 
            // buttonExport
            // 
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new System.Drawing.Point(241, 564);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(403, 564);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 7;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 614);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonResetCorpse);
            this.Controls.Add(this.buttonResetActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fastObjectListView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fastObjectListView1);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "NieR: Automata - Inventory Editor";
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private BrightIdeasSoftware.OLVColumn olvActiveColumnSlot;
        private BrightIdeasSoftware.OLVColumn olvActiveColumnEnabled;
        private BrightIdeasSoftware.OLVColumn olvActiveColumnID;
        private BrightIdeasSoftware.OLVColumn olvActiveColumnAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView2;
        private BrightIdeasSoftware.OLVColumn olvInactiveColumnSlot;
        private BrightIdeasSoftware.OLVColumn olvInactiveColumnEnabled;
        private BrightIdeasSoftware.OLVColumn olvInactiveColumnID;
        private BrightIdeasSoftware.OLVColumn olvInactiveColumnAmount;
        private System.Windows.Forms.Button buttonResetActive;
        private System.Windows.Forms.Button buttonResetCorpse;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.OLVColumn olvInactiveColumnStatus;
        private BrightIdeasSoftware.OLVColumn olvActiveColumnStatus;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
    }
}

