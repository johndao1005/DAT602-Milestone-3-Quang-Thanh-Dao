namespace DAT602_final.Forms
{
    partial class GameScreen
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
            this.Up = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ChatList = new System.Windows.Forms.DataGridView();
            this.Message = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).BeginInit();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(126, 383);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(94, 29);
            this.Up.TabIndex = 1;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(206, 442);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(94, 29);
            this.Right.TabIndex = 2;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(45, 442);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(94, 29);
            this.Left.TabIndex = 3;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(126, 503);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(94, 29);
            this.Down.TabIndex = 4;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(764, 469);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Quit";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ChatList
            // 
            this.ChatList.AllowUserToAddRows = false;
            this.ChatList.AllowUserToDeleteRows = false;
            this.ChatList.AllowUserToResizeColumns = false;
            this.ChatList.AllowUserToResizeRows = false;
            this.ChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChatList.Location = new System.Drawing.Point(645, 60);
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
            this.ChatList.TabIndex = 47;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(645, 239);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(213, 91);
            this.Message.TabIndex = 46;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(763, 351);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 29);
            this.Send.TabIndex = 45;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sorry the game only work with Down Direction atm. which will display and show on " +
    "Database as well";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChatList);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Up);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            ((System.ComponentModel.ISupportInitialize)(this.ChatList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Up;
        private Button Right;
        private Button Left;
        private Button Down;
        private Button Cancel;
        private DataGridView ChatList;
        private TextBox Message;
        private Button Send;
        private Label label1;
    }
}