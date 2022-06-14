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
    public partial class RegisterForm : Form
    {
        private User _user;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public bool ShowDialog(User user)
        {
            _user = user;
            return ShowDialog() == DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       
    }
}
