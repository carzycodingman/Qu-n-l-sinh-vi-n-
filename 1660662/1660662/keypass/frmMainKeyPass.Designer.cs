namespace keypass
{
    partial class frmMainKeyPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainKeyPass));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openKeyPass = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKeyPass = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasKeyPass = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCheckBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Entry = new System.Windows.Forms.ToolStripDropDownButton();
            this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.folderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lbInformation = new System.Windows.Forms.Label();
            this.newFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openKeyPass,
            this.saveKeyPass,
            this.saveasKeyPass});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openKeyPass
            // 
            this.openKeyPass.Name = "openKeyPass";
            this.openKeyPass.Size = new System.Drawing.Size(112, 22);
            this.openKeyPass.Text = "Open";
            this.openKeyPass.Click += new System.EventHandler(this.openKeyPass_Click);
            // 
            // saveKeyPass
            // 
            this.saveKeyPass.Name = "saveKeyPass";
            this.saveKeyPass.Size = new System.Drawing.Size(112, 22);
            this.saveKeyPass.Text = "Save as";
            this.saveKeyPass.Click += new System.EventHandler(this.saveKeyPass_Click);
            // 
            // saveasKeyPass
            // 
            this.saveasKeyPass.Name = "saveasKeyPass";
            this.saveasKeyPass.Size = new System.Drawing.Size(112, 22);
            this.saveasKeyPass.Text = "Save";
            this.saveasKeyPass.Click += new System.EventHandler(this.saveasKeyPass_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.itemCheckBoxToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // itemCheckBoxToolStripMenuItem
            // 
            this.itemCheckBoxToolStripMenuItem.CheckOnClick = true;
            this.itemCheckBoxToolStripMenuItem.Name = "itemCheckBoxToolStripMenuItem";
            this.itemCheckBoxToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.itemCheckBoxToolStripMenuItem.Text = "Item check boxes";
            this.itemCheckBoxToolStripMenuItem.Click += new System.EventHandler(this.itemCheckBoxToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Entry});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Entry
            // 
            this.Entry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Entry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem1});
            this.Entry.Image = ((System.Drawing.Image)(resources.GetObject("Entry.Image")));
            this.Entry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(47, 22);
            this.Entry.Text = "Entry";
            this.Entry.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // addEntryToolStripMenuItem
            // 
            this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
            this.addEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEntryToolStripMenuItem.Text = "Add Entry";
            this.addEntryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToolStripMenuItem_Click);
            // 
            // deleteEntryToolStripMenuItem1
            // 
            this.deleteEntryToolStripMenuItem1.Name = "deleteEntryToolStripMenuItem1";
            this.deleteEntryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteEntryToolStripMenuItem1.Text = "Delete Entry";
            this.deleteEntryToolStripMenuItem1.Click += new System.EventHandler(this.deleteEntryToolStripMenuItem1_Click);
            // 
            // saveFile
            // 
            this.saveFile.FileName = "keypass.txt";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colUserName,
            this.colPassword,
            this.colURL,
            this.colNotes});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.Size = new System.Drawing.Size(480, 324);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Resize += new System.EventHandler(this.listView1_Resize);
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 100;
            // 
            // colUserName
            // 
            this.colUserName.Text = "User Name";
            this.colUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colUserName.Width = 115;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPassword.Width = 109;
            // 
            // colURL
            // 
            this.colURL.Text = "URL";
            this.colURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colURL.Width = 81;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Notes";
            this.colNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colNotes.Width = 73;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(721, 324);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(237, 324);
            this.treeView1.TabIndex = 0;
            // 
            // lbInformation
            // 
            this.lbInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbInformation.Location = new System.Drawing.Point(0, 373);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(721, 77);
            this.lbInformation.TabIndex = 3;
            this.lbInformation.Click += new System.EventHandler(this.lbInformation_Click);
            // 
            // frmMainKeyPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbInformation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainKeyPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyPass";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openKeyPass;
        private System.Windows.Forms.ToolStripMenuItem saveKeyPass;
        private System.Windows.Forms.ToolStripMenuItem saveasKeyPass;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderPath;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colURL;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.ToolStripDropDownButton Entry;
        private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemCheckBoxToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog newFile;
    }
}

