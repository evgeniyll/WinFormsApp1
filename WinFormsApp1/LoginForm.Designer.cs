namespace WinFormsApp1
{
    partial class LoginForm
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
            panelLeft = new Panel();
            lblCompanyName = new Label();
            lblCompanyTagline = new Label();
            panelRight = new Panel();
            lblLoginTab = new Label();
            lblLogin = new Label();
            lblSignUp = new Label();
            lblUnderline = new Label();
            btnClose = new Button();

            // Login panel
            panelLogin = new Panel();
            txtLoginUsername = new TextBox();
            txtLoginPassword = new TextBox();
            btnEnterLogin = new Button();
            lblLoginError = new Label();

            // Register panel
            panelRegister = new Panel();
            txtRegLogin = new TextBox();
            txtRegEmail = new TextBox();
            txtRegPassword = new TextBox();
            btnEnterRegister = new Button();
            lblRegError = new Label();

            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            panelLogin.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            Name = "LoginForm";
            Text = "TourismBlitz";
            ClientSize = new Size(700, 420);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            // ── panelLeft ─────────────────────────────────────────
            panelLeft.Location = new Point(0, 0);
            panelLeft.Size = new Size(280, 420);
            panelLeft.BackColor = Color.FromArgb(80, 40, 120);
            panelLeft.Controls.Add(lblCompanyName);
            panelLeft.Controls.Add(lblCompanyTagline);

            // градиент через Paint
            panelLeft.Paint += (s, e) =>
            {
                using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    panelLeft.ClientRectangle,
                    Color.FromArgb(60, 20, 100),
                    Color.FromArgb(120, 60, 180),
                    System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRectangle(brush, panelLeft.ClientRectangle);
            };

            // ── lblCompanyName ────────────────────────────────────
            lblCompanyName.Text = "TourismBlitz";
            lblCompanyName.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCompanyName.ForeColor = Color.White;
            lblCompanyName.AutoSize = false;
            lblCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            lblCompanyName.Size = new Size(280, 50);
            lblCompanyName.Location = new Point(0, 160);

            // ── lblCompanyTagline ─────────────────────────────────
            lblCompanyTagline.Text = "Ваш надёжный\nтуристический партнёр";
            lblCompanyTagline.Font = new Font("Segoe UI", 10F);
            lblCompanyTagline.ForeColor = Color.FromArgb(200, 200, 220);
            lblCompanyTagline.AutoSize = false;
            lblCompanyTagline.TextAlign = ContentAlignment.MiddleCenter;
            lblCompanyTagline.Size = new Size(280, 60);
            lblCompanyTagline.Location = new Point(0, 215);

            // ── panelRight ────────────────────────────────────────
            panelRight.Location = new Point(280, 0);
            panelRight.Size = new Size(420, 420);
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblLogin);
            panelRight.Controls.Add(lblSignUp);
            panelRight.Controls.Add(lblUnderline);
            panelRight.Controls.Add(btnClose);
            panelRight.Controls.Add(panelLogin);
            panelRight.Controls.Add(panelRegister);

            // ── lblLogin (tab) ────────────────────────────────────
            lblLogin.Text = "Log In";
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(150, 80, 200);
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(60, 35);
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Click += lblLogin_Click;

            // ── lblSignUp (tab) ───────────────────────────────────
            lblSignUp.Text = "Sign Up";
            lblSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblSignUp.ForeColor = Color.FromArgb(150, 80, 200);
            lblSignUp.AutoSize = true;
            lblSignUp.Location = new Point(140, 35);
            lblSignUp.Cursor = Cursors.Hand;
            lblSignUp.Click += lblSignUp_Click;

            // ── lblUnderline ──────────────────────────────────────
            lblUnderline.BackColor = Color.FromArgb(150, 80, 200);
            lblUnderline.Size = new Size(lblLogin.Width, 2);
            lblUnderline.Location = new Point(lblLogin.Left, 58);

            // ── btnClose ──────────────────────────────────────────
            btnClose.Text = "✕";
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.ForeColor = Color.Gray;
            btnClose.BackColor = Color.Transparent;
            btnClose.Size = new Size(30, 30);
            btnClose.Location = new Point(378, 10);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Click += btnClose_Click;

            // ── panelLogin ────────────────────────────────────────
            panelLogin.Location = new Point(0, 80);
            panelLogin.Size = new Size(420, 340);
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(txtLoginUsername);
            panelLogin.Controls.Add(txtLoginPassword);
            panelLogin.Controls.Add(btnEnterLogin);
            panelLogin.Controls.Add(lblLoginError);
            panelLogin.Visible = true;

            // txtLoginUsername
            txtLoginUsername.Text = "Username";
            txtLoginUsername.ForeColor = Color.Silver;
            txtLoginUsername.Font = new Font("Segoe UI", 11F);
            txtLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtLoginUsername.BackColor = Color.FromArgb(245, 245, 250);
            txtLoginUsername.Size = new Size(300, 36);
            txtLoginUsername.Location = new Point(60, 40);
            txtLoginUsername.Enter += txtLoginUsername_Enter;
            txtLoginUsername.Leave += txtLoginUsername_Leave;

            // txtLoginPassword
            txtLoginPassword.Text = "Password (A-Z,a-z,0-9)";
            txtLoginPassword.ForeColor = Color.Silver;
            txtLoginPassword.Font = new Font("Segoe UI", 11F);
            txtLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPassword.BackColor = Color.FromArgb(245, 245, 250);
            txtLoginPassword.Size = new Size(300, 36);
            txtLoginPassword.Location = new Point(60, 100);
            txtLoginPassword.Enter += txtLoginPassword_Enter;
            txtLoginPassword.Leave += txtLoginPassword_Leave;

            // lblLoginError
            lblLoginError.ForeColor = Color.Crimson;
            lblLoginError.Font = new Font("Segoe UI", 9F);
            lblLoginError.AutoSize = true;
            lblLoginError.Location = new Point(60, 148);
            lblLoginError.Visible = false;

            // btnEnterLogin
            btnEnterLogin.Text = "ENTER";
            btnEnterLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEnterLogin.ForeColor = Color.White;
            btnEnterLogin.FlatStyle = FlatStyle.Flat;
            btnEnterLogin.FlatAppearance.BorderSize = 0;
            btnEnterLogin.Size = new Size(300, 44);
            btnEnterLogin.Location = new Point(60, 170);
            btnEnterLogin.Cursor = Cursors.Hand;
            btnEnterLogin.Click += btnEnterLogin_Click;
            btnEnterLogin.Paint += BtnGradient_Paint;

            // ── panelRegister ─────────────────────────────────────
            panelRegister.Location = new Point(0, 80);
            panelRegister.Size = new Size(420, 340);
            panelRegister.BackColor = Color.Transparent;
            panelRegister.Controls.Add(txtRegLogin);
            panelRegister.Controls.Add(txtRegEmail);
            panelRegister.Controls.Add(txtRegPassword);
            panelRegister.Controls.Add(btnEnterRegister);
            panelRegister.Controls.Add(lblRegError);
            panelRegister.Visible = false;

            // txtRegLogin
            txtRegLogin.Text = "Username";
            txtRegLogin.ForeColor = Color.Silver;
            txtRegLogin.Font = new Font("Segoe UI", 11F);
            txtRegLogin.BorderStyle = BorderStyle.FixedSingle;
            txtRegLogin.BackColor = Color.FromArgb(245, 245, 250);
            txtRegLogin.Size = new Size(300, 36);
            txtRegLogin.Location = new Point(60, 20);
            txtRegLogin.Enter += txtRegLogin_Enter;
            txtRegLogin.Leave += txtRegLogin_Leave;

            // txtRegEmail
            txtRegEmail.Text = "Email";
            txtRegEmail.ForeColor = Color.Silver;
            txtRegEmail.Font = new Font("Segoe UI", 11F);
            txtRegEmail.BorderStyle = BorderStyle.FixedSingle;
            txtRegEmail.BackColor = Color.FromArgb(245, 245, 250);
            txtRegEmail.Size = new Size(300, 36);
            txtRegEmail.Location = new Point(60, 76);
            txtRegEmail.Enter += txtRegEmail_Enter;
            txtRegEmail.Leave += txtRegEmail_Leave;

            // txtRegPassword
            txtRegPassword.Text = "Password (A-Z,a-z,0-9)";
            txtRegPassword.ForeColor = Color.Silver;
            txtRegPassword.Font = new Font("Segoe UI", 11F);
            txtRegPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRegPassword.BackColor = Color.FromArgb(245, 245, 250);
            txtRegPassword.Size = new Size(300, 36);
            txtRegPassword.Location = new Point(60, 132);
            txtRegPassword.Enter += txtRegPassword_Enter;
            txtRegPassword.Leave += txtRegPassword_Leave;

            // lblRegError
            lblRegError.ForeColor = Color.Crimson;
            lblRegError.Font = new Font("Segoe UI", 9F);
            lblRegError.AutoSize = true;
            lblRegError.Location = new Point(60, 178);
            lblRegError.Visible = false;

            // btnEnterRegister
            btnEnterRegister.Text = "ENTER";
            btnEnterRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEnterRegister.ForeColor = Color.White;
            btnEnterRegister.FlatStyle = FlatStyle.Flat;
            btnEnterRegister.FlatAppearance.BorderSize = 0;
            btnEnterRegister.Size = new Size(300, 44);
            btnEnterRegister.Location = new Point(60, 196);
            btnEnterRegister.Cursor = Cursors.Hand;
            btnEnterRegister.Click += btnEnterRegister_Click;
            btnEnterRegister.Paint += BtnGradient_Paint;

            // ── Add to Form ───────────────────────────────────────
            Controls.Add(panelLeft);
            Controls.Add(panelRight);

            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnGradient_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Button btn) return;
            using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                btn.ClientRectangle,
                Color.FromArgb(120, 60, 200),
                Color.FromArgb(200, 80, 180),
                System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, btn.ClientRectangle);
            var text = btn.Text;
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(text, btn.Font, Brushes.White, btn.ClientRectangle, sf);
        }

        #endregion

        private Panel panelLeft = null!;
        private Label lblCompanyName = null!;
        private Label lblCompanyTagline = null!;
        private Panel panelRight = null!;
        private Label lblLoginTab = null!;
        private Label lblLogin = null!;
        private Label lblSignUp = null!;
        private Label lblUnderline = null!;
        private Button btnClose = null!;

        private Panel panelLogin = null!;
        private TextBox txtLoginUsername = null!;
        private TextBox txtLoginPassword = null!;
        private Button btnEnterLogin = null!;
        private Label lblLoginError = null!;

        private Panel panelRegister = null!;
        private TextBox txtRegLogin = null!;
        private TextBox txtRegEmail = null!;
        private TextBox txtRegPassword = null!;
        private Button btnEnterRegister = null!;
        private Label lblRegError = null!;
    }
}
