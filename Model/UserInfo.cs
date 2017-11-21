using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {
        private int _user_id;
        public int user_id
        {
            get { return _user_id;  }
            set { _user_id = value; }
        }

        private string _real_name;
        public string real_name
        {
            get { return _real_name;  }
            set { _real_name = value; }
        }

        private string _number;
        public string number
        {
            get { return _number;  }
            set { _number = value; }
        }

        private string _sex;
        public string sex
        {
            get { return _sex;  }
            set { _sex = value; }
        }

        private string _telephone;
        public string telephone
        {
            get { return _telephone;  }
            set { _telephone = value; }
        }

        private string _email;
        public string email
        {
            get { return _email;  }
            set { _email = value; }
        }

        private string _explain;
        public string explain
        {
            get { return _explain;  }
            set { _explain = value; }
        }
    }
}
