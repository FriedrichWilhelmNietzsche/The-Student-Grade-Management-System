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
        public UserInfo()
        {
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

    }
}
