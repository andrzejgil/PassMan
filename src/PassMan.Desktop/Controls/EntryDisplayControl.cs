using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassMan.Utils.Models.PassEntry;

namespace PassMan.Desktop.Controls
{
    public partial class EntryDisplayControl : UserControl
    {
        private readonly PassEntry _passEntry;

        public string Password
        {
            get { return tbPassword.Text; }
        }

        public string EntryName
        {
            get { return lblEntryName.Text; }
        }
        public EntryDisplayControl(PassEntry passEntry)
        {
            InitializeComponent();
            tbPassword.Text = passEntry.EncryptedValue;
            lblEntryName.Text = passEntry.Name;
            _passEntry = passEntry;
        }

        private void btnView_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0';
        }

        private void btnView_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!tbPassword.ReadOnly)
            {
                tbPassword.ReadOnly = true;
                tbPassword.PasswordChar = '*';
                _passEntry.EncryptedValue = tbPassword.Text;
            }
            else
            {
                tbPassword.ReadOnly = false;
                tbPassword.PasswordChar = '\0';
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
