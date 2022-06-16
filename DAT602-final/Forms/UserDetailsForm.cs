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
        Class.DataAccess _dbAccess = new();
        public UserDetailsForm()
        {
            InitializeComponent();
        }

        public bool ShowDialog(DataRow user)
        {
            _user = user;
            Name.Text = _user["username"].ToString();
            Email.Text = _user["email"].ToString(); 
            Password.Text = _user["password"].ToString();
            return this.ShowDialog() == DialogResult.OK;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // get the data from user and update the field
            PushData();
        }

        private void PushData()
        {
            string email = Email.Text;
            string password = Password.Text;
            string name = Name.Text;
            int id = Convert.ToInt32(_user["userID"]);
            string message = _dbAccess.EditUser(id,name,email,password);
            if(message == "update success")
            {
            DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(message, "Edit User", MessageBoxButtons.OK);
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
