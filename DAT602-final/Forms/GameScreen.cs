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
    public partial class GameScreen : Form
    {
        private DataRow _session;
        PictureBox[,] _tiles;
        string _map;
        private int _character1;
        private int _character2;
        Class.DataAccess _dbAccess = new();
        public GameScreen()
        {
            InitializeComponent();
        }

        public bool ShowDialog(DataRow session, int id2)
        {   _session = session;
            _character1 = Convert.ToInt32(_session["characterID_1"]);
            _character2 = id2;
            _map = (_session["session_map"]).ToString();
            UpdateDisplay();
            return this.ShowDialog() == DialogResult.OK;

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            int row = (pictureBox.Top / 70);
            int col = (pictureBox.Left / 70);
            MessageBox.Show("The (row,col) is (" + row.ToString() + "," + col.ToString() + ")");
        }

        private void UpdateDisplay()
        {
            PictureBox[,] Tiles = new PictureBox[100, 100];
            //  Use PictureBoxes as Tiles

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Tiles[row, col] = new PictureBox();
                    Tiles[row, col].Width = 70;
                    Tiles[row, col].Height = 70;
                    Tiles[row, col].BackColor = Color.Red;
                    Tiles[row, col].Left = col * 71;
                    Tiles[row, col].Top = row * 71;
                    Tiles[row, col].Click += pictureBox_Click;
                    this.Controls.Add(Tiles[row, col]);
                    this.Invalidate();
                }
            }

            DataRow location1 = _dbAccess.GetCharacterLocation(_character1).Tables[0].Rows[0];
            DataRow location2 = _dbAccess.GetCharacterLocation(_character2).Tables[0].Rows[0];
            int row1 = Convert.ToInt32(location1["row"]);
            int column1 = Convert.ToInt32(location1["column"]);
            Tiles[row1, column1].BackColor = Color.Black;
            Tiles[Convert.ToInt32(location2["row"]), Convert.ToInt32(location2["column"])].BackColor = Color.Black;
            BindingSource chatLog = new();
            chatLog.DataSource = _dbAccess.GetChatLog().Tables[0];
            ChatList.DataSource = chatLog;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Left_Click(object sender, EventArgs e)
        {

            Move("Left");
        }

        private void Down_Click(object sender, EventArgs e)
        {

            Move("Down");
        }

        private void Right_Click(object sender, EventArgs e)
        {
            Move("Right");
        }

        private void Up_Click(object sender, EventArgs e)
        {
            Move("Up");
        }

        private void Move(string direction)
        {
            _dbAccess.MovePosition(direction, _character1, _map);
            UpdateDisplay();
        }
    }
}
