namespace PassMan.Desktop.Forms
{
    partial class MainWindow
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.trvGroups = new System.Windows.Forms.TreeView();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.flpEntriesSet = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.msMenu.SuspendLayout();
            this.tsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(747, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiSave,
            this.tsSeparator,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiNew
            // 
            this.tsmiNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGroup});
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(98, 22);
            this.tsmiNew.Text = "New";
            // 
            // tsmiNewGroup
            // 
            this.tsmiNewGroup.Name = "tsmiNewGroup";
            this.tsmiNewGroup.Size = new System.Drawing.Size(107, 22);
            this.tsmiNewGroup.Text = "Group";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(98, 22);
            this.tsmiSave.Text = "Save";
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(95, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(98, 22);
            this.tsmiExit.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(747, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // trvGroups
            // 
            this.trvGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvGroups.Location = new System.Drawing.Point(0, 24);
            this.trvGroups.Name = "trvGroups";
            this.trvGroups.Size = new System.Drawing.Size(144, 417);
            this.trvGroups.TabIndex = 2;
            // 
            // tsTools
            // 
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripSeparator1,
            this.tslblSearch,
            this.tstbSearch});
            this.tsTools.Location = new System.Drawing.Point(144, 24);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(603, 38);
            this.tsTools.TabIndex = 3;
            this.tsTools.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tslblSearch
            // 
            this.tslblSearch.Name = "tslblSearch";
            this.tslblSearch.Size = new System.Drawing.Size(75, 35);
            this.tslblSearch.Text = "Search Entry:";
            // 
            // tstbSearch
            // 
            this.tstbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbSearch.Name = "tstbSearch";
            this.tstbSearch.Size = new System.Drawing.Size(100, 38);
            // 
            // flpEntriesSet
            // 
            this.flpEntriesSet.AutoScroll = true;
            this.flpEntriesSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEntriesSet.Location = new System.Drawing.Point(144, 62);
            this.flpEntriesSet.Name = "flpEntriesSet";
            this.flpEntriesSet.Size = new System.Drawing.Size(603, 379);
            this.flpEntriesSet.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PassMan.Desktop.Properties.Resources.Add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 35);
            this.btnAdd.Text = "Add entry";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 463);
            this.Controls.Add(this.flpEntriesSet);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.trvGroups);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(763, 502);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "PassMan";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView trvGroups;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpEntriesSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblSearch;
        private System.Windows.Forms.ToolStripTextBox tstbSearch;
    }
}