using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString =
            "Data Source=EVGENIY_LL;Initial Catalog=tourism;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(bytes).ToLower();
        }

        /// <summary>
        /// Проверяет логин/пароль. Возвращает role_id или -1 если не найден.
        /// </summary>
        public static int Login(string login, string password)
        {
            string hash = HashPassword(password);
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    "SELECT role_id FROM users WHERE login = @login AND password = @password", conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", hash);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к БД:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /// <summary>
        /// Регистрирует нового пользователя. Возвращает true при успехе.
        /// </summary>
        public static bool Register(string login, string email, string password)
        {
            string hash = HashPassword(password);
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();

                // Проверяем, не занят ли логин
                using var checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM users WHERE login = @login OR email = @email", conn);
                checkCmd.Parameters.AddWithValue("@login", login);
                checkCmd.Parameters.AddWithValue("@email", email);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Пользователь с таким логином или email уже существует.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                using var cmd = new SqlCommand(
                    "INSERT INTO users (login, email, password) VALUES (@login, @email, @password)", conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", hash);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
