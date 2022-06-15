using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT602_final
{
    public class User
    {
        private string? _id;
        private string? _name;
        private string? _email;
        private string? _password;
        private int _loginAttempt = 3;
        private int _highestScore = 0;
        private bool _adminCheck = false;
        private bool _isLogin = false;
        private bool _inGame = false;



        public bool InGame
        {
            get { return _inGame; }
            set { _inGame = value; }
        }

        public bool IsLogin
        {
            get { return _isLogin; }
            set { _isLogin = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool AdminCheck
        {
            get { return _adminCheck; }
            set { _adminCheck = value; }
        }

        public bool Lockout()
        {
            return _loginAttempt > 5;
        }

        public void UpdateScore(int newScore)
        {
            if(newScore > _highestScore)
            {
            _highestScore = newScore;
            }
        }

       
    }
}
