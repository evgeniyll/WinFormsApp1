namespace WinFormsApp1
{
    partial class DirectorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblWelcome = new Label();
            btnLogout = new Button();
            panelSidebar = new Panel();
            btnTabEmployees = new Button();
            btnTabAdd = new Button();
            panelContent = new Panel();

            // Employees panel
            panelEmployees = new Panel();
            dgvEmployees = new DataGridView();
            btnDelete = new Button();
            lblEmployeesTitle = new Label();

            // Add panel
            panelAdd = new Panel();
            lblAddTitle = new Label();
            txtAddLogin = new TextBox();
            txtAddEmail = new TextBox();
            txtAddPassword = new TextBox();
            cmbRole = new ComboBox();
            btnAddEmployee = new Button();
            lblAddError = new Label();

            panelTop.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            panelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panelAdd.SuspendLayout();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            Name = "DirectorForm";
            Text = "TourismBlitz — Панель управления";
            ClientSize = new Size(900, 580);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(245, 247, 250);

            // ── panelTop ──────────────────────────────────────────
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 56;
            panelTop.BackColor = Color.FromArgb(0, 100, 160);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Controls.Add(btnLogout);

            lblWelcome.Text = "";
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(16, 16);

            btnLogout.Text = "⬅ Выйти";
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.ForeColor = Color.White;
            btnLogout.BackColor = Color.FromArgb(0, 80, 130);
            btnLogout.Size = new Size(90, 32);
            btnLogout.Location = new Point(794, 12);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += btnLogout_Click;

            // ── panelSidebar ──────────────────────────────────────
            panelSidebar.Location = new Point(0, 56);
            panelSidebar.Size = new Size(180, 524);
            panelSidebar.BackColor = Color.FromArgb(30, 40, 55);
            panelSidebar.Controls.Add(btnTabEmployees);
            panelSidebar.Controls.Add(btnTabAdd);

            btnTabEmployees.Text = "👥  Сотрудники";
            btnTabEmployees.Font = new Font("Segoe UI", 10F);
            btnTabEmployees.FlatStyle = FlatStyle.Flat;
            btnTabEmployees.FlatAppearance.BorderSize = 0;
            btnTabEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnTabEmployees.Padding = new Padding(16, 0, 0, 0);
            btnTabEmployees.Size = new Size(180, 48);
            btnTabEmployees.Location = new Point(0, 20);
            btnTabEmployees.Cursor = Cursors.Hand;
            btnTabEmployees.BackColor = Color.FromArgb(0, 150, 136);
            btnTabEmployees.ForeColor = Color.White;
            btnTabEmployees.Click += btnTabEmployees_Click;

            btnTabAdd.Text = "➕  Добавить";
            btnTabAdd.Font = new Font("Segoe UI", 10F);
            btnTabAdd.FlatStyle = FlatStyle.Flat;
            btnTabAdd.FlatAppearance.BorderSize = 0;
            btnTabAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnTabAdd.Padding = new Padding(16, 0, 0, 0);
            btnTabAdd.Size = new Size(180, 48);
            btnTabAdd.Location = new Point(0, 68);
            btnTabAdd.Cursor = Cursors.Hand;
            btnTabAdd.BackColor = Color.FromArgb(245, 245, 245);
            btnTabAdd.ForeColor = Color.FromArgb(60, 60, 60);
            btnTabAdd.Click += btnTabAdd_Click;

            // ── panelContent ──────────────────────────────────────
            panelContent.Location = new Point(180, 56);
            panelContent.Size = new Size(720, 524);
            panelContent.BackColor = Color.FromArgb(245, 247, 250);
            panelContent.Controls.Add(panelEmployees);
            panelContent.Controls.Add(panelAdd);

            // ── panelEmployees ────────────────────────────────────
            panelEmployees.Dock = DockStyle.Fill;
            panelEmployees.BackColor = Color.Transparent;
            panelEmployees.Controls.Add(lblEmployeesTitle);
            panelEmployees.Controls.Add(dgvEmployees);
            panelEmployees.Controls.Add(btnDelete);
            panelEmployees.Visible = true;

            lblEmployeesTitle.Text = "Список сотрудников";
            lblEmployeesTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEmployeesTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblEmployeesTitle.AutoSize = true;
            lblEmployeesTitle.Location = new Point(20, 20);

            // dgvEmployees
            dgvEmployees.Location = new Point(20, 60);
            dgvEmployees.Size = new Size(680, 380);
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 100, 160);
            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvEmployees.ColumnHeadersHeight = 36;
            dgvEmployees.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvEmployees.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 255);
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 40, 55);
            dgvEmployees.GridColor = Color.FromArgb(220, 225, 235);
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect = false;
            dgvEmployees.ReadOnly = true;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnDelete.Text = "🗑  Удалить выбранного";
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(200, 50, 50);
            btnDelete.ForeColor = Color.FromArgb(200, 50, 50);
            btnDelete.BackColor = Color.White;
            btnDelete.Size = new Size(200, 36);
            btnDelete.Location = new Point(20, 455);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += btnDelete_Click;

            // ── panelAdd ──────────────────────────────────────────
            panelAdd.Dock = DockStyle.Fill;
            panelAdd.BackColor = Color.Transparent;
            panelAdd.Controls.Add(lblAddTitle);
            panelAdd.Controls.Add(txtAddLogin);
            panelAdd.Controls.Add(txtAddEmail);
            panelAdd.Controls.Add(txtAddPassword);
            panelAdd.Controls.Add(cmbRole);
            panelAdd.Controls.Add(btnAddEmployee);
            panelAdd.Controls.Add(lblAddError);
            panelAdd.Visible = false;

            lblAddTitle.Text = "Добавить сотрудника";
            lblAddTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAddTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblAddTitle.AutoSize = true;
            lblAddTitle.Location = new Point(20, 20);

            // txtAddLogin
            txtAddLogin.Text = "Логин";
            txtAddLogin.ForeColor = Color.Silver;
            txtAddLogin.Font = new Font("Segoe UI", 11F);
            txtAddLogin.BorderStyle = BorderStyle.FixedSingle;
            txtAddLogin.BackColor = Color.White;
            txtAddLogin.Size = new Size(340, 36);
            txtAddLogin.Location = new Point(20, 70);
            txtAddLogin.Enter += txtAddLogin_Enter;
            txtAddLogin.Leave += txtAddLogin_Leave;

            // txtAddEmail
            txtAddEmail.Text = "Email";
            txtAddEmail.ForeColor = Color.Silver;
            txtAddEmail.Font = new Font("Segoe UI", 11F);
            txtAddEmail.BorderStyle = BorderStyle.FixedSingle;
            txtAddEmail.BackColor = Color.White;
            txtAddEmail.Size = new Size(340, 36);
            txtAddEmail.Location = new Point(20, 126);
            txtAddEmail.Enter += txtAddEmail_Enter;
            txtAddEmail.Leave += txtAddEmail_Leave;

            // txtAddPassword
            txtAddPassword.Text = "Пароль";
            txtAddPassword.ForeColor = Color.Silver;
            txtAddPassword.Font = new Font("Segoe UI", 11F);
            txtAddPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAddPassword.BackColor = Color.White;
            txtAddPassword.Size = new Size(340, 36);
            txtAddPassword.Location = new Point(20, 182);
            txtAddPassword.Enter += txtAddPassword_Enter;
            txtAddPassword.Leave += txtAddPassword_Leave;

            // cmbRole
            cmbRole.Font = new Font("Segoe UI", 11F);
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.BackColor = Color.White;
            cmbRole.Size = new Size(340, 36);
            cmbRole.Location = new Point(20, 238);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Директор", "Менеджер", "Аналитик" });
            cmbRole.SelectedIndex = -1;

            // lblAddError
            lblAddError.ForeColor = Color.Crimson;
            lblAddError.Font = new Font("Segoe UI", 9F);
            lblAddError.AutoSize = true;
            lblAddError.Location = new Point(20, 284);
            lblAddError.Visible = false;

            // btnAddEmployee
            btnAddEmployee.Text = "Добавить сотрудника";
            btnAddEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.BackColor = Color.FromArgb(0, 150, 136);
            btnAddEmployee.Size = new Size(340, 44);
            btnAddEmployee.Location = new Point(20, 304);
            btnAddEmployee.Cursor = Cursors.Hand;
            btnAddEmployee.Click += btnAddEmployee_Click;

            // ── Add to Form ───────────────────────────────────────
            Controls.Add(panelTop);
            Controls.Add(panelSidebar);
            Controls.Add(panelContent);

            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelEmployees.ResumeLayout(false);
            panelEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop = null!;
        private Label lblWelcome = null!;
        private Button btnLogout = null!;
        private Panel panelSidebar = null!;
        private Button btnTabEmployees = null!;
        private Button btnTabAdd = null!;
        private Panel panelContent = null!;

        private Panel panelEmployees = null!;
        private Label lblEmployeesTitle = null!;
        private DataGridView dgvEmployees = null!;
        private Button btnDelete = null!;

        private Panel panelAdd = null!;
        private Label lblAddTitle = null!;
        private TextBox txtAddLogin = null!;
        private TextBox txtAddEmail = null!;
        private TextBox txtAddPassword = null!;
        private ComboBox cmbRole = null!;
        private Button btnAddEmployee = null!;
        private Label lblAddError = null!;
    }
}
