using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentManager
    {
        Model.User user;
        public StudentManager(Model.User user)
        {
            this.user = user;
        }

        public string GetUsername()
        {
            return user.user_name;
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
