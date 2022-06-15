using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT602_final.Forms
{
    public partial class UserDetailsForm : Form
    {
        private DataRow _user;
        public UserDetailsForm()
        {
            InitializeComponent();
        }

        public bool ShowDialog(DataRow user)
        {
            _user = user;
            return this.ShowDialog() == DialogResult.OK;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // get the data from user and update the field
            PushData();
            DialogResult = DialogResult.OK;
        }

        private void PushData()
        {
            // update the data
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
