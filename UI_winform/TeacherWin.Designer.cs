namespace WIN_成绩管理系统
{
    partial class TeacherWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherWin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Menu = new System.Windows.Forms.Panel();
            this.UnderLine = new System.Windows.Forms.Label();
            this.MenuTitle1 = new System.Windows.Forms.Label();
            this.MenuTitle3 = new System.Windows.Forms.Label();
            this.course = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Grade = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Info = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_title = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.studentLogin = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).BeginInit();
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
            this.Menu.Controls.Add(this.UnderLine);
            this.Menu.Controls.Add(this.MenuTitle1);
            this.Menu.Controls.Add(this.MenuTitle3);
            this.Menu.Controls.Add(this.course);
            this.Menu.Controls.Add(this.Grade);
            this.Menu.Controls.Add(this.Info);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.Main_title);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(258, 600);
            this.Menu.TabIndex = 1;
            // 
            // UnderLine
            // 
            this.UnderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.UnderLine.Location = new System.Drawing.Point(114, 385);
            this.UnderLine.Name = "UnderLine";
            this.UnderLine.Size = new System.Drawing.Size(81, 1);
            this.UnderLine.TabIndex = 6;
            this.UnderLine.Visible = false;
            // 
            // MenuTitle1
            // 
            this.MenuTitle1.AutoSize = true;
            this.MenuTitle1.Font = new System.Drawing.Font("楷体", 15F);
            this.MenuTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.MenuTitle1.Location = new System.Drawing.Point(31, 148);
            this.MenuTitle1.Name = "MenuTitle1";
            this.MenuTitle1.Size = new System.Drawing.Size(109, 20);
            this.MenuTitle1.TabIndex = 5;
            this.MenuTitle1.Text = "课程管理：";
            // 
            // MenuTitle3
            // 
            this.MenuTitle3.AutoSize = true;
            this.MenuTitle3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.MenuTitle3.Location = new System.Drawing.Point(31, 309);
            this.MenuTitle3.Name = "MenuTitle3";
            this.MenuTitle3.Size = new System.Drawing.Size(109, 20);
            this.MenuTitle3.TabIndex = 3;
            this.MenuTitle3.Text = "个人管理：";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.course.Font = new System.Drawing.Font("华文楷体", 13F);
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            this.course.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.course.Location = new System.Drawing.Point(113, 200);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(81, 20);
            this.course.TabIndex = 2;
            this.course.Text = "课程查询";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grade.Font = new System.Drawing.Font("华文楷体", 13F);
            this.Grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            this.Grade.Location = new System.Drawing.Point(113, 244);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(81, 20);
            this.Grade.TabIndex = 2;
            this.Grade.Text = "成绩查询";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Font = new System.Drawing.Font("华文楷体", 13F);
            this.Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            this.Info.Location = new System.Drawing.Point(113, 359);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(81, 20);
            this.Info.TabIndex = 2;
            this.Info.Text = "个人信息";
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
            // dragPanel
            // 
            this.dragPanel.Controls.Add(this.studentLogin);
            this.dragPanel.Controls.Add(this.label2);
            this.dragPanel.Controls.Add(this.loginCloseButton);
            this.dragPanel.Controls.Add(this.username);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(258, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(742, 70);
            this.dragPanel.TabIndex = 15;
            // 
            // studentLogin
            // 
            this.studentLogin.Image = ((System.Drawing.Image)(resources.GetObject("studentLogin.Image")));
            this.studentLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentLogin.Location = new System.Drawing.Point(530, 25);
            this.studentLogin.Name = "studentLogin";
            this.studentLogin.Size = new System.Drawing.Size(43, 40);
            this.studentLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentLogin.TabIndex = 10;
            this.studentLogin.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(176)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(676, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // loginCloseButton
            // 
            this.loginCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.loginCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("loginCloseButton.Image")));
            this.loginCloseButton.ImageActive = null;
            this.loginCloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginCloseButton.Location = new System.Drawing.Point(692, 29);
            this.loginCloseButton.Name = "loginCloseButton";
            this.loginCloseButton.Size = new System.Drawing.Size(32, 31);
            this.loginCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginCloseButton.TabIndex = 8;
            this.loginCloseButton.TabStop = false;
            this.loginCloseButton.Zoom = 20;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.username.Location = new System.Drawing.Point(585, 35);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 24);
            this.username.TabIndex = 9;
            this.username.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(266, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(725, 1);
            this.label3.TabIndex = 16;
            // 
            // TeacherWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherWin";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label UnderLine;
        private System.Windows.Forms.Label MenuTitle1;
        private System.Windows.Forms.Label MenuTitle3;
        private Bunifu.Framework.UI.BunifuCustomLabel course;
        private Bunifu.Framework.UI.BunifuCustomLabel Grade;
        private Bunifu.Framework.UI.BunifuCustomLabel Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Main_title;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.PictureBox studentLogin;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton loginCloseButton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label3;
    }
}