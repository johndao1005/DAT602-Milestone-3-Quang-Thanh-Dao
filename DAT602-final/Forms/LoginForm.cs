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
    public partial class LoginForm : Form
    {
        private User? _user;
        private MainDashboard _mainDashboard = new();
        private AdminDashBoard _adminDashBoard = new();
        private RegisterForm _registerForm = new();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // check email and password

            // store message into a string
            string message = "";
            if (message == "")
            {
                this.Hide();
                if(_mainDashboard.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                } 
            } else if(message == "")
            {
                MessageBox.Show("Email and password is not match", "Login Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_registerForm.ShowDialog()== DialogResult.Cancel)
            {
                this.Show();
            } else
            {
                this.Hide();
                if (_mainDashboard.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
    }
}
