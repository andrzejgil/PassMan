using PassMan.Utils.Models.PassEntry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMan.Desktop.Forms
{
    public partial class AddNewEntryWindow : Form
    {
        public PassEntry Result {get;}

        public AddNewEntryWindow()
        {
            InitializeComponent();
            Result = new PassEntry();
        }

        private void tbEntryName_TextChanged(object sender, EventArgs e)
        {
            Result.Name = tbEntryName.Text;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            Result.EncryptedValue = tbPassword.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Validate()
        {
            string errorMessage = "";
            bool result = true;

            if (string.IsNullOrEmpty(tbEntryName.Text))
                errorMessage += "Entry name cannot be empty!\n";
            if (string.IsNullOrEmpty(tbPassword.Text))
                errorMessage += "Password cannot be empty!";

            if (errorMessage != "")
            {
                result = false;
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }
    }
}
