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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fastObjectListView2 = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonResetActive = new System.Windows.Forms.Button();
            this.buttonResetCorpse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(95, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open save file...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 20);
            this.textBox1.TabIndex = 1;
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.olvColumn1);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn2);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn3);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn4);
            this.fastObjectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
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
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Slot";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Slot";
            this.olvColumn1.Width = 40;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Status";
            this.olvColumn2.Text = "Status";
            this.olvColumn2.Width = 100;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "ID";
            this.olvColumn3.Text = "Item ID";
            this.olvColumn3.Width = 80;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Count";
            this.olvColumn4.Text = "Item Count";
            this.olvColumn4.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Active Inventory";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(322, 564);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
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
            this.label2.TabIndex = 5;
            this.label2.Text = "File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inactive Inventory (corpse)";
            // 
            // fastObjectListView2
            // 
            this.fastObjectListView2.AllColumns.Add(this.olvColumn5);
            this.fastObjectListView2.AllColumns.Add(this.olvColumn6);
            this.fastObjectListView2.AllColumns.Add(this.olvColumn7);
            this.fastObjectListView2.AllColumns.Add(this.olvColumn8);
            this.fastObjectListView2.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.fastObjectListView2.CellEditUseWholeCell = false;
            this.fastObjectListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8});
            this.fastObjectListView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListView2.Location = new System.Drawing.Point(383, 107);
            this.fastObjectListView2.Name = "fastObjectListView2";
            this.fastObjectListView2.ShowGroups = false;
            this.fastObjectListView2.Size = new System.Drawing.Size(325, 451);
            this.fastObjectListView2.TabIndex = 6;
            this.fastObjectListView2.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView2.View = System.Windows.Forms.View.Details;
            this.fastObjectListView2.VirtualMode = true;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Slot";
            this.olvColumn5.IsEditable = false;
            this.olvColumn5.Text = "Slot";
            this.olvColumn5.Width = 40;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Status";
            this.olvColumn6.Text = "Status";
            this.olvColumn6.Width = 100;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "ID";
            this.olvColumn7.Text = "Item ID";
            this.olvColumn7.Width = 80;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Count";
            this.olvColumn8.Text = "Item Count";
            this.olvColumn8.Width = 80;
            // 
            // buttonResetActive
            // 
            this.buttonResetActive.Location = new System.Drawing.Point(12, 564);
            this.buttonResetActive.Name = "buttonResetActive";
            this.buttonResetActive.Size = new System.Drawing.Size(68, 24);
            this.buttonResetActive.TabIndex = 8;
            this.buttonResetActive.Text = "Reset";
            this.buttonResetActive.UseVisualStyleBackColor = true;
            this.buttonResetActive.Click += new System.EventHandler(this.buttonResetActive_Click);
            // 
            // buttonResetCorpse
            // 
            this.buttonResetCorpse.Location = new System.Drawing.Point(640, 564);
            this.buttonResetCorpse.Name = "buttonResetCorpse";
            this.buttonResetCorpse.Size = new System.Drawing.Size(68, 24);
            this.buttonResetCorpse.TabIndex = 9;
            this.buttonResetCorpse.Text = "Reset";
            this.buttonResetCorpse.UseVisualStyleBackColor = true;
            this.buttonResetCorpse.Click += new System.EventHandler(this.buttonResetCorpse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Work in progress! USE AT YOUR OWN RISK!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonResetCorpse);
            this.Controls.Add(this.buttonResetActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fastObjectListView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fastObjectListView1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView2;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private System.Windows.Forms.Button buttonResetActive;
        private System.Windows.Forms.Button buttonResetCorpse;
        private System.Windows.Forms.Label label4;
    }
}

