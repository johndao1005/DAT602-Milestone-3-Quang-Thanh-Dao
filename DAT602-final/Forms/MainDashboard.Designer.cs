namespace DAT602_final.Forms
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Join = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Invite = new System.Windows.Forms.Button();
            this.Detail = new System.Windows.Forms.Button();
            this.ChatList = new System.Windows.Forms.DataGridView();
            this.GameList = new System.Windows.Forms.DataGridView();
            this.UserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(796, 419);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Quit";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(677, 250);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(213, 91);
            this.Password.TabIndex = 20;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(796, 351);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 29);
            this.Send.TabIndex = 19;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // Join
            // 
            this.Join.Location = new System.Drawing.Point(374, 351);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(94, 29);
            this.Join.TabIndex = 25;
            this.Join.Text = "Join";
            this.Join.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Active Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Active Game";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(717, 32);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(38, 20);
            this.User.TabIndex = 29;
            this.User.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Welcome";
            // 
            // Invite
            // 
            this.Invite.Location = new System.Drawing.Point(43, 351);
            this.Invite.Name = "Invite";
            this.Invite.Size = new System.Drawing.Size(94, 29);
            this.Invite.TabIndex = 30;
            this.Invite.Text = "Invite";
            this.Invite.UseVisualStyleBackColor = true;
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(792, 28);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(94, 29);
            this.Detail.TabIndex = 31;
            this.Detail.Text = "User Detail";
            this.Detail.UseVisualStyleBackColor = true;
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // ChatList
            // 
            this.ChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChatList.Location = new System.Drawing.Point(677, 70);
            this.ChatList.Name = "ChatList";
            this.ChatList.RowHeadersWidth = 51;
            this.ChatList.RowTemplate.Height = 29;
            this.ChatList.Size = new System.Drawing.Size(209, 156);
            this.ChatList.TabIndex = 40;
            // 
            // GameList
            // 
            this.GameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameList.Location = new System.Drawing.Point(374, 70);
            this.GameList.Name = "GameList";
            this.GameList.RowHeadersWidth = 51;
            this.GameList.RowTemplate.Height = 29;
            this.GameList.Size = new System.Drawing.Size(266, 271);
            this.GameList.TabIndex = 39;
            // 
            // UserList
            // 
            this.UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList.Location = new System.Drawing.Point(43, 70);
            this.UserList.Name = "UserList";
            this.UserList.RowHeadersWidth = 51;
            this.UserList.RowTemplate.Height = 29;
            this.UserList.Size = new System.Drawing.Size(280, 271);
            this.UserList.TabIndex = 38;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 476);
            this.Controls.Add(this.ChatList);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.Invite);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Send);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel;
        private TextBox Password;
        private Button Send;
        private Button Join;
        private Label label2;
        private Label label1;
        private Label User;
        private Label label3;
        private Button Invite;
        private Button Detail;
        private DataGridView ChatList;
        private DataGridView GameList;
        private DataGridView UserList;
    }
}