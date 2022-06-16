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
        string _email;
        private DataRow? _user;
        private DataRow? _session;
        private UserDetailsForm _userDetailsForm = new();
        private GameScreen _gameScreen;
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
            _email = email;
            UpdateDisplay();
            return ShowDialog() == DialogResult.Cancel;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
         
        private void UpdateDisplay()
        {
            _user = _dbAccess.GetUserDetails(_email);
            User.Text = _user["username"].ToString();
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

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Join_Click(object sender, EventArgs e)
        {
            if (GameList.RowCount == 0)
            {
                MessageBox.Show("There are no Session", "Edit Session", MessageBoxButtons.OK);
                return;
            }
            if (GameList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a Session", "Edit Session", MessageBoxButtons.OK);
                return;
            }
            _session = (DataRow)((DataRowView)GameList.SelectedRows[0].DataBoundItem).Row;
            if (_session == null)
            {
                MessageBox.Show("Please select a Session", "Edit Session", MessageBoxButtons.OK);
                return;
            }
            int sessionId = Convert.ToInt32(_session["sessionID"]);
            int userId = Convert.ToInt32(_user["userID"]);
            string message = _dbAccess.JoinSession(userId, sessionId);
            if(message == "Welcome to the game <3" )
            {
                _gameScreen = new();
                this.Hide();
                if(sessionId != 0 && _gameScreen.ShowDialog(_session, userId))
                {
                    UpdateDisplay();
                }
                this.Show();
            }
        }
    }
}
