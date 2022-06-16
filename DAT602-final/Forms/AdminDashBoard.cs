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
    public partial class AdminDashBoard : Form
    {
        private DataRow? _user;
        Class.DataAccess _dbAccess = new();
        private UserDetailsForm _form;
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        public bool ShowDialog(string email)
        {
            _user = _dbAccess.GetUserDetails(email);
            User.Text = _user["username"].ToString();
            UpdateDisplay();
            return ShowDialog() == DialogResult.Cancel;
        }

        private void UpdateDisplay()
        {
            /* User.Text = _user.Email;*/
            BindingSource allUsers = new();
            allUsers.DataSource = _dbAccess.GetAllUsers().Tables[0];
            UserList.DataSource = allUsers;
            BindingSource allGames = new();
            allGames.DataSource = _dbAccess.GetAllSession().Tables[0];
            GameList.DataSource = allGames;
            BindingSource chatLog = new();
            chatLog.DataSource = _dbAccess.GetChatLog().Tables[0];
            ChatList.DataSource = chatLog;
        }

        private void AdminDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            SelectItem();
            EditUser(_user);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            EditUser(_user);
        }

        private void EditUser(DataRow? user)
        {
            _form = new();
            if (user != null && _form.ShowDialog(user))
            {
                UpdateDisplay();
            }
        }

        private void UserList_DoubleClick(object sender, EventArgs e)
        {
            SelectItem();
            EditUser(_user);
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            SelectItem();
            int id = Convert.ToInt32(_user["userID"]);
            string message = _dbAccess.DeleteUser(id);
            if(message == "User is deleted")
            {
                UpdateDisplay();
            }
        }

        private void SelectItem()
        {
            if (UserList.RowCount == 0)
            {
                MessageBox.Show("There are no user?", "Edit User", MessageBoxButtons.OK);
                return;
            }
            if (UserList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a user", "Edit User", MessageBoxButtons.OK);
                return;
            }
            _user = (DataRow)((DataRowView)UserList.SelectedRows[0].DataBoundItem).Row;
            if (_user == null)
            {
                MessageBox.Show("Please select a user", "Edit User", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
