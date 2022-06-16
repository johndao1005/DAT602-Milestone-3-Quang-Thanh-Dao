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
            this.Cancel = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.DataGridView();
            this.ChatList = new System.Windows.Forms.DataGridView();
            this.GameList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).BeginInit();
            this.SuspendLayout();
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(682, 27);
            this.Detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(82, 22);
            this.Detail.TabIndex = 44;
            this.Detail.Text = "User Detail";
            this.Detail.UseVisualStyleBackColor = true;
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(27, 269);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(82, 22);
            this.Edit.TabIndex = 43;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(617, 30);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(30, 15);
            this.User.TabIndex = 42;
            this.User.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Active Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Active Users";
            // 
            // DeleteGame
            // 
            this.DeleteGame.Location = new System.Drawing.Point(317, 269);
            this.DeleteGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteGame.Name = "DeleteGame";
            this.DeleteGame.Size = new System.Drawing.Size(82, 22);
            this.DeleteGame.TabIndex = 38;
            this.DeleteGame.Text = "Delete";
            this.DeleteGame.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(686, 320);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(82, 22);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Quit";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(582, 194);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(187, 69);
            this.Password.TabIndex = 33;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(686, 269);
            this.Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(82, 22);
            this.Send.TabIndex = 32;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(190, 269);
            this.DeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(82, 22);
            this.DeleteUser.TabIndex = 45;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(190, 27);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(82, 22);
            this.Create.TabIndex = 46;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // UserList
            // 
            this.UserList.AllowUserToAddRows = false;
            this.UserList.AllowUserToDeleteRows = false;
            this.UserList.AllowUserToResizeColumns = false;
            this.UserList.AllowUserToResizeRows = false;
            this.UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList.Location = new System.Drawing.Point(27, 54);
            this.UserList.MultiSelect = false;
            this.UserList.Name = "UserList";
            this.UserList.ReadOnly = true;
            this.UserList.RowHeadersVisible = false;
            this.UserList.RowTemplate.Height = 25;
            this.UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserList.ShowCellErrors = false;
            this.UserList.ShowCellToolTips = false;
            this.UserList.ShowEditingIcon = false;
            this.UserList.ShowRowErrors = false;
            this.UserList.Size = new System.Drawing.Size(245, 203);
            this.UserList.TabIndex = 49;
            this.UserList.DoubleClick += new System.EventHandler(this.UserList_DoubleClick);
            // 
            // ChatList
            // 
            this.ChatList.AllowUserToAddRows = false;
            this.ChatList.AllowUserToDeleteRows = false;
            this.ChatList.AllowUserToResizeColumns = false;
            this.ChatList.AllowUserToResizeRows = false;
            this.ChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChatList.Location = new System.Drawing.Point(581, 54);
            this.ChatList.MultiSelect = false;
            this.ChatList.Name = "ChatList";
            this.ChatList.ReadOnly = true;
            this.ChatList.RowHeadersVisible = false;
            this.ChatList.RowTemplate.Height = 25;
            this.ChatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChatList.ShowCellErrors = false;
            this.ChatList.ShowCellToolTips = false;
            this.ChatList.ShowEditingIcon = false;
            this.ChatList.ShowRowErrors = false;
            this.ChatList.Size = new System.Drawing.Size(186, 113);
            this.ChatList.TabIndex = 48;
            // 
            // GameList
            // 
            this.GameList.AllowUserToAddRows = false;
            this.GameList.AllowUserToDeleteRows = false;
            this.GameList.AllowUserToResizeColumns = false;
            this.GameList.AllowUserToResizeRows = false;
            this.GameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameList.Location = new System.Drawing.Point(317, 54);
            this.GameList.MultiSelect = false;
            this.GameList.Name = "GameList";
            this.GameList.ReadOnly = true;
            this.GameList.RowHeadersVisible = false;
            this.GameList.RowTemplate.Height = 25;
            this.GameList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameList.ShowCellErrors = false;
            this.GameList.ShowCellToolTips = false;
            this.GameList.ShowEditingIcon = false;
            this.GameList.ShowRowErrors = false;
            this.GameList.Size = new System.Drawing.Size(232, 203);
            this.GameList.TabIndex = 47;
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 369);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.ChatList);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteGame);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Send);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashBoard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).EndInit();
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
        private Button Cancel;
        private TextBox Password;
        private Button Send;
        private Button DeleteUser;
        private Button Create;
        private DataGridView UserList;
        private DataGridView ChatList;
        private DataGridView GameList;
    }
}