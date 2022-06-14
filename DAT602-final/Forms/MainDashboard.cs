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
    public partial class MainDashboard : Form
    {
        private User _user;
        private UserDetailsForm _userDetailsForm = new();
        public MainDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display the form and add the user info
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ShowDialog(User user)
        {
            _user = user;
            return ShowDialog() == DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UpdateDisplay()
        {
            User.Text = _user.Name;

        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if(_user != null && _userDetailsForm.ShowDialog(_user))
            {
                UpdateDisplay();
            }
        }
    }
}
