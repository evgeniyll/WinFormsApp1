namespace WinFormsApp1
{
    partial class AnalystForm
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
            panelTop    = new Panel();
            lblWelcome  = new Label();
            btnLogout   = new Button();
            panelTop2   = new Panel();
            lblChoose   = new Label();
            cmbReport   = new ComboBox();
            btnSave     = new Button();
            lblStatus   = new Label();
            dgvData     = new DataGridView();

            panelTop.SuspendLayout();
            panelTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            Name            = "AnalystForm";
            Text            = "TourismBlitz — Аналитик";
            ClientSize      = new Size(960, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox     = false;
            StartPosition   = FormStartPosition.CenterScreen;
            BackColor       = Color.FromArgb(245, 247, 250);

            // ── panelTop (шапка) ──────────────────────────────────
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

            btnLogout.Text                      = "⬅ Выйти";
            btnLogout.Font                      = new Font("Segoe UI", 9F);
            btnLogout.FlatStyle                 = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.ForeColor                 = Color.White;
            btnLogout.BackColor                 = Color.FromArgb(0, 80, 130);
            btnLogout.Size                      = new Size(90, 32);
            btnLogout.Location                  = new Point(854, 12);
            btnLogout.Cursor                    = Cursors.Hand;
            btnLogout.Click                    += btnLogout_Click;

            // ── panelTop2 (выбор отчёта + кнопка) ────────────────
            panelTop2.Location  = new Point(0, 56);
            panelTop2.Size      = new Size(960, 60);
            panelTop2.BackColor = Color.White;
            panelTop2.Controls.Add(lblChoose);
            panelTop2.Controls.Add(cmbReport);
            panelTop2.Controls.Add(btnSave);

            lblChoose.Text      = "Выберите отчёт:";
            lblChoose.Font      = new Font("Segoe UI", 10F);
            lblChoose.ForeColor = Color.FromArgb(60, 60, 60);
            lblChoose.AutoSize  = true;
            lblChoose.Location  = new Point(20, 18);

            cmbReport.Font          = new Font("Segoe UI", 10F);
            cmbReport.FlatStyle     = FlatStyle.Flat;
            cmbReport.BackColor     = Color.White;
            cmbReport.Size          = new Size(260, 30);
            cmbReport.Location      = new Point(140, 14);
            cmbReport.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReport.Items.AddRange(new object[]
            {
                "Прейскурант",
                "Объёмы услуг за месяц",
                "Статистика",
                "Сотрудники"
            });
            cmbReport.SelectedIndex         = -1;
            cmbReport.SelectedIndexChanged += cmbReport_SelectedIndexChanged;

            btnSave.Text                      = "💾  Сохранить";
            btnSave.Font                      = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor                 = Color.White;
            btnSave.FlatStyle                 = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor                 = Color.FromArgb(180, 180, 180);
            btnSave.Size                      = new Size(150, 36);
            btnSave.Location                  = new Point(420, 11);
            btnSave.Cursor                    = Cursors.Hand;
            btnSave.Enabled                   = false;
            btnSave.Click                    += btnSave_Click;

            // ── lblStatus ─────────────────────────────────────────
            lblStatus.Text      = "";
            lblStatus.Font      = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.FromArgb(0, 130, 100);
            lblStatus.AutoSize  = true;
            lblStatus.Location  = new Point(20, 124);
            lblStatus.Visible   = false;

            // ── dgvData ───────────────────────────────────────────
            dgvData.Location                                       = new Point(20, 140);
            dgvData.Size                                           = new Size(920, 440);
            dgvData.BackgroundColor                                = Color.White;
            dgvData.BorderStyle                                    = BorderStyle.None;
            dgvData.CellBorderStyle                                = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvData.ColumnHeadersBorderStyle                       = DataGridViewHeaderBorderStyle.None;
            dgvData.EnableHeadersVisualStyles                      = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor        = Color.FromArgb(0, 100, 160);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor        = Color.White;
            dgvData.ColumnHeadersDefaultCellStyle.Font             = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvData.ColumnHeadersHeight                            = 36;
            dgvData.DefaultCellStyle.Font                          = new Font("Segoe UI", 10F);
            dgvData.DefaultCellStyle.SelectionBackColor            = Color.FromArgb(200, 230, 255);
            dgvData.DefaultCellStyle.SelectionForeColor            = Color.FromArgb(30, 40, 55);
            dgvData.GridColor                                      = Color.FromArgb(220, 225, 235);
            dgvData.RowHeadersVisible                              = false;
            dgvData.SelectionMode                                  = DataGridViewSelectionMode.FullRowSelect;
            dgvData.AllowUserToAddRows                             = false;
            dgvData.AllowUserToDeleteRows                          = true;
            dgvData.AutoSizeColumnsMode                            = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly                                       = true;

            // ── Add to Form ───────────────────────────────────────
            Controls.Add(panelTop);
            Controls.Add(panelTop2);
            Controls.Add(lblStatus);
            Controls.Add(dgvData);

            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelTop2.ResumeLayout(false);
            panelTop2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop = null!;
        private Label lblWelcome = null!;
        private Button btnLogout = null!;
        private Panel panelTop2 = null!;
        private Label lblChoose = null!;
        private ComboBox cmbReport = null!;
        private Button btnSave = null!;
        private Label lblStatus = null!;
        private DataGridView dgvData = null!;
    }
}
