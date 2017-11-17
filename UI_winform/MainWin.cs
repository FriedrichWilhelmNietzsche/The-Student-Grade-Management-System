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
    public partial class MainWin : Form
    {
        BLL.MainManager mainManager = null;
        public MainWin()
        {
            mainManager = new BLL.MainManager();

            InitializeComponent();
        }

        private void MainCloseButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
