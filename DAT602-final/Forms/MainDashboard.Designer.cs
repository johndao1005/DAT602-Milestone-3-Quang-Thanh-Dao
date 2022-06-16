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
            this.Create = new System.Windows.Forms.Button();
            this.GameList = new System.Windows.Forms.DataGridView();
            this.ChatList = new System.Windows.Forms.DataGridView();
            this.UserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(795, 419);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Quit";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(677, 251);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(213, 91);
            this.Password.TabIndex = 20;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(795, 363);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 29);
            this.Send.TabIndex = 19;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // Join
            // 
            this.Join.Location = new System.Drawing.Point(374, 363);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(94, 29);
            this.Join.TabIndex = 25;
            this.Join.Text = "Join";
            this.Join.UseVisualStyleBackColor = true;
            this.Join.Click += new System.EventHandler(this.Join_Click);
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
            this.label1.Location = new System.Drawing.Point(375, 32);
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
            this.Invite.Location = new System.Drawing.Point(43, 363);
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
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(546, 363);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 29);
            this.Create.TabIndex = 41;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // GameList
            // 
            this.GameList.AllowUserToAddRows = false;
            this.GameList.AllowUserToDeleteRows = false;
            this.GameList.AllowUserToResizeColumns = false;
            this.GameList.AllowUserToResizeRows = false;
            this.GameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameList.Location = new System.Drawing.Point(375, 72);
            this.GameList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameList.MultiSelect = false;
            this.GameList.Name = "GameList";
            this.GameList.ReadOnly = true;
            this.GameList.RowHeadersVisible = false;
            this.GameList.RowHeadersWidth = 51;
            this.GameList.RowTemplate.Height = 25;
            this.GameList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameList.ShowCellErrors = false;
            this.GameList.ShowCellToolTips = false;
            this.GameList.ShowEditingIcon = false;
            this.GameList.ShowRowErrors = false;
            this.GameList.Size = new System.Drawing.Size(265, 271);
            this.GameList.TabIndex = 43;
            // 
            // ChatList
            // 
            this.ChatList.AllowUserToAddRows = false;
            this.ChatList.AllowUserToDeleteRows = false;
            this.ChatList.AllowUserToResizeColumns = false;
            this.ChatList.AllowUserToResizeRows = false;
            this.ChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChatList.Location = new System.Drawing.Point(677, 72);
            this.ChatList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChatList.MultiSelect = false;
            this.ChatList.Name = "ChatList";
            this.ChatList.ReadOnly = true;
            this.ChatList.RowHeadersVisible = false;
            this.ChatList.RowHeadersWidth = 51;
            this.ChatList.RowTemplate.Height = 25;
            this.ChatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChatList.ShowCellErrors = false;
            this.ChatList.ShowCellToolTips = false;
            this.ChatList.ShowEditingIcon = false;
            this.ChatList.ShowRowErrors = false;
            this.ChatList.Size = new System.Drawing.Size(213, 151);
            this.ChatList.TabIndex = 44;
            // 
            // UserList
            // 
            this.UserList.AllowUserToAddRows = false;
            this.UserList.AllowUserToDeleteRows = false;
            this.UserList.AllowUserToResizeColumns = false;
            this.UserList.AllowUserToResizeRows = false;
            this.UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList.Location = new System.Drawing.Point(43, 72);
            this.UserList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserList.MultiSelect = false;
            this.UserList.Name = "UserList";
            this.UserList.ReadOnly = true;
            this.UserList.RowHeadersVisible = false;
            this.UserList.RowHeadersWidth = 51;
            this.UserList.RowTemplate.Height = 25;
            this.UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserList.ShowCellErrors = false;
            this.UserList.ShowCellToolTips = false;
            this.UserList.ShowEditingIcon = false;
            this.UserList.ShowRowErrors = false;
            this.UserList.Size = new System.Drawing.Size(265, 271);
            this.UserList.TabIndex = 45;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 476);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.ChatList);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.Create);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).EndInit();
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
        private Button Create;
        private DataGridView GameList;
        private DataGridView dataGridView2;
        private DataGridView ChatList;
        private DataGridView UserList;
    }
}