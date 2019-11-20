using PassMan.Desktop.Controls;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void AddEntryControlToPanel(PassEntry passEntry)
        {
            EntryDisplayControl c = new EntryDisplayControl(passEntry);
            flpEntriesSet.Controls.Add(c);
            c.Dock = DockStyle.Top;
            c.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewEntryWindow addNewEntryWindow = new AddNewEntryWindow();
            if (addNewEntryWindow.ShowDialog() == DialogResult.OK)
                AddEntryControlToPanel(addNewEntryWindow.Result);
        }
    }
}
