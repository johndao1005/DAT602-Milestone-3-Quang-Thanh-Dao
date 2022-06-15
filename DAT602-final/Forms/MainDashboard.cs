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
        private DataRow _user;
        private UserDetailsForm _userDetailsForm = new();
        Class.DataAccess _dbAccess = new();
        public MainDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display the form and add the user info
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ShowDialog(string email)
        {
            _user = _dbAccess.GetUserDetails(email);
            User.Text = _user["username"].ToString();
            UpdateDisplay();
            return ShowDialog() == DialogResult.Cancel;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
         
        private void UpdateDisplay()
        {
           /* User.Text = _user.Email;*/
            BindingSource allUsers = new();
            allUsers.DataSource = _dbAccess.GetOnlineUsers().Tables[0];
            UserList.DataSource = allUsers;
            BindingSource allGames = new();
            allGames.DataSource = _dbAccess.GetOnlineSession().Tables[0];
            GameList.DataSource = allGames;
            BindingSource chatLog = new();
            chatLog.DataSource = _dbAccess.GetChatLog().Tables[0];
            ChatList.DataSource = chatLog;
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if(_user != null && _userDetailsForm.ShowDialog(_user))
            {
                UpdateDisplay();
            }
        }

        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
