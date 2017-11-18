using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TeacherManager
    {
        Model.User user;

        public TeacherManager(Model.User user)
        {
            this.user = user;
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
