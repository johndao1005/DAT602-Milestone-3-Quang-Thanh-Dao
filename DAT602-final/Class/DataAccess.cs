using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT602_final.Class
{
    internal class DataAccess
    {
        private static readonly String connectionString = "Server=localhost;Port=3306;Database=foodiedb;Uid=root;password=Hoalong986;";
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new(connectionString);

        public string CreateUser(string inputEmail, string inputUserName, string inputPassword, int inputAdmin = 0)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputEmail", MySqlDbType.VarChar, 255);
            aP.Value = inputEmail;
            p.Add(aP);
            var aP1 = new MySqlParameter("@inputUserName", MySqlDbType.VarChar, 255);
            aP1.Value = inputUserName;
            p.Add(aP1);
            var aP2 = new MySqlParameter("@inputPassword", MySqlDbType.VarChar, 255);
            aP2.Value = inputPassword;
            p.Add(aP2);
            var aP3 = new MySqlParameter("@inputAdmin", MySqlDbType.Int16);
            aP2.Value = inputAdmin;
            p.Add(aP3);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "CreateUser(@inputEmail,@inputUserName,@inputPassword,@inputAdmin)", p.ToArray());

            // expecting one table with one row
            return aDataSet.Tables[0].Rows[0]["message"].ToString();
        }

        public string AuthUser(string inputEmail, string inputPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputEmail", MySqlDbType.VarChar, 255);
            aP.Value = inputEmail;
            p.Add(aP);
            var aP2 = new MySqlParameter("@inputPassword", MySqlDbType.VarChar, 255);
            aP2.Value = inputPassword;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "AuthUser(@inputEmail,@inputPassword)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        public string LogoutUser(string email)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputEmail", MySqlDbType.VarChar, 255);
            aP.Value = email;
            p.Add(aP);
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "LogoutUser(@inputEmail)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        // In Progress

        public string DeleteUser(int inputID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "DeleteUser(@inputID)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        public DataSet GetCharacterLocation(int inputCharacterID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputCharacterID;
            p.Add(aP);

            return  MySqlHelper.ExecuteDataset(mySqlConnection, "GetCharacterLocation(@inputID)", p.ToArray());
        }

        public string EditUser(int inputID, string inputUserName, string inputEmail,  string inputPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aP1 = new MySqlParameter("@inputUserName", MySqlDbType.VarChar, 255);
            aP1.Value = inputUserName;
            p.Add(aP1);
            var aP2 = new MySqlParameter("@inputEmail", MySqlDbType.VarChar, 255);
            aP2.Value = inputEmail;
            p.Add(aP2);
            var aP3 = new MySqlParameter("@inputPassword", MySqlDbType.VarChar, 255);
            aP3.Value = inputPassword;
            p.Add(aP3);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "EditUser(@inputID,@inputUserName,@inputEmail,@inputPassword)", p.ToArray());
            // expecting one table with one row
            return aDataSet.Tables[0].Rows[0]["message"].ToString();
        }

        /*        Character*/
        public string CreateCharacter(int inputID, string inputName)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aP2 = new MySqlParameter("@inputName", MySqlDbType.VarChar, 255);
            aP2.Value = inputName;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "CreateCharacter(@inputID,@inputName)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        public string ResetCharacter(int inputID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "ResetCharacter(@inputID)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        /*Game Session*/
        public string CreateSession(int inputID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "CreateSession(@inputID)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        public string JoinSession(int inputID, int inputSessionID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aP1 = new MySqlParameter("@inputSessionID", MySqlDbType.Int32);
            aP1.Value = inputSessionID;
            p.Add(aP1);
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "JoinSession(@inputID,@inputSessionID)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        public string MovePosition(string inputDirection, int inputID, string mapName)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP1 = new MySqlParameter("@inputDirection", MySqlDbType.VarChar, 255);
            aP1.Value = inputDirection;
            p.Add(aP1);
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aP2 = new MySqlParameter("@mapName", MySqlDbType.VarChar, 255);
            aP2.Value = mapName;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "MovePosition(@inputDirection,@inputID,@mapName)", p.ToArray());
            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        public string FinishGame(int inputID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "FinishGame(@inputID)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        public string RemoveSession(int inputID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputID", MySqlDbType.Int32);
            aP.Value = inputID;
            p.Add(aP);
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "RemoveSession(@inputID)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //Checking

        public DataSet GetOnlineSession()
        {
            return MySqlHelper.ExecuteDataset(mySqlConnection, "GetOnlineSession()");
        }

        public DataSet GetAllSession()
        {
            return MySqlHelper.ExecuteDataset(mySqlConnection, "GetAllSession()");
        }

        public DataSet GetOnlineUsers()
        {
           return MySqlHelper.ExecuteDataset(mySqlConnection, "GetOnlineUsers()");

        }

        public DataSet GetAllUsers()
        {
            return  MySqlHelper.ExecuteDataset(mySqlConnection, "GetAllUsers()");
        }


        public DataSet GetChatLog()
        {
            return MySqlHelper.ExecuteDataset(mySqlConnection, "GetChatLog()");

        }

        public DataRow GetUserDetails(string inputEmail)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@inputEmail", MySqlDbType.VarChar, 255);
            aP.Value = inputEmail;
            p.Add(aP);
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "GetUserDetails(@inputEmail)", p.ToArray());

            // expecting one table with one row
            return aDataSet.Tables[0].Rows[0];
        }

    }
}
