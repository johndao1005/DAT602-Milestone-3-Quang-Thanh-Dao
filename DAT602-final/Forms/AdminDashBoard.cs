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
        private DataRow _user = new();
        Class.DataAccess _dbAccess = new();
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
    }
}
