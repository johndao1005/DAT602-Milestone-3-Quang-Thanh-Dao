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
        private MainDashboard _mainDashboard;
        private AdminDashBoard _adminDashBoard;
        private RegisterForm _registerForm;
        Class.DataAccess _dbAccess = new();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        { 
            CloseApplication();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            _user = new();
            // check email and password
            string email = this.Email.Text;
            string password = this.Password.Text;
            if (
                email.Length == 0 ||
                password.Length == 0
                )
            {
                MessageBox.Show("Please fill up all the information", "Login", MessageBoxButtons.OK);
                return;
            }

            string message = _dbAccess.AuthUser(email, password);

            _user.Email = email;
            // store message into a string
            if (message == "Hello admin" && _user !=null)
            {
                OpenDashBoard(true);
            } else if(message == "Hello user")
            {
                OpenDashBoard(false);
            }
            else
            {
                MessageBox.Show(message, "Login Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            _registerForm = new();
            _user = new();
            this.Hide();
            if (_user != null && _registerForm.ShowDialog(_user, this))
            {
                OpenDashBoard(false);
            }
        }

        private void OpenDashBoard(bool admin)
        {
            this.Hide();
            if (admin == true)
            {
                _adminDashBoard = new();
                if (_adminDashBoard.ShowDialog(_user.Email))
                {
                    CloseApplication();
                }
            }
            else
            {
                _mainDashboard = new();
                if (_mainDashboard.ShowDialog(_user.Email))
                {
                    CloseApplication();
                }
            }
        }

        public void CloseApplication()
        {
            if(_user != null)
            {
                _dbAccess.LogoutUser(_user.Email);
            }
            this.Close();
        }
    }
}
