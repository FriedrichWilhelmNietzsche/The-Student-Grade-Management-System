using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Mysql_DAL
{
    public class User_DAL : User_IDAL
    {
        public User_DAL()
        {
            myConn = new MySqlConnection("Host=" + DbUtil.host + ";Database=" + DbUtil.Database + ";Username=" + DbUtil.username + ";Password=" + DbUtil.password + ";");
        }

        /// <summary>
        /// 通过用户名，密码和用户类型，返回用户实例
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="type"></param>
        /// <returns>
        ///     <value="null">不存在该用户</value>
        /// </returns>
        public User SelectUser(string username, string password,string type)
        {
            const string selectSql = "SELECT * FROM users_list WHERE user_name = @username AND user_pass = @password AND role_type = @type";
            User user = null;

            MySqlCommand myCom = myConn.CreateCommand();
            myCom.CommandText = selectSql;
            myCom.CommandType = System.Data.CommandType.Text;

            MySqlParameter[] paras = new[]
            {
                new MySqlParameter("@username",MySqlDbType.VarChar,10){Value = username},
                new MySqlParameter("@password",MySqlDbType.VarChar,15){Value = password},
                new MySqlParameter("@type",MySqlDbType.Int32,11){Value = SelectType(type)}
            };
            myCom.Parameters.AddRange(paras);

            try
            {
                myConn.Open();

                using (MySqlDataReader reader = myCom.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        if (user == null)
                        {
                            user = new User();

                            user.user_id = reader.GetInt32("user_id");
                            user.user_name = username;
                            user.user_pass = password;
                            user.role_type = type;
                            user.is_lock = reader.GetInt32("is_lock");
                            user.add_Time = reader.GetDateTime("add_time");
                        }

                    }
                }
            }
            catch(MySqlException exo)
            {
                Console.Write(exo.ToString());
            }

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
            myCom.Parameters.Add(new MySqlParameter("@roleName", type));

            try
            {
                myConn.Open();

                using (MySqlDataReader reader = myCom.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        flag = reader.GetInt32(0);
                    }
                }
            }catch(MySqlException exc)
            {
                Console.Write(exc.ToString());
            }

            return flag;
            
        }

        private MySqlConnection myConn;
    }
}
