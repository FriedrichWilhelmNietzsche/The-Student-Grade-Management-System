using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MainManager
    {
        Model.User user;
        public MainManager(Model.User user)
        {
            this.user = user;
        }
        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
