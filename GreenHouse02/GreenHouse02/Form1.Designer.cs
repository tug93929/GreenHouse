namespace GreenHouse02
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Button();
            this.DashBoard_Button = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ProjectName = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashBoard = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Welcome_Message = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Controls.Add(this.button4);
            this.SidePanel.Controls.Add(this.button3);
            this.SidePanel.Controls.Add(this.button2);
            this.SidePanel.Controls.Add(this.Data);
            this.SidePanel.Controls.Add(this.DashBoard_Button);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Location = new System.Drawing.Point(1, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(278, 636);
            this.SidePanel.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(-2, 212);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(278, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Time Lapse";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(-2, 263);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(278, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Control Panel";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 161);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(278, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Settings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Data
            // 
            this.Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Data.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(-2, 107);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Data.Size = new System.Drawing.Size(278, 48);
            this.Data.TabIndex = 2;
            this.Data.Text = "Data Logs";
            this.Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Data.UseVisualStyleBackColor = false;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // DashBoard_Button
            // 
            this.DashBoard_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DashBoard_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DashBoard_Button.FlatAppearance.BorderSize = 0;
            this.DashBoard_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DashBoard_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DashBoard_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DashBoard_Button.Location = new System.Drawing.Point(-1, 56);
            this.DashBoard_Button.Margin = new System.Windows.Forms.Padding(0);
            this.DashBoard_Button.Name = "DashBoard_Button";
            this.DashBoard_Button.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DashBoard_Button.Size = new System.Drawing.Size(278, 48);
            this.DashBoard_Button.TabIndex = 1;
            this.DashBoard_Button.Text = "Dashboard";
            this.DashBoard_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoard_Button.UseMnemonic = false;
            this.DashBoard_Button.UseVisualStyleBackColor = false;
            this.DashBoard_Button.Click += new System.EventHandler(this.DashBoard_Button_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Controls.Add(this.ProjectName);
            this.LogoPanel.Location = new System.Drawing.Point(-1, -1);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(278, 60);
            this.LogoPanel.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, -4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(65, 64);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProjectName
            // 
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(70, 1);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(207, 48);
            this.ProjectName.TabIndex = 2;
            this.ProjectName.Text = "Automated GreenHouse Control System";
            this.ProjectName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.Minimize);
            this.TopPanel.Controls.Add(this.Exit);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.DashBoard);
            this.TopPanel.Location = new System.Drawing.Point(280, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(818, 60);
            this.TopPanel.TabIndex = 1;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(737, 8);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 37);
            this.Minimize.TabIndex = 5;
            this.Minimize.Text = "-";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(778, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 37);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            this.DashBoard.AutoSize = true;
            this.DashBoard.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.Location = new System.Drawing.Point(92, 8);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(153, 37);
            this.DashBoard.TabIndex = 3;
            this.DashBoard.Text = "Dashboard";
            // 
            // Welcome_Message
            // 
            this.Welcome_Message.AutoSize = true;
            this.Welcome_Message.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Message.Location = new System.Drawing.Point(292, 68);
            this.Welcome_Message.Name = "Welcome_Message";
            this.Welcome_Message.Size = new System.Drawing.Size(738, 37);
            this.Welcome_Message.TabIndex = 4;
            this.Welcome_Message.Text = "Welcome to your Automated GreenHouse Control System!";
            // 
            // Home
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1098, 636);
            this.Controls.Add(this.Welcome_Message);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button DashBoard_Button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DashBoard;
        private System.Windows.Forms.Label Welcome_Message;
    }
}

