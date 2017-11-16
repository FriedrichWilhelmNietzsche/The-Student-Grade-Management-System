using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginManager
    {
        public LoginManager()
        {
            user_IDAL = new Mysql_DAL.User_DAL();
        }

        public void UserLogin(string username,string password,string type)
        {
            user = user_IDAL.SelectUser(username, password, type);
            if (user == null)
                throw new Exception("Wrong Username or Password");
            else
                Console.Write("successed");
        }

        Model.User user = null;
        IDAL.User_IDAL user_IDAL = null;

        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
