using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginManager
    {
        private Model.User user = null;
        private IDAL.User_IDAL user_IDAL = null;
        public LoginManager()
        {
            user_IDAL = new Mysql_DAL.User_DAL();
        }

        public Model.User UserLogin(string username,string password,string type)
        {
            user = user_IDAL.SelectUser(username, password, user_IDAL.SelectType(type));
            if (user == null)
                throw new Exception("Wrong Username or Password");
            else {
                return user;
            }
                
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
