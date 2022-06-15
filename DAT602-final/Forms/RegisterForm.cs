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
        private User _user = new();
        Class.DataAccess _dbAccess = new();
        private LoginForm _form;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public bool ShowDialog(User user, LoginForm form)
        {
            _user = user;
            _form = form;
            return this.ShowDialog() == DialogResult.OK;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _form.Show();
            DialogResult = DialogResult.Cancel;
        }

        private void PushData()
        {
            _user.Email = Email.Text;
            _user.Name = UserName.Text;
            _user.Password = Password.Text;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string username = UserName.Text;
            string password = Password.Text;
            string confirmPassword = ConfirmPassword.Text;
            if (
                email.Length == 0 || 
                username.Length == 0 ||
                password.Length == 0 ||
                confirmPassword.Length == 0
                )
            {
                MessageBox.Show("Please fill up all the information", "Register", MessageBoxButtons.OK);
                return;
            }

            if (!String.Equals(ConfirmPassword.Text, Password.Text))
            {
                MessageBox.Show("Please ensure confirm password is match with ur password", "Register", MessageBoxButtons.OK);
                return;
            }
            string message = _dbAccess.CreateUser(email, username, password);
            if (message == "Created User")
            {
                PushData();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(message, "Register", MessageBoxButtons.OK);
                return;
            }

        }
    }
}
