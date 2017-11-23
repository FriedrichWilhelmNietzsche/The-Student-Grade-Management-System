using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentManager
    {
        private Model.User user;
        private IDAL.User_IDAL user_IDAL = null;

        public StudentManager(Model.User user)
        {
            this.user = user;
            this.user_IDAL = new Mysql_DAL.User_DAL();
        }
        public void ModifyUserInfo(string email,string tel,string explain)
        {
            user_IDAL.ModifyUserInfo(user.user_id,email, tel, explain);
        }
        public Model.UserInfo SelectUserInfo()
        {
            return user_IDAL.SelectUserInfo(user.user_id);
        }

        public Model.User GetUser()
        {
            return user;
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
