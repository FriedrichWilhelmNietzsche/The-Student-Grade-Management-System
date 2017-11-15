using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface User_IDAL
    {
        Model.user SelectUser(string username, string password);

    }
}
