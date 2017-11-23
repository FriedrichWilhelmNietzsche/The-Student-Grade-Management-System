using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Main
{
    public partial class UserInfo : UserControl
    {
        private BLL.StudentManager studentManager = null;
        public UserInfo(BLL.StudentManager studentManager)
        {
            this.studentManager = studentManager;
            InitializeComponent();
        }

        public void fillText(Model.UserInfo userInfo)
        {
            this.text_Username.Text = userInfo.real_name;
            this.text_Sex.Text = userInfo.sex;
            this.text_number.Text = userInfo.number;
            this.text_tel.Text = userInfo.telephone;
            this.text_email.Text = userInfo.email;
            this.text_explain.Text = userInfo.explain;
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            studentManager.ModifyUserInfo(this.text_email.Text, this.text_tel.Text, this.text_explain.Text);
        }
    }
}
