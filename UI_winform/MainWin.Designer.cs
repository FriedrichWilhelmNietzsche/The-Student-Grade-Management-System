namespace winform_login
{
    partial class MainWin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_title = new System.Windows.Forms.Label();
            this.loginCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.username = new System.Windows.Forms.Label();
            this.studentLogin = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.Main_title);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(258, 600);
            this.Menu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 1);
            this.label1.TabIndex = 1;
            // 
            // Main_title
            // 
            this.Main_title.AutoSize = true;
            this.Main_title.Font = new System.Drawing.Font("隶书", 20F);
            this.Main_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(176)))), ((int)(((byte)(183)))));
            this.Main_title.Location = new System.Drawing.Point(12, 26);
            this.Main_title.Name = "Main_title";
            this.Main_title.Size = new System.Drawing.Size(236, 27);
            this.Main_title.TabIndex = 0;
            this.Main_title.Text = "学生成绩管理系统";
            // 
            // loginCloseButton
            // 
            this.loginCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.loginCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("loginCloseButton.Image")));
            this.loginCloseButton.ImageActive = null;
            this.loginCloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginCloseButton.Location = new System.Drawing.Point(953, 17);
            this.loginCloseButton.Name = "loginCloseButton";
            this.loginCloseButton.Size = new System.Drawing.Size(32, 31);
            this.loginCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginCloseButton.TabIndex = 8;
            this.loginCloseButton.TabStop = false;
            this.loginCloseButton.Zoom = 20;
            this.loginCloseButton.Click += new System.EventHandler(this.MainCloseButton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.username.Location = new System.Drawing.Point(846, 23);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 24);
            this.username.TabIndex = 9;
            this.username.Text = "label2";
            // 
            // studentLogin
            // 
            this.studentLogin.Image = ((System.Drawing.Image)(resources.GetObject("studentLogin.Image")));
            this.studentLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentLogin.Location = new System.Drawing.Point(791, 13);
            this.studentLogin.Name = "studentLogin";
            this.studentLogin.Size = new System.Drawing.Size(43, 40);
            this.studentLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentLogin.TabIndex = 10;
            this.studentLogin.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(264, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(746, 1);
            this.label3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(176)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(937, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // MainWin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentLogin);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginCloseButton);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWin";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label Main_title;
        private Bunifu.Framework.UI.BunifuImageButton loginCloseButton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox studentLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}