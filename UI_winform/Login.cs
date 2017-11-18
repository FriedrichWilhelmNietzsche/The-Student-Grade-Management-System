using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_login
{ 
    public partial class Login : Form
    {
        BLL.LoginManager loginManager = null;

        public Login()
        {
            InitializeComponent();

            loginManager =new BLL.LoginManager();
        }

        /// <summary>
        /// 取消登录，退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginCloseButton_Click(object sender, EventArgs e)
        {
            loginManager.Exit(); //  form exit
        }

        #region 鼠标悬停事件，样式相应
        private void studentPanel_MouseEnter(object sender, EventArgs e)
        {
            this.studentPanel.BackColor = System.Drawing.Color.FromArgb(220, 216, 213);
        }

        private void studentPanel_MouseLeave(object sender, EventArgs e)
        {
            this.studentPanel.BackColor = System.Drawing.Color.FromArgb(233, 233, 234);
        }

        private void teacherPanel_MouseEnter(object sender, EventArgs e)
        {
            this.teacherPanel.BackColor = System.Drawing.Color.FromArgb(62, 75, 96);
        }

        private void teacherPanel_MouseLeave(object sender, EventArgs e)
        {
            this.teacherPanel.BackColor = System.Drawing.Color.FromArgb(76, 87, 105);
        }
        #endregion


        // animate two windows between student and teacher.
        private void studentPanel_Click(object sender, EventArgs e)
        {
            /* student Panel chose Transition 
                1. remove MouseLeave even
                2. change height 
                3. slide down teacher panel (the Y of Location was 376 before changed )
             */
            this.teacherClose.Visible = true;
            this.studentClose.Visible = false;

            this.studentPanel.MouseLeave -= this.studentPanel_MouseLeave;

            this.teacherPanel.Location = new Point(0, 626);
            this.studentPanel.Height = 558;

            this.student_Username.Focus();
            Password_Focus(this.student_password,"    Password",false);
        }

        private void teacherPanel_Click(object sender, EventArgs e)
        {
            /*
             * show teacher Login
             * 1. switch the close button 
             * 2. slide up the other Panel
             * 3. show the Panel
             */

            this.studentClose.Visible = true;
            this.teacherClose.Visible = false;

            this.teacherPanel.MouseLeave -= this.teacherPanel_MouseLeave;

            this.teacherPanel.Location = new Point(0, 128);        //0, 376     
            this.teacherPanel.Height = 558;  // the Height of Size was 558 before change

            this.teacher_Username.Focus();
            Password_Focus(this.teacher_Password, "    Password", false);

        }

        #region  实现输入框样式转变

        private void student_password_Enter(object sender, EventArgs e)
        {
            Password_Focus(this.student_password, "    Password", true);
        }

        private void student_password_Leave(object sender, EventArgs e)
        {
            Password_Focus(this.student_password, "    Password", false);
        }

        private void student_Username_Enter(object sender, EventArgs e)
        {
            Username_Focus(this.student_Username, "    Username", true);
        }

        private void student_Username_Leave(object sender, EventArgs e)
        {
            Username_Focus(this.student_Username, "    Username", false);
        }

        private void teacher_Password_Enter(object sender, EventArgs e)
        {
            this.Password_Focus(this.teacher_Password, "    Password", true);
        }

        private void teacher_Password_Leave(object sender, EventArgs e)
        {
            this.Password_Focus(this.teacher_Password, "    Password", false);
        }

        private void teacher_Username_Enter(object sender, EventArgs e)
        {
            this.Username_Focus(this.teacher_Username, "    Username", true); 
        }
        private void teacher_Username_Leave(object sender, EventArgs e)
        {
            this.Username_Focus(this.teacher_Username, "    Username", false);
        }

        private void Username_Focus(TextBox control, string defaultString,bool flag)
        {
            if (flag == true)
            {
                if (string.Equals(control.Text, defaultString))
                {
                    control.Text = "";
                }
            }
            else
            {
                if (string.Equals(control.Text, ""))
                {
                    control.Text = defaultString;
                }
            }
        }
        private void Password_Focus(TextBox control, string defaultString,bool flag)
        {
            if (flag == true)
            {
                if (string.Equals(control.Text, "    Password"))
                {
                    control.Text = "";
                    control.PasswordChar = '*';
                }
            }
            else
            {
                if (string.Equals(control.Text, ""))
                {
                    control.PasswordChar = new char();
                    control.Text = "    Password";
                }
            }
        }

        #endregion


        #region 登录事件

        private void LoginButton(string username,string password,string type)
        {

            if (password.Equals("Password") 
                    || password.Equals("")
                    || username.Equals("Username") 
                    || username.Equals("")
                    )
                MessageBox.Show("请输出正确的账号密码!");
            else
            {
                try
                {
                    Model.User user = loginManager.UserLogin(username, password, "student");

                    switch (type)
                    {
                        case "student":
                            StudentWin studentWin = new StudentWin(user);
                            studentWin.Show();
                            this.Hide();
                            break;

                        case "teacher":
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void student_loginButton_Click(object sender, EventArgs e)
        {
            LoginButton(this.student_Username.Text.Trim(), this.student_password.Text.Trim(), "student");
        }

        private void teacher_loginButton_Click(object sender, EventArgs e)
        {
            LoginButton(this.teacher_Username.Text.Trim(), this.teacher_Password.Text.Trim(), "teacher");
        }

        #endregion
    }

}

