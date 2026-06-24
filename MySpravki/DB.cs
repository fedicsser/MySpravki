using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpravki
{
    //класс для подключения к бд и отк/закр/получния соединения
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user id = root;password=;Database=testPOCA");

        public void openConnection()
        {
            connection.Open();
        }
        public void closeConnection()
        {
            connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
