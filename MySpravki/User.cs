using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySpravki
{
    public class User
    {
        public int id;
        public string login;
        public string password;

        public static string UserAuth(string Login, string Password)
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                string query = "SELECT id FROM `user` WHERE login = @Login AND password = @Password;";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Password", Password);
                var res = cmd.ExecuteScalar();
                if (res != null)
                {
                    return res.ToString();
                }
                else
                {
                    return null;
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
    }

    


}
