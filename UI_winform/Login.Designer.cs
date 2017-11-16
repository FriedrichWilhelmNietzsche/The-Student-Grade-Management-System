namespace winform_login
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 必需的设计器变量。 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_name = new System.Windows.Forms.Label();
            this.teacherPanel = new System.Windows.Forms.Panel();
            this.teacher_loginButton = new System.Windows.Forms.Button();
            this.teacherClose = new System.Windows.Forms.Button();
            this.teacher_Password = new System.Windows.Forms.TextBox();
            this.teacher_Username = new System.Windows.Forms.TextBox();
            this.teacherTag = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.Label();
            this.teacherLogin = new System.Windows.Forms.PictureBox();
            this.loginCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.loginDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loginDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.studentLogin = new System.Windows.Forms.PictureBox();
            this.studentTag = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.student_Username = new System.Windows.Forms.TextBox();
            this.student_password = new System.Windows.Forms.TextBox();
            this.student_loginButton = new System.Windows.Forms.Button();
            this.studentClose = new System.Windows.Forms.Button();
            this.student_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.student_UserElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.student_buttonElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.student_passElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.teacher_UserElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.teacher_buttonElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.teacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).BeginInit();
            this.studentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_name
            // 
            resources.ApplyResources(this.Login_name, "Login_name");
            this.Login_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.Login_name.Name = "Login_name";
            // 
            // teacherPanel
            // 
            this.teacherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.teacherPanel.Controls.Add(this.teacher_loginButton);
            this.teacherPanel.Controls.Add(this.teacherClose);
            this.teacherPanel.Controls.Add(this.teacher_Password);
            this.teacherPanel.Controls.Add(this.teacher_Username);
            this.teacherPanel.Controls.Add(this.teacherTag);
            this.teacherPanel.Controls.Add(this.teacherName);
            this.teacherPanel.Controls.Add(this.teacherLogin);
            this.teacherPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.teacherPanel, "teacherPanel");
            this.teacherPanel.Name = "teacherPanel";
            this.teacherPanel.Click += new System.EventHandler(this.teacherPanel_Click);
            this.teacherPanel.MouseEnter += new System.EventHandler(this.teacherPanel_MouseEnter);
            this.teacherPanel.MouseLeave += new System.EventHandler(this.teacherPanel_MouseLeave);
            // 
            // teacher_loginButton
            // 
            this.teacher_loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.teacher_loginButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.teacher_loginButton, "teacher_loginButton");
            this.teacher_loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.teacher_loginButton.Name = "teacher_loginButton";
            this.teacher_loginButton.UseVisualStyleBackColor = false;
            this.teacher_loginButton.Click += new System.EventHandler(this.teacher_loginButton_Click);
            // 
            // teacherClose
            // 
            this.teacherClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.teacherClose, "teacherClose");
            this.teacherClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.teacherClose.Name = "teacherClose";
            this.teacherClose.UseVisualStyleBackColor = false;
            this.teacherClose.Click += new System.EventHandler(this.teacherPanel_Click);
            // 
            // teacher_Password
            // 
            resources.ApplyResources(this.teacher_Password, "teacher_Password");
            this.teacher_Password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.teacher_Password.Name = "teacher_Password";
            this.teacher_Password.Enter += new System.EventHandler(this.teacher_Password_Enter);
            this.teacher_Password.Leave += new System.EventHandler(this.teacher_Password_Leave);
            // 
            // teacher_Username
            // 
            resources.ApplyResources(this.teacher_Username, "teacher_Username");
            this.teacher_Username.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.teacher_Username.Name = "teacher_Username";
            this.teacher_Username.Enter += new System.EventHandler(this.teacher_Username_Enter);
            this.teacher_Username.Leave += new System.EventHandler(this.teacher_Username_Leave);
            // 
            // teacherTag
            // 
            resources.ApplyResources(this.teacherTag, "teacherTag");
            this.teacherTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.teacherTag.Name = "teacherTag";
            this.teacherTag.MouseEnter += new System.EventHandler(this.teacherPanel_MouseLeave);
            // 
            // teacherName
            // 
            resources.ApplyResources(this.teacherName, "teacherName");
            this.teacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.teacherName.Name = "teacherName";
            this.teacherName.MouseEnter += new System.EventHandler(this.teacherPanel_MouseEnter);
            // 
            // teacherLogin
            // 
            resources.ApplyResources(this.teacherLogin, "teacherLogin");
            this.teacherLogin.Name = "teacherLogin";
            this.teacherLogin.TabStop = false;
            this.teacherLogin.MouseEnter += new System.EventHandler(this.teacherPanel_MouseEnter);
            // 
            // loginCloseButton
            // 
            this.loginCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.loginCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.loginCloseButton, "loginCloseButton");
            this.loginCloseButton.ImageActive = null;
            this.loginCloseButton.Name = "loginCloseButton";
            this.loginCloseButton.TabStop = false;
            this.loginCloseButton.Zoom = 20;
            this.loginCloseButton.Click += new System.EventHandler(this.LoginCloseButton_Click);
            // 
            // loginDragControl1
            // 
            this.loginDragControl1.Fixed = true;
            this.loginDragControl1.Horizontal = true;
            this.loginDragControl1.TargetControl = this;
            this.loginDragControl1.Vertical = true;
            // 
            // loginDragControl2
            // 
            this.loginDragControl2.Fixed = true;
            this.loginDragControl2.Horizontal = true;
            this.loginDragControl2.TargetControl = this.Login_name;
            this.loginDragControl2.Vertical = true;
            // 
            // studentLogin
            // 
            resources.ApplyResources(this.studentLogin, "studentLogin");
            this.studentLogin.Name = "studentLogin";
            this.studentLogin.TabStop = false;
            this.studentLogin.MouseEnter += new System.EventHandler(this.studentPanel_MouseEnter);
            // 
            // studentTag
            // 
            resources.ApplyResources(this.studentTag, "studentTag");
            this.studentTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.studentTag.Name = "studentTag";
            this.studentTag.MouseEnter += new System.EventHandler(this.studentPanel_MouseEnter);
            // 
            // studentName
            // 
            resources.ApplyResources(this.studentName, "studentName");
            this.studentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.studentName.Name = "studentName";
            this.studentName.MouseEnter += new System.EventHandler(this.studentPanel_MouseEnter);
            // 
            // studentPanel
            // 
            this.studentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.studentPanel.Controls.Add(this.student_Username);
            this.studentPanel.Controls.Add(this.student_password);
            this.studentPanel.Controls.Add(this.student_loginButton);
            this.studentPanel.Controls.Add(this.studentClose);
            this.studentPanel.Controls.Add(this.studentName);
            this.studentPanel.Controls.Add(this.studentTag);
            this.studentPanel.Controls.Add(this.studentLogin);
            this.studentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.studentPanel, "studentPanel");
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Click += new System.EventHandler(this.studentPanel_Click);
            this.studentPanel.MouseEnter += new System.EventHandler(this.studentPanel_MouseEnter);
            this.studentPanel.MouseLeave += new System.EventHandler(this.studentPanel_MouseLeave);
            // 
            // student_Username
            // 
            this.student_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.student_Username, "student_Username");
            this.student_Username.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.student_Username.Name = "student_Username";
            this.student_Username.Enter += new System.EventHandler(this.student_Username_Enter);
            this.student_Username.Leave += new System.EventHandler(this.student_Username_Leave);
            // 
            // student_password
            // 
            this.student_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.student_password, "student_password");
            this.student_password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.student_password.Name = "student_password";
            this.student_password.Enter += new System.EventHandler(this.student_password_Enter);
            this.student_password.Leave += new System.EventHandler(this.student_password_Leave);
            // 
            // student_loginButton
            // 
            this.student_loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.student_loginButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.student_loginButton, "student_loginButton");
            this.student_loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.student_loginButton.Name = "student_loginButton";
            this.student_loginButton.UseVisualStyleBackColor = false;
            this.student_loginButton.Click += new System.EventHandler(this.student_loginButton_Click);
            // 
            // studentClose
            // 
            this.studentClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(216)))), ((int)(((byte)(213)))));
            resources.ApplyResources(this.studentClose, "studentClose");
            this.studentClose.FlatAppearance.BorderSize = 0;
            this.studentClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(148)))));
            this.studentClose.Name = "studentClose";
            this.studentClose.UseVisualStyleBackColor = false;
            this.studentClose.Click += new System.EventHandler(this.studentPanel_Click);
            // 
            // student_Elipse
            // 
            this.student_Elipse.ElipseRadius = 10;
            this.student_Elipse.TargetControl = this;
            // 
            // student_UserElipse
            // 
            this.student_UserElipse.ElipseRadius = 5;
            this.student_UserElipse.TargetControl = this.student_Username;
            // 
            // student_buttonElipse
            // 
            this.student_buttonElipse.ElipseRadius = 5;
            this.student_buttonElipse.TargetControl = this.student_loginButton;
            // 
            // student_passElipse
            // 
            this.student_passElipse.ElipseRadius = 5;
            this.student_passElipse.TargetControl = this.student_password;
            // 
            // teacher_UserElipse
            // 
            this.teacher_UserElipse.ElipseRadius = 5;
            this.teacher_UserElipse.TargetControl = this.teacher_Username;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.teacher_Password;
            // 
            // teacher_buttonElipse
            // 
            this.teacher_buttonElipse.ElipseRadius = 5;
            this.teacher_buttonElipse.TargetControl = this.teacher_loginButton;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.teacherPanel);
            this.Controls.Add(this.loginCloseButton);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.Login_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.teacherPanel.ResumeLayout(false);
            this.teacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLogin)).EndInit();
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Login_name;
        private System.Windows.Forms.Panel teacherPanel;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.PictureBox teacherLogin;
        private System.Windows.Forms.Label teacherTag;
        private Bunifu.Framework.UI.BunifuImageButton loginCloseButton;
        private Bunifu.Framework.UI.BunifuDragControl loginDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl loginDragControl2;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label studentTag;
        private System.Windows.Forms.PictureBox studentLogin;
        private System.Windows.Forms.TextBox teacher_Password;
        private System.Windows.Forms.TextBox teacher_Username;
        private System.Windows.Forms.Button teacherClose;
        private System.Windows.Forms.Button studentClose;
        private Bunifu.Framework.UI.BunifuElipse student_Elipse;
        private System.Windows.Forms.TextBox student_password;
        private System.Windows.Forms.Button student_loginButton;
        private System.Windows.Forms.TextBox student_Username;
        private Bunifu.Framework.UI.BunifuElipse student_UserElipse;
        private Bunifu.Framework.UI.BunifuElipse student_buttonElipse;
        private Bunifu.Framework.UI.BunifuElipse student_passElipse;
        private System.Windows.Forms.Button teacher_loginButton;
        private Bunifu.Framework.UI.BunifuElipse teacher_UserElipse;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse teacher_buttonElipse;
    }
}

