namespace software_0
{
    partial class Form1
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
            this.ChatBox_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChatboxBorder = new System.Windows.Forms.Panel();
            this.btnSend_chat = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.rtbChatHistory = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Memebrship_icon = new System.Windows.Forms.PictureBox();
            this.Event_icon = new System.Windows.Forms.PictureBox();
            this.Chat_icon = new System.Windows.Forms.PictureBox();
            this.Home_icon = new System.Windows.Forms.PictureBox();
            this.Profile_icon = new System.Windows.Forms.PictureBox();
            this.Membership = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Button();
            this.ChatBox_Button = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.ChatboxBorder.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Memebrship_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Event_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatBox_Label
            // 
            this.ChatBox_Label.AutoSize = true;
            this.ChatBox_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatBox_Label.ForeColor = System.Drawing.Color.White;
            this.ChatBox_Label.Location = new System.Drawing.Point(27, 52);
            this.ChatBox_Label.Name = "ChatBox_Label";
            this.ChatBox_Label.Size = new System.Drawing.Size(210, 54);
            this.ChatBox_Label.TabIndex = 0;
            this.ChatBox_Label.Text = "ChatBox";
            this.ChatBox_Label.Click += new System.EventHandler(this.ChatBox_Label_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.ChatboxBorder);
            this.panel3.Controls.Add(this.ChatBox_Label);
            this.panel3.Location = new System.Drawing.Point(201, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 1089);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ChatboxBorder
            // 
            this.ChatboxBorder.BackColor = System.Drawing.Color.Gray;
            this.ChatboxBorder.Controls.Add(this.btnSend_chat);
            this.ChatboxBorder.Controls.Add(this.txtUserInput);
            this.ChatboxBorder.Controls.Add(this.rtbChatHistory);
            this.ChatboxBorder.Controls.Add(this.vScrollBar1);
            this.ChatboxBorder.Location = new System.Drawing.Point(36, 109);
            this.ChatboxBorder.Name = "ChatboxBorder";
            this.ChatboxBorder.Size = new System.Drawing.Size(1056, 610);
            this.ChatboxBorder.TabIndex = 2;
            this.ChatboxBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.ChatboxBorder_Paint);
            // 
            // btnSend_chat
            // 
            this.btnSend_chat.Location = new System.Drawing.Point(924, 556);
            this.btnSend_chat.Name = "btnSend_chat";
            this.btnSend_chat.Size = new System.Drawing.Size(68, 23);
            this.btnSend_chat.TabIndex = 6;
            this.btnSend_chat.Text = "button7";
            this.btnSend_chat.UseVisualStyleBackColor = true;
            this.btnSend_chat.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(38, 556);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(880, 22);
            this.txtUserInput.TabIndex = 5;
            this.txtUserInput.TextChanged += new System.EventHandler(this.txtUserInput_TextChanged);
            // 
            // rtbChatHistory
            // 
            this.rtbChatHistory.Location = new System.Drawing.Point(16, 13);
            this.rtbChatHistory.Name = "rtbChatHistory";
            this.rtbChatHistory.Size = new System.Drawing.Size(991, 581);
            this.rtbChatHistory.TabIndex = 4;
            this.rtbChatHistory.Text = "";
            this.rtbChatHistory.TextChanged += new System.EventHandler(this.rtbChatHistory_TextChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1021, 13);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 581);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.Memebrship_icon);
            this.panel2.Controls.Add(this.Event_icon);
            this.panel2.Controls.Add(this.Chat_icon);
            this.panel2.Controls.Add(this.Home_icon);
            this.panel2.Controls.Add(this.Profile_icon);
            this.panel2.Controls.Add(this.Membership);
            this.panel2.Controls.Add(this.Event);
            this.panel2.Controls.Add(this.ChatBox_Button);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Controls.Add(this.Profile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 742);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Memebrship_icon
            // 
            this.Memebrship_icon.Location = new System.Drawing.Point(20, 289);
            this.Memebrship_icon.Name = "Memebrship_icon";
            this.Memebrship_icon.Size = new System.Drawing.Size(44, 34);
            this.Memebrship_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Memebrship_icon.TabIndex = 22;
            this.Memebrship_icon.TabStop = false;
            this.Memebrship_icon.Click += new System.EventHandler(this.Memebrship_icon_Click);
            // 
            // Event_icon
            // 
            this.Event_icon.Location = new System.Drawing.Point(20, 244);
            this.Event_icon.Name = "Event_icon";
            this.Event_icon.Size = new System.Drawing.Size(44, 34);
            this.Event_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Event_icon.TabIndex = 21;
            this.Event_icon.TabStop = false;
            this.Event_icon.Click += new System.EventHandler(this.Event_icon_Click);
            // 
            // Chat_icon
            // 
            this.Chat_icon.Location = new System.Drawing.Point(20, 202);
            this.Chat_icon.Name = "Chat_icon";
            this.Chat_icon.Size = new System.Drawing.Size(44, 34);
            this.Chat_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chat_icon.TabIndex = 20;
            this.Chat_icon.TabStop = false;
            this.Chat_icon.Click += new System.EventHandler(this.Chat_icon_Click);
            // 
            // Home_icon
            // 
            this.Home_icon.Location = new System.Drawing.Point(20, 109);
            this.Home_icon.Name = "Home_icon";
            this.Home_icon.Size = new System.Drawing.Size(44, 34);
            this.Home_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_icon.TabIndex = 19;
            this.Home_icon.TabStop = false;
            this.Home_icon.Click += new System.EventHandler(this.Home_icon_Click);
            // 
            // Profile_icon
            // 
            this.Profile_icon.Location = new System.Drawing.Point(20, 157);
            this.Profile_icon.Name = "Profile_icon";
            this.Profile_icon.Size = new System.Drawing.Size(44, 34);
            this.Profile_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile_icon.TabIndex = 18;
            this.Profile_icon.TabStop = false;
            this.Profile_icon.Click += new System.EventHandler(this.Profile_icon_Click);
            // 
            // Membership
            // 
            this.Membership.Location = new System.Drawing.Point(70, 289);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(105, 32);
            this.Membership.TabIndex = 17;
            this.Membership.Text = "Membership";
            this.Membership.UseVisualStyleBackColor = true;
            this.Membership.Click += new System.EventHandler(this.Membership_Click);
            // 
            // Event
            // 
            this.Event.Location = new System.Drawing.Point(70, 244);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(105, 35);
            this.Event.TabIndex = 16;
            this.Event.Text = "Event";
            this.Event.UseVisualStyleBackColor = true;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // ChatBox_Button
            // 
            this.ChatBox_Button.Location = new System.Drawing.Point(70, 204);
            this.ChatBox_Button.Name = "ChatBox_Button";
            this.ChatBox_Button.Size = new System.Drawing.Size(105, 32);
            this.ChatBox_Button.TabIndex = 15;
            this.ChatBox_Button.Text = "ChatBox";
            this.ChatBox_Button.UseVisualStyleBackColor = true;
            this.ChatBox_Button.Click += new System.EventHandler(this.ChatBox_Button_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(70, 109);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(105, 34);
            this.Home.TabIndex = 14;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(70, 157);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(105, 34);
            this.Profile.TabIndex = 13;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 742);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 742);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ChatboxBorder.ResumeLayout(false);
            this.ChatboxBorder.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Memebrship_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Event_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChatBox_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ChatboxBorder;
        private System.Windows.Forms.Button btnSend_chat;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.RichTextBox rtbChatHistory;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Memebrship_icon;
        private System.Windows.Forms.PictureBox Event_icon;
        private System.Windows.Forms.PictureBox Chat_icon;
        private System.Windows.Forms.PictureBox Home_icon;
        private System.Windows.Forms.PictureBox Profile_icon;
        private System.Windows.Forms.Button Membership;
        private System.Windows.Forms.Button Event;
        private System.Windows.Forms.Button ChatBox_Button;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Panel panel1;
    }
}

