namespace DAT602_final.Forms
{
    partial class AdminDashBoard
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
            this.Detail = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteGame = new System.Windows.Forms.Button();
            this.ChatList = new System.Windows.Forms.DataGridView();
            this.GameList = new System.Windows.Forms.DataGridView();
            this.UserList = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(780, 36);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(94, 29);
            this.Detail.TabIndex = 44;
            this.Detail.Text = "User Detail";
            this.Detail.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(31, 359);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 29);
            this.Edit.TabIndex = 43;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(705, 40);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(38, 20);
            this.User.TabIndex = 42;
            this.User.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Active Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Active Users";
            // 
            // DeleteGame
            // 
            this.DeleteGame.Location = new System.Drawing.Point(362, 359);
            this.DeleteGame.Name = "DeleteGame";
            this.DeleteGame.Size = new System.Drawing.Size(94, 29);
            this.DeleteGame.TabIndex = 38;
            this.DeleteGame.Text = "Delete";
            this.DeleteGame.UseVisualStyleBackColor = true;
            // 
            // ChatList
            // 
            this.ChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChatList.Location = new System.Drawing.Point(665, 78);
            this.ChatList.Name = "ChatList";
            this.ChatList.RowHeadersWidth = 51;
            this.ChatList.RowTemplate.Height = 29;
            this.ChatList.Size = new System.Drawing.Size(209, 156);
            this.ChatList.TabIndex = 37;
            // 
            // GameList
            // 
            this.GameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameList.Location = new System.Drawing.Point(362, 78);
            this.GameList.Name = "GameList";
            this.GameList.RowHeadersWidth = 51;
            this.GameList.RowTemplate.Height = 29;
            this.GameList.Size = new System.Drawing.Size(266, 271);
            this.GameList.TabIndex = 36;
            // 
            // UserList
            // 
            this.UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList.Location = new System.Drawing.Point(31, 78);
            this.UserList.Name = "UserList";
            this.UserList.RowHeadersWidth = 51;
            this.UserList.RowTemplate.Height = 29;
            this.UserList.Size = new System.Drawing.Size(280, 271);
            this.UserList.TabIndex = 35;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(784, 427);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Quit";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(665, 258);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(213, 91);
            this.Password.TabIndex = 33;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(784, 359);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 29);
            this.Send.TabIndex = 32;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(217, 359);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(94, 29);
            this.DeleteUser.TabIndex = 45;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(217, 36);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 29);
            this.Create.TabIndex = 46;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteGame);
            this.Controls.Add(this.ChatList);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Send);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashBoard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Detail;
        private Button Edit;
        private Label User;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button DeleteGame;
        private DataGridView ChatList;
        private DataGridView GameList;
        private DataGridView UserList;
        private Button Cancel;
        private TextBox Password;
        private Button Send;
        private Button DeleteUser;
        private Button Create;
    }
}