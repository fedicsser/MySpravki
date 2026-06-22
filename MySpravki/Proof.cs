using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedIn { get; set; }
        public string Path { get; set; }

        // Конструктор для создания объекта
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
            Status = "отправлено";
            CreatedAt = DateTime.Now;
            CompletedIn = DateTime.Now;
            Path = null;
        }

        // Конструктор для загрузки из БД
        public Proof(int id, int userId, string name, string surname, string patronymic,
                     int type, string other, int count, string reason,
                     string status, DateTime createdAt, DateTime completedIn, string path)
        {
            Id = id;
            UserId = userId;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Type = type;
            Other = other;
            Count = count;
            Reason = reason;
            Status = status;
            CreatedAt = createdAt;
            CompletedIn = completedIn;
            Path = path;
        }

        // Метод для сохранения в БД
        public bool SaveToDatabase()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                string query = "INSERT INTO `Proof` (`userId`, `name`, `surname`, `patronymic`, `type`, `other`, `count`, `reason`, `status`, `created_at`, `completed_in`, `path`) VALUES (@userId, @name, @surname, @patronymic, @type, @other, @count, @reason, @status, @created_at, @completed_in, @path);";

                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@userId", UserId);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@patronymic", Patronymic);
                cmd.Parameters.AddWithValue("@type", Type);
                cmd.Parameters.AddWithValue("@other", Other ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@count", Count);
                cmd.Parameters.AddWithValue("@reason", Reason);
                cmd.Parameters.AddWithValue("@status", Status);
                cmd.Parameters.AddWithValue("@created_at", CreatedAt);
                cmd.Parameters.AddWithValue("@completed_in", CompletedIn);
                cmd.Parameters.AddWithValue("@path", Path ?? (object)DBNull.Value);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

        // Статический метод для получения всех заявок пользователя
        public static List<Proof> GetUserProofs(int userId)
        {
            List<Proof> proofs = new List<Proof>();
            DB db = new DB();

            try
            {
                db.openConnection();
                string query = "SELECT * FROM `Proof` WHERE `userId` = @userId ORDER BY `created_at` DESC;";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@userId", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proof proof = new Proof(
                            reader.GetInt32("id"),
                            reader.GetInt32("userId"),
                            reader.GetString("name"),
                            reader.GetString("surname"),
                            reader.GetString("patronymic"),
                            reader.GetInt32("type"),
                            reader.IsDBNull(reader.GetOrdinal("other")) ? "" : reader.GetString("other"),
                            reader.GetInt32("count"),
                            reader.GetString("reason"),
                            reader.GetString("status"),
                            reader.GetDateTime("created_at"),
                            reader.GetDateTime("completed_in"),
                            reader.IsDBNull(reader.GetOrdinal("path")) ? null : reader.GetString("path")
                        );
                        proofs.Add(proof);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }

            return proofs;
        }

        // Метод для получения названия типа справки
        public string GetTypeName()
        {
            switch (Type)
            {
                case 1: return "2-НДФЛ";
                case 2: return "О месте работы и стаже";
                case 3: return "О среднем заработке";
                case 4: return "Произвольная справка";
                default: return "Неизвестный тип";
            }
        }
    }
}