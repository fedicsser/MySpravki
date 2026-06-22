using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MySpravki
{
    public class Proof
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Type { get; set; }
        public string Other { get; set; }
        public int Count { get; set; }
        public string Reason { get; set; }

        public Proof(int userId, string name, string surname, string patronymic,
                     int type, string other, int count, string reason)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Type = type;
            Other = other;
            Count = count;
            Reason = reason;
        }

        // Метод для сохранения в БД
        public bool SaveToDatabase()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                string query = "INSERT INTO `Proof` (`userId`, `name`, `surname`, `patronymic`, `type`, `other`, `count`, `reason`) VALUES (@userId, @name, @surname, @patronymic, @type, @other, @count, @reason);";

                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@userId", UserId);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@patronymic", Patronymic);
                cmd.Parameters.AddWithValue("@type", Type);
                cmd.Parameters.AddWithValue("@other", Other ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@count", Count);
                cmd.Parameters.AddWithValue("@reason", Reason);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}