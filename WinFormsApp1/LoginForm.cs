namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private bool _isLoginTab = true;

        public LoginForm()
        {
            InitializeComponent();
            ShowLoginTab();
        }

        // ───────── Переключение вкладок ─────────

        private void lblLogin_Click(object sender, EventArgs e)
        {
            _isLoginTab = true;
            ShowLoginTab();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            _isLoginTab = false;
            ShowSignUpTab();
        }

        private void ShowLoginTab()
        {
            lblLogin.Font = new Font(lblLogin.Font, FontStyle.Bold);
            lblSignUp.Font = new Font(lblSignUp.Font, FontStyle.Regular);
            lblUnderline.Left = lblLogin.Left;
            lblUnderline.Width = lblLogin.Width;
            panelLogin.Visible = true;
            panelRegister.Visible = false;
        }

        private void ShowSignUpTab()
        {
            lblSignUp.Font = new Font(lblSignUp.Font, FontStyle.Bold);
            lblLogin.Font = new Font(lblLogin.Font, FontStyle.Regular);
            lblUnderline.Left = lblSignUp.Left;
            lblUnderline.Width = lblSignUp.Width;
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }

        // ───────── Авторизация ─────────

        private void btnEnterLogin_Click(object sender, EventArgs e)
        {
            string login = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)
                || login == "Username" || password == "Password (A-Z,a-z,0-9)")
            {
                lblLoginError.Text = "Заполните все поля.";
                lblLoginError.Visible = true;
                return;
            }

            int roleId = DatabaseHelper.Login(login, password);
            if (roleId == -1)
            {
                lblLoginError.Text = "Неверный логин или пароль.";
                lblLoginError.Visible = true;
                return;
            }

            lblLoginError.Visible = false;

            // Открываем нужную форму в зависимости от роли
            if (roleId == 1 || roleId == 2)
            {
                var directorForm = new DirectorForm(login, roleId);
                directorForm.Show();
                this.Hide();
            }
            else if (roleId == 3)
            {
                var analystForm = new AnalystForm(login, roleId);
                analystForm.Show();
                this.Hide();
            else
            {
                // roleId == 4 — клиент, TODO: форма клиента
                MessageBox.Show($"Добро пожаловать, {login}!", "Вход выполнен",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ───────── Регистрация клиента ─────────

        private void btnEnterRegister_Click(object sender, EventArgs e)
        {
            string login = txtRegLogin.Text.Trim();
            string email = txtRegEmail.Text.Trim();
            string password = txtRegPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)
                || login == "Username" || email == "Email" || password == "Password (A-Z,a-z,0-9)")
            {
                lblRegError.Text = "Заполните все поля.";
                lblRegError.Visible = true;
                return;
            }

            if (password.Length < 6)
            {
                lblRegError.Text = "Пароль должен содержать минимум 6 символов.";
                lblRegError.Visible = true;
                return;
            }

            bool success = DatabaseHelper.Register(login, email, password);
            if (success)
            {
                lblRegError.Visible = false;
                MessageBox.Show("Регистрация прошла успешно! Теперь войдите в аккаунт.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowLoginTab();
                txtLoginUsername.Text = login;
                txtLoginPassword.Focus();
            }
            else
            {
                lblRegError.Text = "Ошибка регистрации. Попробуйте другой логин или email.";
                lblRegError.Visible = true;
            }
        }

        // ───────── Закрыть ─────────

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        // ───────── Placeholder эффекты ─────────

        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                tb.Text = placeholder;
                tb.ForeColor = Color.Silver;
            }
        }

        private void ClearPlaceholder(TextBox tb, string placeholder, bool isPassword = false)
        {
            if (tb.Text == placeholder)
            {
                tb.Text = "";
                tb.ForeColor = Color.FromArgb(60, 60, 60);
                if (isPassword) tb.PasswordChar = '●';
            }
        }

        private void txtLoginUsername_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtLoginUsername, "Username");
        private void txtLoginUsername_Leave(object sender, EventArgs e) =>
            SetPlaceholder(txtLoginUsername, "Username");

        private void txtLoginPassword_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtLoginPassword, "Password (A-Z,a-z,0-9)", true);
        private void txtLoginPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                txtLoginPassword.PasswordChar = '\0';
                txtLoginPassword.Text = "Password (A-Z,a-z,0-9)";
                txtLoginPassword.ForeColor = Color.Silver;
            }
        }

        private void txtRegLogin_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtRegLogin, "Username");
        private void txtRegLogin_Leave(object sender, EventArgs e) =>
            SetPlaceholder(txtRegLogin, "Username");

        private void txtRegEmail_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtRegEmail, "Email");
        private void txtRegEmail_Leave(object sender, EventArgs e) =>
            SetPlaceholder(txtRegEmail, "Email");

        private void txtRegPassword_Enter(object sender, EventArgs e) =>
            ClearPlaceholder(txtRegPassword, "Password (A-Z,a-z,0-9)", true);
        private void txtRegPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegPassword.Text))
            {
                txtRegPassword.PasswordChar = '\0';
                txtRegPassword.Text = "Password (A-Z,a-z,0-9)";
                txtRegPassword.ForeColor = Color.Silver;
            }
        }
    }
}
