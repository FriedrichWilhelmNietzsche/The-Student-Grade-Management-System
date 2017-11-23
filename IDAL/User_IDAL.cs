using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface User_IDAL
    {
        /// <summary>
        /// 根据账号密码，获取用户
        /// </summary>
        /// <param name="username">账号</param>
        /// <param name="password">密码</param>
        /// <returns>NULL表示不存在该用户</returns>
        Model.User SelectUser(string username, string password,int type);
        void ModifyUserInfo(int user_id,string email, string tel, string explain);

        /// <summary>
        /// 根据用户id，检索用户详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Model.UserInfo SelectUserInfo(int id);
        /// <summary>
        /// 根据用户类型名称，获取用户类型ID
        /// </summary>
        /// <param name="type">用户类型名称</param>
        /// <returns>
        ///     <value="-1">不存在该类型</value>
        /// </returns>
        int SelectType(string type);

    }
}
