using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DAL
{
    public class User_DAL : User_IDAL
    {
        User_DAL()
        {
            myConn = new MySqlConnection("Host=" + DbUtil.host + ";Database=" + DbUtil.Database + ";Username=" + DbUtil.username + ";Password=" + DbUtil.password + ";");
        }


        public user SelectUser(string username, string password,string type)
        {
            const string selectSql = "SELECT * FROM users_list WHERE user_name = @Username AND user_pass = @Password AND role_type = @type";

            MySqlCommand myCom = myConn.CreateCommand();
            myCom.CommandText = selectSql;
            myCom.Parameters.Add("")

            myConn.Open();

            myConn.Close();

            return user;
        }

        /// <summary>
        /// 查询相应角色类型的id
        /// </summary>
        /// <param name="type">角色名称</param>
        /// <returns>
        ///     <value="-1">查无此角色</value>
        /// </returns>
        public int SelectType(string type)
        {
            const string selectRole = "SELECT role_type FROM role_table WHERE role_name = @roleName";

            int flag = -1;

            MySqlCommand myCom = myConn.CreateCommand();
            myCom.CommandText = selectRole;
            myCom.CommandType = System.Data.CommandType.Text;
            myCom.Parameters.Add(new SqlParameter("@roleName", type));

            myConn.Open();

            using (MySqlDataReader reader = myCom.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                while (reader.Read())
                {
                    flag = reader.GetInt32(0);
                }
            }

            return flag;
            
        }

        private MySqlConnection myConn;
    }
}
