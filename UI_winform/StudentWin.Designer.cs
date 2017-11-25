namespace Student_Main
{
    partial class StudentWin
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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentWin));
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
            this.loginCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.username = new System.Windows.Forms.Label();
            this.studentLogin = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.userInfo1 = new Student_Main.UserInfo(studentManager);
            this.transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.userCourse1 = new Student_Main.userCourse();
            this.userGrade1 = new Student_Main.UserGrade();
            this.mainControl1 = new Control_UI.MainControl();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).BeginInit();
            this.dragPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.transition1.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(258, 600);
            this.Menu.TabIndex = 0;
            // 
            // UnderLine
            // 
            this.UnderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.transition1.SetDecoration(this.UnderLine, BunifuAnimatorNS.DecorationType.None);
            this.UnderLine.Location = new System.Drawing.Point(0, 0);
            this.UnderLine.Name = "UnderLine";
            this.UnderLine.Size = new System.Drawing.Size(81, 1);
            this.UnderLine.TabIndex = 6;
            this.UnderLine.Visible = false;
            // 
            // MenuTitle1
            // 
            this.MenuTitle1.AutoSize = true;
            this.transition1.SetDecoration(this.MenuTitle1, BunifuAnimatorNS.DecorationType.None);
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
            this.transition1.SetDecoration(this.MenuTitle3, BunifuAnimatorNS.DecorationType.None);
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
            this.transition1.SetDecoration(this.course, BunifuAnimatorNS.DecorationType.None);
            this.course.Font = new System.Drawing.Font("华文楷体", 13F);
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            this.course.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.course.Location = new System.Drawing.Point(113, 200);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(81, 20);
            this.course.TabIndex = 2;
            this.course.Text = "课程查询";
            this.course.Click += new System.EventHandler(this.course_Click);
            this.course.MouseEnter += new System.EventHandler(this.BunifuCustomLabel_Enter);
            this.course.MouseLeave += new System.EventHandler(this.BunifuCustomLabel_Leave);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.Grade, BunifuAnimatorNS.DecorationType.None);
            this.Grade.Font = new System.Drawing.Font("华文楷体", 13F);
            this.Grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            this.Grade.Location = new System.Drawing.Point(113, 244);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(81, 20);
            this.Grade.TabIndex = 2;
            this.Grade.Text = "成绩查询";
            this.Grade.Click += new System.EventHandler(this.Grade_Click);
            this.Grade.MouseEnter += new System.EventHandler(this.BunifuCustomLabel_Enter);
            this.Grade.MouseLeave += new System.EventHandler(this.BunifuCustomLabel_Leave);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.Info, BunifuAnimatorNS.DecorationType.None);
            this.Info.Font = new System.Drawing.Font("华文楷体", 13F);
            this.Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(183)))));
            this.Info.Location = new System.Drawing.Point(113, 359);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(81, 20);
            this.Info.TabIndex = 2;
            this.Info.Text = "个人信息";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            this.Info.Enter += new System.EventHandler(this.BunifuCustomLabel_Enter);
            this.Info.MouseEnter += new System.EventHandler(this.BunifuCustomLabel_Enter);
            this.Info.MouseLeave += new System.EventHandler(this.BunifuCustomLabel_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.transition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 1);
            this.label1.TabIndex = 1;
            // 
            // Main_title
            // 
            this.Main_title.AutoSize = true;
            this.transition1.SetDecoration(this.Main_title, BunifuAnimatorNS.DecorationType.None);
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
            this.transition1.SetDecoration(this.loginCloseButton, BunifuAnimatorNS.DecorationType.None);
            this.loginCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("loginCloseButton.Image")));
            this.loginCloseButton.ImageActive = null;
            this.loginCloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginCloseButton.Location = new System.Drawing.Point(692, 23);
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
            this.transition1.SetDecoration(this.username, BunifuAnimatorNS.DecorationType.None);
            this.username.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.username.Location = new System.Drawing.Point(607, 28);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(46, 24);
            this.username.TabIndex = 9;
            this.username.Text = "user";
            // 
            // studentLogin
            // 
            this.transition1.SetDecoration(this.studentLogin, BunifuAnimatorNS.DecorationType.None);
            this.studentLogin.Image = ((System.Drawing.Image)(resources.GetObject("studentLogin.Image")));
            this.studentLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentLogin.Location = new System.Drawing.Point(552, 20);
            this.studentLogin.Name = "studentLogin";
            this.studentLogin.Size = new System.Drawing.Size(43, 40);
            this.studentLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentLogin.TabIndex = 10;
            this.studentLogin.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.transition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(266, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(725, 1);
            this.label3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(176)))), ((int)(((byte)(183)))));
            this.transition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(675, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // dragPanel
            // 
            this.dragPanel.Controls.Add(this.studentLogin);
            this.dragPanel.Controls.Add(this.label2);
            this.dragPanel.Controls.Add(this.loginCloseButton);
            this.dragPanel.Controls.Add(this.username);
            this.transition1.SetDecoration(this.dragPanel, BunifuAnimatorNS.DecorationType.None);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(258, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(742, 70);
            this.dragPanel.TabIndex = 14;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.dragPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainControl1);
            this.panel1.Controls.Add(this.userGrade1);
            this.panel1.Controls.Add(this.userCourse1);
            this.panel1.Controls.Add(this.userInfo1);
            this.transition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(268, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 504);
            this.panel1.TabIndex = 15;
            // 
            // userInfo1
            // 
            this.transition1.SetDecoration(this.userInfo1, BunifuAnimatorNS.DecorationType.None);
            this.userInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.userInfo1.Location = new System.Drawing.Point(0, 0);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(720, 504);
            this.userInfo1.TabIndex = 0;
            // 
            // transition1
            // 
            this.transition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.transition1.DefaultAnimation = animation5;
            // 
            // userCourse1
            // 
            this.transition1.SetDecoration(this.userCourse1, BunifuAnimatorNS.DecorationType.None);
            this.userCourse1.Location = new System.Drawing.Point(0, 0);
            this.userCourse1.Name = "userCourse1";
            this.userCourse1.Size = new System.Drawing.Size(720, 504);
            this.userCourse1.TabIndex = 1;
            // 
            // userGrade1
            // 
            this.transition1.SetDecoration(this.userGrade1, BunifuAnimatorNS.DecorationType.None);
            this.userGrade1.Location = new System.Drawing.Point(0, 0);
            this.userGrade1.Name = "userGrade1";
            this.userGrade1.Size = new System.Drawing.Size(720, 504);
            this.userGrade1.TabIndex = 2;
            // 
            // mainControl1
            // 
            this.transition1.SetDecoration(this.mainControl1, BunifuAnimatorNS.DecorationType.None);
            this.mainControl1.Location = new System.Drawing.Point(0, 0);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(720, 504);
            this.mainControl1.TabIndex = 3;
            // 
            // StudentWin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Menu);
            this.transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentWin";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).EndInit();
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label MenuTitle3;
        private Bunifu.Framework.UI.BunifuCustomLabel Info;
        private System.Windows.Forms.Label MenuTitle1;
        private Bunifu.Framework.UI.BunifuCustomLabel Grade;
        private Bunifu.Framework.UI.BunifuCustomLabel course;
        private System.Windows.Forms.Label UnderLine;
        private System.Windows.Forms.Panel dragPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition transition1;
        private UserInfo userInfo1;
        private Student_Main.userCourse userCourse1;
        private Student_Main.UserGrade userGrade1;
        private Control_UI.MainControl mainControl1;
    }
}