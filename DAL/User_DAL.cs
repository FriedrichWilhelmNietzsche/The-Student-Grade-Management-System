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
            //myConn = new MySqlConnection("Host=" + DbUtil.host + ";Database=" + DbUtil.Database + ";Username=" + DbUtil.username + ";Password=" + DbUtil.password + ";");
            myConn = new MySqlConnection($"Host={ DbUtil.host };Database={ DbUtil.Database} ;Username={DbUtil.username};Password={DbUtil.password};");
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
        public User SelectUser(string username, string password,int type)
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
                new MySqlParameter("@type",MySqlDbType.Int32,11){Value = type}
            };
            myCom.Parameters.AddRange(paras);

            try
            {
                string role_type = GetTypeName(type);
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
                            user.role_type = role_type;
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

        public Model.UserInfo SelectUserInfo(int id)
        {
            const string selectSql = "SELECT * FROM users_info WHERE user_id = @id;";
            UserInfo userInfo = null;

            MySqlCommand myCom = myConn.CreateCommand();
            myCom.CommandText = selectSql;
            myCom.CommandType = System.Data.CommandType.Text;

            myCom.Parameters.Add(new MySqlParameter("@id", id));

            try
            {
                myConn.Open();

                using (MySqlDataReader reader = myCom.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        if(userInfo == null)
                        {
                            userInfo = new UserInfo();
                            userInfo.user_id = id;
                            userInfo.real_name = reader.GetString("real_name");
                            userInfo.number = reader.GetString("number");
                            userInfo.sex = reader.GetString("sex");
                            userInfo.telephone = reader.GetString("telephone");
                            userInfo.email = reader.GetString("email");
                            if (reader.IsDBNull(6))
                            {
                                userInfo.explain = "";
                            }
                            else
                            {
                                userInfo.explain = reader.GetString("explain");
                            }
                            return userInfo;
                        }
                    }
                }
            }catch(Exception exc)
            {
                Console.Write(exc.Message);
            }

            return null;
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

        public string GetTypeName(int role_type)
        {
            const string selectRole = "SELECT role_name FROM role_table WHERE role_type = @role_type";

            string name = "";

            MySqlCommand myCom = myConn.CreateCommand();
            myCom.CommandText = selectRole;
            myCom.CommandType = System.Data.CommandType.Text;
            myCom.Parameters.Add(new MySqlParameter("@role_type",role_type));

            try
            {
                myConn.Open();

                using (MySqlDataReader reader = myCom.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                }
            }
            catch (MySqlException exc)
            {
                Console.Write(exc.ToString());
            }

            return name;
        }

        public void ModifyUserInfo(int user_id,string email, string tel, string explain)
        {
            const string updateSql = "Update `users_info` SET `telephone` = @tel,`email` = @email,`explain` = @explain WHERE user_id = @user_id";

            MySqlCommand myCom = myConn.CreateCommand();
            myCom.CommandText = updateSql;
            myCom.CommandType = System.Data.CommandType.Text;
            MySqlParameter[] paras = new[]
            {
                new MySqlParameter("@tel",MySqlDbType.VarChar,11){Value = tel},
                new MySqlParameter("@email",MySqlDbType.VarChar,20){Value = email},
                new MySqlParameter("@user_id",MySqlDbType.Int32,11){Value = user_id},
                new MySqlParameter("@explain",MySqlDbType.VarChar,50){Value = explain}
            };
            myCom.Parameters.AddRange(paras);


            try
            {
                myConn.Open();

                myCom.ExecuteNonQuery();

                myConn.Close();
            }
            catch (Exception exc)
            {
                Console.Write(exc);
                myConn.Close();
            }


        }

        private MySqlConnection myConn;
    }
}
