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
    public partial class StudentWin : Form
    {
        BLL.StudentManager studentManager = null;
        public StudentWin(Model.User user)
        {
            this.studentManager =new BLL.StudentManager(user);

            InitializeComponent();
        }

        private void MainCloseButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MainWin_Load(object sender, EventArgs e)
        {

        }


        private void bunifuCustomLabel_Enter(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuCustomLabel)sender).ForeColor = System.Drawing.Color.FromArgb(233, 233, 234);
        }

        private void bunifuCustomLabel_Leave(object sender,EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuCustomLabel)sender).ForeColor = System.Drawing.Color.FromArgb(171, 175, 183);
        }

        private void Info_Click(object sender, EventArgs e)
        {
            this.UnderLine.Location = new Point(((Bunifu.Framework.UI.BunifuCustomLabel)sender).Location.X,
                ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Location.Y + 26);
            this.UnderLine.Show();

            foreach(Bunifu.Framework.UI.BunifuCustomLabel label in paras)
            {
                label.ForeColor = System.Drawing.Color.FromArgb(171, 175, 183);
            }
            this.Info.ForeColor = System.Drawing.Color.FromArgb(233, 233, 234);


        }
    }
}
