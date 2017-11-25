using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Main
{
    public partial class TeacherWin : Form
    {
        BLL.TeacherManager teacherManager;

        public TeacherWin(Model.User user)
        {
            teacherManager = new BLL.TeacherManager(user);

            InitializeComponent();
        }
    }
}
