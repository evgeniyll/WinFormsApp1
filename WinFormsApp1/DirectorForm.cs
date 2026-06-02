namespace WinFormsApp1
{
    public partial class DirectorForm : Form
    {
        private readonly string _login;
        private readonly int _roleId;

        private static readonly string[] RoleNames = { "", "Директор", "Менеджер", "Аналитик" };

        // Словарь: название в списке → таблица в БД
        private static readonly Dictionary<string, string> ReportTables = new()
        {
            { "Сотрудники",                 "users" },
            { "Прейскурант",                "preuskyrant" },
            { "Объёмы услуг за месяц",      "yslugi" },
            { "Статистика",                 "statistiks" },
        };

        public DirectorForm(string login, int roleId)
        {
            _login = login;
            _roleId = roleId;
            InitializeComponent();
            lblWelcome.Text = $"Добро пожаловать, {login}  |  {RoleNames[roleId]}";
            LoadEmployees();
            ShowEmployeesTab();
        }

        // ───────── Переключение вкладок ─────────

        private void SetAllTabsInactive()
        {
            foreach (Button btn in new[] { btnTabEmployees, btnTabAdd, btnTabDelete, btnTabReports })
            {
                btn.BackColor = Color.FromArgb(245, 245, 245);
                btn.ForeColor = Color.FromArgb(60, 60, 60);
            }
            panelEmployees.Visible = false;
            panelAdd.Visible = false;
            panelDelete.Visible = false;
            panelReports.Visible = false;
        }

        private void SetTabActive(Button btn, Panel panel)
        {
            SetAllTabsInactive();
            btn.BackColor = Color.FromArgb(0, 150, 136);
            btn.ForeColor = Color.White;
            panel.Visible = true;
        }

        private void btnTabEmployees_Click(object sender, EventArgs e) => ShowEmployeesTab();
        private void btnTabAdd_Click(object sender, EventArgs e) => ShowAddTab();
        private void btnTabDelete_Click(object sender, EventArgs e) => ShowDeleteTab();
        private void btnTabReports_Click(object sender, EventArgs e) => ShowReportsTab();

        private void ShowEmployeesTab()
        {
            SetTabActive(btnTabEmployees, panelEmployees);
            LoadEmployees();
        }

        private void ShowAddTab()
        {
            SetTabActive(btnTabAdd, panelAdd);
            ClearAddForm();
        }

        private void ShowDeleteTab()
        {
            SetTabActive(btnTabDelete, panelDelete);
            ClearDeleteForm();
        }

        private void ShowReportsTab()
        {
            SetTabActive(btnTabReports, panelReports);
        }

        // ───────── Список сотрудников ─────────

        private void LoadEmployees()
        {
            var dt = DatabaseHelper.GetEmployees();
            dgvEmployees.DataSource = dt;

            if (dgvEmployees.Columns.Count > 0)
            {
                dgvEmployees.Columns["id"].HeaderText    = "ID";
                dgvEmployees.Columns["id"].Width         = 50;
                dgvEmployees.Columns["login"].HeaderText = "Логин";
                dgvEmployees.Columns["login"].Width      = 150;
                dgvEmployees.Columns["email"].HeaderText = "Email";
                dgvEmployees.Columns["email"].Width      = 200;
                dgvEmployees.Columns["Роль"].HeaderText  = "Роль";
                dgvEmployees.Columns["Роль"].Width       = 120;
            }
        }

        // ───────── Добавление сотрудника ─────────

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string login    = txtAddLogin.Text.Trim();
            string email    = txtAddEmail.Text.Trim();
            string password = txtAddPassword.Text;
            int roleId      = cmbRole.SelectedIndex + 1;

            if (string.IsNullOrEmpty(login) || login == "Логин" ||
                string.IsNullOrEmpty(email) || email == "Email" ||
                string.IsNullOrEmpty(password) || password == "Пароль")
            {
                lblAddError.Text = "Заполните все поля.";
                lblAddError.Visible = true;
                return;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                lblAddError.Text = "Выберите роль сотрудника.";
                lblAddError.Visible = true;
                return;
            }

            if (password.Length < 6)
            {
                lblAddError.Text = "Пароль должен содержать минимум 6 символов.";
                lblAddError.Visible = true;
                return;
            }

            bool success = DatabaseHelper.RegisterWithRole(login, email, password, roleId);
            if (success)
            {
                lblAddError.Visible = false;
                MessageBox.Show($"Сотрудник «{login}» успешно добавлен!", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddForm();
                ShowEmployeesTab();
            }
            else
            {
                lblAddError.Text = "Ошибка. Попробуйте другой логин или email.";
                lblAddError.Visible = true;
            }
        }

        private void ClearAddForm()
        {
            SetPlaceholder(txtAddLogin, "Логин");
            SetPlaceholder(txtAddEmail, "Email");
            SetPlaceholder(txtAddPassword, "Пароль");
            cmbRole.SelectedIndex = -1;
            lblAddError.Visible = false;
        }

        // ───────── Удаление сотрудника по логину ─────────

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string login = txtDeleteLogin.Text.Trim();

            if (string.IsNullOrEmpty(login) || login == "Введите логин сотрудника")
            {
                lblDeleteError.Text = "Введите логин сотрудника.";
                lblDeleteError.Visible = true;
                return;
            }

            var confirm = MessageBox.Show(
                $"Вы уверены, что хотите удалить сотрудника?\n\nЛогин: {login}",
                "Подтверждение удаления",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.OK) return;

            bool success = DatabaseHelper.DeleteUserByLogin(login);
            if (success)
            {
                lblDeleteError.Visible = false;
                MessageBox.Show($"Сотрудник «{login}» успешно удалён.", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDeleteForm();
            }
            else
            {
                lblDeleteError.Text = "Сотрудник с таким логином не найден.";
                lblDeleteError.Visible = true;
            }
        }

        private void ClearDeleteForm()
        {
            SetPlaceholder(txtDeleteLogin, "Введите логин сотрудника");
            lblDeleteError.Visible = false;
        }

        // ───────── Отчёты ─────────

        private void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReports.SelectedIndex == -1) return;

            string selected = cmbReports.SelectedItem?.ToString() ?? "";
            if (!ReportTables.TryGetValue(selected, out string? tableName)) return;

            var dt = DatabaseHelper.GetTable(tableName);
            dgvReports.DataSource = dt;
        }

        // ───────── Выход ─────────

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        // ───────── Placeholder ─────────

        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Silver;
            if (placeholder == "Пароль") tb.PasswordChar = '\0';
        }

        private void ClearPlaceholder(TextBox tb, string placeholder, bool isPassword = false)
        {
            if (tb.Text == placeholder)
            {
                tb.Text = "";
                tb.ForeColor = Color.FromArgb(40, 40, 40);
                if (isPassword) tb.PasswordChar = '●';
            }
        }

        private void txtAddLogin_Enter(object sender, EventArgs e)    => ClearPlaceholder(txtAddLogin, "Логин");
        private void txtAddLogin_Leave(object sender, EventArgs e)    => SetPlaceholder(txtAddLogin, "Логин");
        private void txtAddEmail_Enter(object sender, EventArgs e)    => ClearPlaceholder(txtAddEmail, "Email");
        private void txtAddEmail_Leave(object sender, EventArgs e)    => SetPlaceholder(txtAddEmail, "Email");
        private void txtAddPassword_Enter(object sender, EventArgs e) => ClearPlaceholder(txtAddPassword, "Пароль", true);
        private void txtAddPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddPassword.Text))
            {
                txtAddPassword.PasswordChar = '\0';
                txtAddPassword.Text = "Пароль";
                txtAddPassword.ForeColor = Color.Silver;
            }
        }

        private void txtDeleteLogin_Enter(object sender, EventArgs e) => ClearPlaceholder(txtDeleteLogin, "Введите логин сотрудника");
        private void txtDeleteLogin_Leave(object sender, EventArgs e) => SetPlaceholder(txtDeleteLogin, "Введите логин сотрудника");
    }
}
