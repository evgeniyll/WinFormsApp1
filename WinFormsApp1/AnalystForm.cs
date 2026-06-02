namespace WinFormsApp1
{
    public partial class AnalystForm : Form
    {
        private readonly string _login;
        private readonly int _roleId;
        private static readonly string[] RoleNames = { "", "Директор", "Менеджер", "Аналитик" };

        private static readonly Dictionary<string, string> ReportTables = new()
        {
            { "Прейскурант",           "preuskyrant" },
            { "Объёмы услуг за месяц", "yslugi"      },
            { "Статистика",            "statistiks"  },
            { "Сотрудники",            "users"       },
        };

        private string? _currentTable = null;

        public AnalystForm(string login, int roleId)
        {
            _login  = login;
            _roleId = roleId;
            InitializeComponent();
            lblWelcome.Text = $"Добро пожаловать, {login}  |  {RoleNames[roleId]}";
        }

        // ───────── Выбор отчёта ─────────

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReport.SelectedIndex == -1) return;

            string selected = cmbReport.SelectedItem?.ToString() ?? "";
            if (!ReportTables.TryGetValue(selected, out string? tableName)) return;

            _currentTable = tableName;
            LoadTable(tableName);

            // Сотрудников редактировать нельзя
            bool isEditable = tableName != "users";
            dgvData.ReadOnly           = !isEditable;
            dgvData.AllowUserToAddRows = isEditable;
            btnSave.Enabled            = isEditable;
            btnSave.BackColor          = isEditable
                ? Color.FromArgb(0, 150, 136)
                : Color.FromArgb(180, 180, 180);

            lblStatus.Text    = isEditable
                ? "Вы можете редактировать таблицу. Нажмите «Сохранить» после изменений."
                : "Таблица доступна только для просмотра.";
            lblStatus.Visible = true;
        }

        private void LoadTable(string tableName)
        {
            var dt = DatabaseHelper.GetTable(tableName);
            dgvData.DataSource = dt;
            lblStatus.Visible  = false;
        }

        // ───────── Сохранить изменения ─────────

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentTable == null) return;

            try
            {
                var dt = (System.Data.DataTable)dgvData.DataSource;
                DatabaseHelper.SaveTable(dt, _currentTable);
                MessageBox.Show("Данные успешно сохранены!", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text    = $"✅ Сохранено в {DateTime.Now:HH:mm:ss}";
                lblStatus.Visible = true;
                // Перезагружаем чтобы получить актуальные id
                LoadTable(_currentTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ───────── Выход ─────────

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
