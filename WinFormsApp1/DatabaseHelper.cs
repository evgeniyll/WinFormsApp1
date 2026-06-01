using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public static class DatabaseHelper
    {
        public static readonly string ConnectionString =
            "Data Source=EVGENIY_LL;Initial Catalog=tourism;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(bytes).ToLower();
        }

        // ───────── Авторизация ─────────
        // Возвращает role_id или -1 если не найден
        public static int Login(string login, string password)
        {
            string hash = HashPassword(password);
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    "SELECT roleid FROM users WHERE login = @login AND password = @password", conn);
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

        // ───────── Регистрация клиента (role_id = 4) ─────────
        public static bool Register(string login, string email, string password)
        {
            return RegisterWithRole(login, email, password, 4);
        }

        // ───────── Регистрация сотрудника директором ─────────
        public static bool RegisterWithRole(string login, string email, string password, int roleId)
        {
            string hash = HashPassword(password);
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();

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
                    "INSERT INTO users (login, email, password, roleid) VALUES (@login, @email, @password, @roleid)", conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", hash);
                cmd.Parameters.AddWithValue("@roleid", roleId);
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

        // ───────── Получить всех сотрудников (role_id 1-3) ─────────
        public static DataTable GetEmployees()
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    @"SELECT id, login, email, 
                        CASE roleid 
                            WHEN 1 THEN 'Директор'
                            WHEN 2 THEN 'Менеджер'
                            WHEN 3 THEN 'Аналитик'
                        END AS Роль
                      FROM users WHERE roleid IN (1, 2, 3)
                      ORDER BY roleid, login", conn);
                var dt = new DataTable();
                using var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        // ───────── Удалить пользователя по id ─────────
        public static bool DeleteUser(int userId)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                using var cmd = new SqlCommand("DELETE FROM users WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
