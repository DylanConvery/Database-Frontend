namespace Database_Frontend {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxDataBaseTable = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxInputEntry = new System.Windows.Forms.GroupBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.petrolCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelColumns = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInputEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 309);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(90, 31);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New";
            this.toolTip1.SetToolTip(this.buttonNew, "Create new entry");
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(109, 309);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 31);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Save your data");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(778, 308);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.buttonDelete, "Delete the selected record");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxDataBaseTable
            // 
            this.listBoxDataBaseTable.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listBoxDataBaseTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDataBaseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDataBaseTable.FormattingEnabled = true;
            this.listBoxDataBaseTable.HorizontalScrollbar = true;
            this.listBoxDataBaseTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxDataBaseTable.Location = new System.Drawing.Point(338, 62);
            this.listBoxDataBaseTable.Name = "listBoxDataBaseTable";
            this.listBoxDataBaseTable.Size = new System.Drawing.Size(530, 223);
            this.listBoxDataBaseTable.TabIndex = 9;
            this.listBoxDataBaseTable.SelectedIndexChanged += new System.EventHandler(this.listBoxDataBaseTable_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemQuit
            // 
            this.toolStripMenuItemQuit.Image = global::Database_Frontend.Properties.Resources.exit;
            this.toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            this.toolStripMenuItemQuit.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItemQuit.Text = "Quit";
            this.toolStripMenuItemQuit.Click += new System.EventHandler(this.toolStripMenuItemQuit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Image = global::Database_Frontend.Properties.Resources.info;
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Manufacturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Engine Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Engine Size:";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(122, 24);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(162, 20);
            this.manufacturerTextBox.TabIndex = 1;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(122, 65);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(162, 20);
            this.modelTextBox.TabIndex = 2;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(122, 109);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(162, 20);
            this.colorTextBox.TabIndex = 3;
            // 
            // groupBoxInputEntry
            // 
            this.groupBoxInputEntry.Controls.Add(this.engineSizeTextBox);
            this.groupBoxInputEntry.Controls.Add(this.petrolCheckBox);
            this.groupBoxInputEntry.Controls.Add(this.label2);
            this.groupBoxInputEntry.Controls.Add(this.colorTextBox);
            this.groupBoxInputEntry.Controls.Add(this.label3);
            this.groupBoxInputEntry.Controls.Add(this.modelTextBox);
            this.groupBoxInputEntry.Controls.Add(this.label4);
            this.groupBoxInputEntry.Controls.Add(this.manufacturerTextBox);
            this.groupBoxInputEntry.Controls.Add(this.label5);
            this.groupBoxInputEntry.Controls.Add(this.label6);
            this.groupBoxInputEntry.Enabled = false;
            this.groupBoxInputEntry.Location = new System.Drawing.Point(12, 54);
            this.groupBoxInputEntry.Name = "groupBoxInputEntry";
            this.groupBoxInputEntry.Size = new System.Drawing.Size(306, 234);
            this.groupBoxInputEntry.TabIndex = 23;
            this.groupBoxInputEntry.TabStop = false;
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.Location = new System.Drawing.Point(122, 189);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(162, 20);
            this.engineSizeTextBox.TabIndex = 5;
            // 
            // petrolCheckBox
            // 
            this.petrolCheckBox.AutoSize = true;
            this.petrolCheckBox.Location = new System.Drawing.Point(122, 152);
            this.petrolCheckBox.Name = "petrolCheckBox";
            this.petrolCheckBox.Size = new System.Drawing.Size(53, 17);
            this.petrolCheckBox.TabIndex = 4;
            this.petrolCheckBox.Text = "Petrol";
            this.petrolCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(205, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 31);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.buttonCancel, "Return to View Mode");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mode:";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMode.Location = new System.Drawing.Point(46, 34);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(30, 13);
            this.labelMode.TabIndex = 26;
            this.labelMode.Text = "View";
            this.toolTip1.SetToolTip(this.labelMode, "Current Mode");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 200;
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(338, 43);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(0, 13);
            this.labelColumns.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 356);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBoxInputEntry);
            this.Controls.Add(this.listBoxDataBaseTable);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Database Frontend";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInputEntry.ResumeLayout(false);
            this.groupBoxInputEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.ListBox listBoxDataBaseTable;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox manufacturerTextBox;
		private System.Windows.Forms.TextBox modelTextBox;
		private System.Windows.Forms.TextBox colorTextBox;
		private System.Windows.Forms.GroupBox groupBoxInputEntry;
		private System.Windows.Forms.CheckBox petrolCheckBox;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox engineSizeTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelMode;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelColumns;
    }
}

