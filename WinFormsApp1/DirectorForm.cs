namespace WinFormsApp1
{
    public partial class DirectorForm : Form
    {
        private readonly string _login;
        private readonly int _roleId;

        private static readonly string[] RoleNames = { "", "Директор", "Менеджер", "Аналитик" };

        public DirectorForm(string login, int roleId)
        {
            _login = login;
            _roleId = roleId;
            InitializeComponent();
            lblWelcome.Text = $"Добро пожаловать, {login}  |  {RoleNames[roleId]}";
            LoadEmployees();
            ShowEmployeesTab();
        }

        // ───────── Вкладки ─────────

        private void btnTabEmployees_Click(object sender, EventArgs e) => ShowEmployeesTab();
        private void btnTabAdd_Click(object sender, EventArgs e) => ShowAddTab();

        private void ShowEmployeesTab()
        {
            panelEmployees.Visible = true;
            panelAdd.Visible = false;
            btnTabEmployees.BackColor = Color.FromArgb(0, 150, 136);
            btnTabEmployees.ForeColor = Color.White;
            btnTabAdd.BackColor = Color.FromArgb(245, 245, 245);
            btnTabAdd.ForeColor = Color.FromArgb(60, 60, 60);
            LoadEmployees();
        }

        private void ShowAddTab()
        {
            panelEmployees.Visible = false;
            panelAdd.Visible = true;
            btnTabAdd.BackColor = Color.FromArgb(0, 150, 136);
            btnTabAdd.ForeColor = Color.White;
            btnTabEmployees.BackColor = Color.FromArgb(245, 245, 245);
            btnTabEmployees.ForeColor = Color.FromArgb(60, 60, 60);
            ClearAddForm();
        }

        // ───────── Список сотрудников ─────────

        private void LoadEmployees()
        {
            var dt = DatabaseHelper.GetEmployees();
            dgvEmployees.DataSource = dt;

            if (dgvEmployees.Columns.Count > 0)
            {
                dgvEmployees.Columns["id"].HeaderText = "ID";
                dgvEmployees.Columns["id"].Width = 50;
                dgvEmployees.Columns["login"].HeaderText = "Логин";
                dgvEmployees.Columns["login"].Width = 150;
                dgvEmployees.Columns["email"].HeaderText = "Email";
                dgvEmployees.Columns["email"].Width = 200;
                dgvEmployees.Columns["Роль"].HeaderText = "Роль";
                dgvEmployees.Columns["Роль"].Width = 120;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvEmployees.SelectedRows[0];
            string login = row.Cells["login"].Value?.ToString() ?? "";
            string role = row.Cells["Роль"].Value?.ToString() ?? "";
            int id = Convert.ToInt32(row.Cells["id"].Value);

            var confirm = MessageBox.Show(
                $"Вы уверены, что хотите удалить сотрудника?\n\nЛогин: {login}\nРоль: {role}",
                "Подтверждение удаления",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.OK)
            {
                bool success = DatabaseHelper.DeleteUser(id);
                if (success)
                {
                    MessageBox.Show($"Сотрудник «{login}» успешно удалён.", "Готово",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                }
            }
        }

        // ───────── Добавление сотрудника ─────────

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string login = txtAddLogin.Text.Trim();
            string email = txtAddEmail.Text.Trim();
            string password = txtAddPassword.Text;
            int roleId = cmbRole.SelectedIndex + 1; // 1=Директор, 2=Менеджер, 3=Аналитик

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

        // ───────── Выход ─────────

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
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

        private void txtAddLogin_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtAddLogin, "Логин");
        private void txtAddLogin_Leave(object sender, EventArgs e) =>
            SetPlaceholder(txtAddLogin, "Логин");

        private void txtAddEmail_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtAddEmail, "Email");
        private void txtAddEmail_Leave(object sender, EventArgs e) =>
            SetPlaceholder(txtAddEmail, "Email");

        private void txtAddPassword_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtAddPassword, "Пароль", true);
        private void txtAddPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddPassword.Text))
            {
                txtAddPassword.PasswordChar = '\0';
                txtAddPassword.Text = "Пароль";
                txtAddPassword.ForeColor = Color.Silver;
            }
        }
    }
}
