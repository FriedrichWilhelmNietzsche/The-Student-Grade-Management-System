using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int _user_id;
        /// <summary>
        /// 用户ID
        /// </summary>
        public int user_id
        {
            get { return _user_id;  }
            set { _user_id = value; }
        }

        private string _role_type;
        /// <summary>
        /// 角色类别ID
        /// </summary>
        public string role_type
        {
            get { return _role_type;  }
            set { _role_type = value; }
        }

        private string _user_name;
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            get { return _user_name;  }
            set { _user_name = value; }
        }

        private string _user_pass;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string user_pass
        {
            get { return _user_pass;  }
            set { _user_pass = value; }
        }

        private int _is_lock;
        /// <summary>
        /// 用户状态
        /// </summary>
        public int is_lock
        {
            get { return _is_lock;  }
            set { _is_lock = value; }
        }

        private DateTime _add_Time;
        /// <summary>
        /// 用户添加日期
        /// </summary>
        public DateTime add_Time
        {
            get { return _add_Time;  }
            set { _add_Time = value; }
        }
    }
}
