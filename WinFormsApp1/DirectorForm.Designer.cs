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
            panelTop        = new Panel();
            lblWelcome      = new Label();
            btnLogout       = new Button();
            panelSidebar    = new Panel();
            btnTabEmployees = new Button();
            btnTabAdd       = new Button();
            btnTabDelete    = new Button();
            btnTabReports   = new Button();
            panelContent    = new Panel();

            // Employees panel
            panelEmployees   = new Panel();
            lblEmployeesTitle = new Label();
            dgvEmployees     = new DataGridView();

            // Add panel
            panelAdd        = new Panel();
            lblAddTitle     = new Label();
            txtAddLogin     = new TextBox();
            txtAddEmail     = new TextBox();
            txtAddPassword  = new TextBox();
            cmbRole         = new ComboBox();
            btnAddEmployee  = new Button();
            lblAddError     = new Label();

            // Delete panel
            panelDelete        = new Panel();
            lblDeleteTitle     = new Label();
            lblDeleteHint      = new Label();
            txtDeleteLogin     = new TextBox();
            btnDeleteEmployee  = new Button();
            lblDeleteError     = new Label();

            // Reports panel
            panelReports    = new Panel();
            lblReportsTitle  = new Label();
            cmbReports      = new ComboBox();
            dgvReports      = new DataGridView();

            panelTop.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            panelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panelAdd.SuspendLayout();
            panelDelete.SuspendLayout();
            panelReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            Name            = "DirectorForm";
            Text            = "TourismBlitz — Панель управления";
            ClientSize      = new Size(960, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox     = false;
            StartPosition   = FormStartPosition.CenterScreen;
            BackColor       = Color.FromArgb(245, 247, 250);

            // ── panelTop ──────────────────────────────────────────
            panelTop.Dock      = DockStyle.Top;
            panelTop.Height    = 56;
            panelTop.BackColor = Color.FromArgb(0, 100, 160);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Controls.Add(btnLogout);

            lblWelcome.Text      = "";
            lblWelcome.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.AutoSize  = true;
            lblWelcome.Location  = new Point(16, 16);

            btnLogout.Text                         = "⬅ Выйти";
            btnLogout.Font                         = new Font("Segoe UI", 9F);
            btnLogout.FlatStyle                    = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize    = 0;
            btnLogout.ForeColor                    = Color.White;
            btnLogout.BackColor                    = Color.FromArgb(0, 80, 130);
            btnLogout.Size                         = new Size(90, 32);
            btnLogout.Location                     = new Point(854, 12);
            btnLogout.Cursor                       = Cursors.Hand;
            btnLogout.Click                       += btnLogout_Click;

            // ── panelSidebar ──────────────────────────────────────
            panelSidebar.Location  = new Point(0, 56);
            panelSidebar.Size      = new Size(190, 544);
            panelSidebar.BackColor = Color.FromArgb(30, 40, 55);
            panelSidebar.Controls.Add(btnTabEmployees);
            panelSidebar.Controls.Add(btnTabAdd);
            panelSidebar.Controls.Add(btnTabDelete);
            panelSidebar.Controls.Add(btnTabReports);

            Button[] tabs = { btnTabEmployees, btnTabAdd, btnTabDelete, btnTabReports };
            string[] tabTexts = { "👥  Сотрудники", "➕  Добавить", "🗑  Удалить", "📊  Отчёты" };
            EventHandler[] tabClicks = { btnTabEmployees_Click, btnTabAdd_Click, btnTabDelete_Click, btnTabReports_Click };

            for (int i = 0; i < tabs.Length; i++)
            {
                tabs[i].Text                      = tabTexts[i];
                tabs[i].Font                      = new Font("Segoe UI", 10F);
                tabs[i].FlatStyle                 = FlatStyle.Flat;
                tabs[i].FlatAppearance.BorderSize = 0;
                tabs[i].TextAlign                 = ContentAlignment.MiddleLeft;
                tabs[i].Padding                   = new Padding(16, 0, 0, 0);
                tabs[i].Size                      = new Size(190, 48);
                tabs[i].Location                  = new Point(0, 20 + i * 52);
                tabs[i].Cursor                    = Cursors.Hand;
                tabs[i].BackColor                 = Color.FromArgb(245, 245, 245);
                tabs[i].ForeColor                 = Color.FromArgb(60, 60, 60);
                tabs[i].Click                    += tabClicks[i];
            }
            btnTabEmployees.BackColor = Color.FromArgb(0, 150, 136);
            btnTabEmployees.ForeColor = Color.White;

            // ── panelContent ──────────────────────────────────────
            panelContent.Location  = new Point(190, 56);
            panelContent.Size      = new Size(770, 544);
            panelContent.BackColor = Color.FromArgb(245, 247, 250);
            panelContent.Controls.Add(panelEmployees);
            panelContent.Controls.Add(panelAdd);
            panelContent.Controls.Add(panelDelete);
            panelContent.Controls.Add(panelReports);

            // ── panelEmployees ────────────────────────────────────
            panelEmployees.Dock      = DockStyle.Fill;
            panelEmployees.BackColor = Color.Transparent;
            panelEmployees.Controls.Add(lblEmployeesTitle);
            panelEmployees.Controls.Add(dgvEmployees);
            panelEmployees.Visible   = true;

            lblEmployeesTitle.Text      = "Список сотрудников";
            lblEmployeesTitle.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEmployeesTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblEmployeesTitle.AutoSize  = true;
            lblEmployeesTitle.Location  = new Point(20, 20);

            dgvEmployees.Location                                       = new Point(20, 60);
            dgvEmployees.Size                                           = new Size(730, 460);
            dgvEmployees.BackgroundColor                                = Color.White;
            dgvEmployees.BorderStyle                                    = BorderStyle.None;
            dgvEmployees.CellBorderStyle                                = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ColumnHeadersBorderStyle                       = DataGridViewHeaderBorderStyle.None;
            dgvEmployees.EnableHeadersVisualStyles                      = false;
            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor        = Color.FromArgb(0, 100, 160);
            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor        = Color.White;
            dgvEmployees.ColumnHeadersDefaultCellStyle.Font             = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvEmployees.ColumnHeadersHeight                            = 36;
            dgvEmployees.DefaultCellStyle.Font                          = new Font("Segoe UI", 10F);
            dgvEmployees.DefaultCellStyle.SelectionBackColor            = Color.FromArgb(200, 230, 255);
            dgvEmployees.DefaultCellStyle.SelectionForeColor            = Color.FromArgb(30, 40, 55);
            dgvEmployees.GridColor                                      = Color.FromArgb(220, 225, 235);
            dgvEmployees.RowHeadersVisible                              = false;
            dgvEmployees.SelectionMode                                  = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect                                    = false;
            dgvEmployees.ReadOnly                                       = true;
            dgvEmployees.AllowUserToAddRows                             = false;
            dgvEmployees.AllowUserToDeleteRows                          = false;
            dgvEmployees.AutoSizeColumnsMode                            = DataGridViewAutoSizeColumnsMode.Fill;

            // ── panelAdd ──────────────────────────────────────────
            panelAdd.Dock      = DockStyle.Fill;
            panelAdd.BackColor = Color.Transparent;
            panelAdd.Controls.Add(lblAddTitle);
            panelAdd.Controls.Add(txtAddLogin);
            panelAdd.Controls.Add(txtAddEmail);
            panelAdd.Controls.Add(txtAddPassword);
            panelAdd.Controls.Add(cmbRole);
            panelAdd.Controls.Add(btnAddEmployee);
            panelAdd.Controls.Add(lblAddError);
            panelAdd.Visible = false;

            lblAddTitle.Text      = "Добавить сотрудника";
            lblAddTitle.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAddTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblAddTitle.AutoSize  = true;
            lblAddTitle.Location  = new Point(20, 20);

            txtAddLogin.Text        = "Логин";
            txtAddLogin.ForeColor   = Color.Silver;
            txtAddLogin.Font        = new Font("Segoe UI", 11F);
            txtAddLogin.BorderStyle = BorderStyle.FixedSingle;
            txtAddLogin.BackColor   = Color.White;
            txtAddLogin.Size        = new Size(340, 36);
            txtAddLogin.Location    = new Point(20, 70);
            txtAddLogin.Enter      += txtAddLogin_Enter;
            txtAddLogin.Leave      += txtAddLogin_Leave;

            txtAddEmail.Text        = "Email";
            txtAddEmail.ForeColor   = Color.Silver;
            txtAddEmail.Font        = new Font("Segoe UI", 11F);
            txtAddEmail.BorderStyle = BorderStyle.FixedSingle;
            txtAddEmail.BackColor   = Color.White;
            txtAddEmail.Size        = new Size(340, 36);
            txtAddEmail.Location    = new Point(20, 126);
            txtAddEmail.Enter      += txtAddEmail_Enter;
            txtAddEmail.Leave      += txtAddEmail_Leave;

            txtAddPassword.Text        = "Пароль";
            txtAddPassword.ForeColor   = Color.Silver;
            txtAddPassword.Font        = new Font("Segoe UI", 11F);
            txtAddPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAddPassword.BackColor   = Color.White;
            txtAddPassword.Size        = new Size(340, 36);
            txtAddPassword.Location    = new Point(20, 182);
            txtAddPassword.Enter      += txtAddPassword_Enter;
            txtAddPassword.Leave      += txtAddPassword_Leave;

            cmbRole.Font          = new Font("Segoe UI", 11F);
            cmbRole.FlatStyle     = FlatStyle.Flat;
            cmbRole.BackColor     = Color.White;
            cmbRole.Size          = new Size(340, 36);
            cmbRole.Location      = new Point(20, 238);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Директор", "Менеджер", "Аналитик" });
            cmbRole.SelectedIndex = -1;

            lblAddError.ForeColor = Color.Crimson;
            lblAddError.Font      = new Font("Segoe UI", 9F);
            lblAddError.AutoSize  = true;
            lblAddError.Location  = new Point(20, 284);
            lblAddError.Visible   = false;

            btnAddEmployee.Text                      = "Добавить сотрудника";
            btnAddEmployee.Font                      = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddEmployee.ForeColor                 = Color.White;
            btnAddEmployee.FlatStyle                 = FlatStyle.Flat;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.BackColor                 = Color.FromArgb(0, 150, 136);
            btnAddEmployee.Size                      = new Size(340, 44);
            btnAddEmployee.Location                  = new Point(20, 304);
            btnAddEmployee.Cursor                    = Cursors.Hand;
            btnAddEmployee.Click                    += btnAddEmployee_Click;

            // ── panelDelete ───────────────────────────────────────
            panelDelete.Dock      = DockStyle.Fill;
            panelDelete.BackColor = Color.Transparent;
            panelDelete.Controls.Add(lblDeleteTitle);
            panelDelete.Controls.Add(lblDeleteHint);
            panelDelete.Controls.Add(txtDeleteLogin);
            panelDelete.Controls.Add(btnDeleteEmployee);
            panelDelete.Controls.Add(lblDeleteError);
            panelDelete.Visible = false;

            lblDeleteTitle.Text      = "Удалить сотрудника";
            lblDeleteTitle.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDeleteTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblDeleteTitle.AutoSize  = true;
            lblDeleteTitle.Location  = new Point(20, 20);

            lblDeleteHint.Text      = "Введите логин сотрудника которого хотите удалить:";
            lblDeleteHint.Font      = new Font("Segoe UI", 10F);
            lblDeleteHint.ForeColor = Color.FromArgb(100, 100, 100);
            lblDeleteHint.AutoSize  = true;
            lblDeleteHint.Location  = new Point(20, 65);

            txtDeleteLogin.Text        = "Введите логин сотрудника";
            txtDeleteLogin.ForeColor   = Color.Silver;
            txtDeleteLogin.Font        = new Font("Segoe UI", 11F);
            txtDeleteLogin.BorderStyle = BorderStyle.FixedSingle;
            txtDeleteLogin.BackColor   = Color.White;
            txtDeleteLogin.Size        = new Size(340, 36);
            txtDeleteLogin.Location    = new Point(20, 95);
            txtDeleteLogin.Enter      += txtDeleteLogin_Enter;
            txtDeleteLogin.Leave      += txtDeleteLogin_Leave;

            lblDeleteError.ForeColor = Color.Crimson;
            lblDeleteError.Font      = new Font("Segoe UI", 9F);
            lblDeleteError.AutoSize  = true;
            lblDeleteError.Location  = new Point(20, 140);
            lblDeleteError.Visible   = false;

            btnDeleteEmployee.Text                      = "🗑  Удалить сотрудника";
            btnDeleteEmployee.Font                      = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteEmployee.ForeColor                 = Color.White;
            btnDeleteEmployee.FlatStyle                 = FlatStyle.Flat;
            btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            btnDeleteEmployee.BackColor                 = Color.FromArgb(200, 50, 50);
            btnDeleteEmployee.Size                      = new Size(340, 44);
            btnDeleteEmployee.Location                  = new Point(20, 160);
            btnDeleteEmployee.Cursor                    = Cursors.Hand;
            btnDeleteEmployee.Click                    += btnDeleteEmployee_Click;

            // ── panelReports ──────────────────────────────────────
            panelReports.Dock      = DockStyle.Fill;
            panelReports.BackColor = Color.Transparent;
            panelReports.Controls.Add(lblReportsTitle);
            panelReports.Controls.Add(cmbReports);
            panelReports.Controls.Add(dgvReports);
            panelReports.Visible = false;

            lblReportsTitle.Text      = "Отчёты";
            lblReportsTitle.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReportsTitle.ForeColor = Color.FromArgb(30, 40, 55);
            lblReportsTitle.AutoSize  = true;
            lblReportsTitle.Location  = new Point(20, 20);

            cmbReports.Font          = new Font("Segoe UI", 11F);
            cmbReports.FlatStyle     = FlatStyle.Flat;
            cmbReports.BackColor     = Color.White;
            cmbReports.Size          = new Size(340, 36);
            cmbReports.Location      = new Point(20, 60);
            cmbReports.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReports.Items.AddRange(new object[]
            {
                "Сотрудники",
                "Прейскурант",
                "Объёмы услуг за месяц",
                "Статистика"
            });
            cmbReports.SelectedIndex         = -1;
            cmbReports.SelectedIndexChanged += cmbReports_SelectedIndexChanged;

            dgvReports.Location                                       = new Point(20, 110);
            dgvReports.Size                                           = new Size(730, 410);
            dgvReports.BackgroundColor                                = Color.White;
            dgvReports.BorderStyle                                    = BorderStyle.None;
            dgvReports.CellBorderStyle                                = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReports.ColumnHeadersBorderStyle                       = DataGridViewHeaderBorderStyle.None;
            dgvReports.EnableHeadersVisualStyles                      = false;
            dgvReports.ColumnHeadersDefaultCellStyle.BackColor        = Color.FromArgb(0, 100, 160);
            dgvReports.ColumnHeadersDefaultCellStyle.ForeColor        = Color.White;
            dgvReports.ColumnHeadersDefaultCellStyle.Font             = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvReports.ColumnHeadersHeight                            = 36;
            dgvReports.DefaultCellStyle.Font                          = new Font("Segoe UI", 10F);
            dgvReports.DefaultCellStyle.SelectionBackColor            = Color.FromArgb(200, 230, 255);
            dgvReports.DefaultCellStyle.SelectionForeColor            = Color.FromArgb(30, 40, 55);
            dgvReports.GridColor                                      = Color.FromArgb(220, 225, 235);
            dgvReports.RowHeadersVisible                              = false;
            dgvReports.ReadOnly                                       = true;
            dgvReports.AllowUserToAddRows                             = false;
            dgvReports.AllowUserToDeleteRows                          = false;
            dgvReports.AutoSizeColumnsMode                            = DataGridViewAutoSizeColumnsMode.Fill;

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
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            panelReports.ResumeLayout(false);
            panelReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop = null!;
        private Label lblWelcome = null!;
        private Button btnLogout = null!;
        private Panel panelSidebar = null!;
        private Button btnTabEmployees = null!;
        private Button btnTabAdd = null!;
        private Button btnTabDelete = null!;
        private Button btnTabReports = null!;
        private Panel panelContent = null!;

        private Panel panelEmployees = null!;
        private Label lblEmployeesTitle = null!;
        private DataGridView dgvEmployees = null!;

        private Panel panelAdd = null!;
        private Label lblAddTitle = null!;
        private TextBox txtAddLogin = null!;
        private TextBox txtAddEmail = null!;
        private TextBox txtAddPassword = null!;
        private ComboBox cmbRole = null!;
        private Button btnAddEmployee = null!;
        private Label lblAddError = null!;

        private Panel panelDelete = null!;
        private Label lblDeleteTitle = null!;
        private Label lblDeleteHint = null!;
        private TextBox txtDeleteLogin = null!;
        private Button btnDeleteEmployee = null!;
        private Label lblDeleteError = null!;

        private Panel panelReports = null!;
        private Label lblReportsTitle = null!;
        private ComboBox cmbReports = null!;
        private DataGridView dgvReports = null!;
    }
}
