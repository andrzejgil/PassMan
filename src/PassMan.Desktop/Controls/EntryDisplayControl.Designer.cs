namespace PassMan.Desktop.Controls
{
    partial class EntryDisplayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblEntryName = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tlpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.ColumnCount = 5;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpLayout.Controls.Add(this.tbPassword, 1, 0);
            this.tlpLayout.Controls.Add(this.lblEntryName, 0, 0);
            this.tlpLayout.Controls.Add(this.btnView, 2, 0);
            this.tlpLayout.Controls.Add(this.btnEdit, 3, 0);
            this.tlpLayout.Controls.Add(this.btnDelete, 4, 0);
            this.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 1;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayout.Size = new System.Drawing.Size(523, 46);
            this.tlpLayout.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(114, 10);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(268, 26);
            this.tbPassword.TabIndex = 0;
            // 
            // lblEntryName
            // 
            this.lblEntryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEntryName.AutoSize = true;
            this.lblEntryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEntryName.Location = new System.Drawing.Point(30, 13);
            this.lblEntryName.Name = "lblEntryName";
            this.lblEntryName.Size = new System.Drawing.Size(51, 20);
            this.lblEntryName.TabIndex = 1;
            this.lblEntryName.Text = "label1";
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = global::PassMan.Desktop.Properties.Resources.View;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.Location = new System.Drawing.Point(388, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(40, 40);
            this.btnView.TabIndex = 2;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnView_MouseDown);
            this.btnView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnView_MouseUp);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::PassMan.Desktop.Properties.Resources.Edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(434, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::PassMan.Desktop.Properties.Resources.Remove;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(480, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EntryDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpLayout);
            this.Name = "EntryDisplayControl";
            this.Size = new System.Drawing.Size(523, 46);
            this.tlpLayout.ResumeLayout(false);
            this.tlpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLayout;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblEntryName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
