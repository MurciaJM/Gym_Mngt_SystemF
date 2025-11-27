namespace Gym_Mngt_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
   /*     protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_signIn = new System.Windows.Forms.Panel();
            this.BtnSignout = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnElevate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.modalEffectTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_signIn.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_signIn
            // 
            this.panel_signIn.BackColor = System.Drawing.Color.Transparent;
            this.panel_signIn.Controls.Add(this.BtnSignout);
            this.panel_signIn.Controls.Add(this.BtnLogin);
            this.panel_signIn.Controls.Add(this.label);
            this.panel_signIn.Controls.Add(this.label10);
            this.panel_signIn.Controls.Add(this.TbPassword);
            this.panel_signIn.Controls.Add(this.TbUsername);
            this.panel_signIn.Location = new System.Drawing.Point(2, 146);
            this.panel_signIn.Margin = new System.Windows.Forms.Padding(2);
            this.panel_signIn.Name = "panel_signIn";
            this.panel_signIn.Size = new System.Drawing.Size(438, 429);
            this.panel_signIn.TabIndex = 17;
            this.panel_signIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_signIn_Paint);
            // 
            // BtnSignout
            // 
            this.BtnSignout.AutoRoundedCorners = true;
            this.BtnSignout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSignout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSignout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSignout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSignout.FillColor = System.Drawing.Color.Empty;
            this.BtnSignout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnSignout.ForeColor = System.Drawing.Color.White;
            this.BtnSignout.HoverState.BorderColor = System.Drawing.Color.White;
            this.BtnSignout.Location = new System.Drawing.Point(33, 311);
            this.BtnSignout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSignout.Name = "BtnSignout";
            this.BtnSignout.Size = new System.Drawing.Size(377, 47);
            this.BtnSignout.TabIndex = 60;
            this.BtnSignout.Text = "Sign out";
            this.BtnSignout.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoRoundedCorners = true;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(34, 238);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(377, 47);
            this.BtnLogin.TabIndex = 59;
            this.BtnLogin.Text = "Sign in";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(30, 14);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 21);
            this.label.TabIndex = 13;
            this.label.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(37, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Password";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.Animated = true;
            this.TbPassword.AutoRoundedCorners = true;
            this.TbPassword.BorderColor = System.Drawing.Color.White;
            this.TbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPassword.DefaultText = "";
            this.TbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TbPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.ForeColor = System.Drawing.Color.White;
            this.TbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TbPassword.IconLeft = global::Gym_Mngt_System.Properties.Resources.password__1_;
            this.TbPassword.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TbPassword.Location = new System.Drawing.Point(37, 129);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '●';
            this.TbPassword.PlaceholderText = "";
            this.TbPassword.SelectedText = "";
            this.TbPassword.Size = new System.Drawing.Size(379, 45);
            this.TbPassword.TabIndex = 10;
            // 
            // TbUsername
            // 
            this.TbUsername.Animated = true;
            this.TbUsername.AutoRoundedCorners = true;
            this.TbUsername.BorderColor = System.Drawing.Color.White;
            this.TbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbUsername.DefaultText = "";
            this.TbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.TbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TbUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.ForeColor = System.Drawing.Color.White;
            this.TbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TbUsername.IconLeft = global::Gym_Mngt_System.Properties.Resources.user__2_1;
            this.TbUsername.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.TbUsername.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TbUsername.Location = new System.Drawing.Point(33, 36);
            this.TbUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.PlaceholderText = "";
            this.TbUsername.SelectedText = "";
            this.TbUsername.Size = new System.Drawing.Size(379, 45);
            this.TbUsername.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(98, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sign to your account or create a new one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Controls.Add(this.btnElevate);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(567, 783);
            this.guna2GradientPanel1.TabIndex = 18;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "E L E V Λ T E ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gym Management System";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2GradientPanel2.BorderRadius = 15;
            this.guna2GradientPanel2.BorderThickness = 1;
            this.guna2GradientPanel2.Controls.Add(this.panel_signIn);
            this.guna2GradientPanel2.Controls.Add(this.label3);
            this.guna2GradientPanel2.Controls.Add(this.label4);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(55, 163);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(453, 587);
            this.guna2GradientPanel2.TabIndex = 18;
            // 
            // btnElevate
            // 
            this.btnElevate.BackColor = System.Drawing.Color.Transparent;
            this.btnElevate.BorderColor = System.Drawing.Color.Empty;
            this.btnElevate.BorderRadius = 10;
            this.btnElevate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnElevate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnElevate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnElevate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnElevate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnElevate.FillColor = System.Drawing.Color.Empty;
            this.btnElevate.FillColor2 = System.Drawing.Color.Empty;
            this.btnElevate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnElevate.ForeColor = System.Drawing.Color.White;
            this.btnElevate.Image = global::Gym_Mngt_System.Properties.Resources.logo_elevate;
            this.btnElevate.ImageSize = new System.Drawing.Size(80, 80);
            this.btnElevate.Location = new System.Drawing.Point(257, 0);
            this.btnElevate.Margin = new System.Windows.Forms.Padding(2);
            this.btnElevate.Name = "btnElevate";
            this.btnElevate.PressedColor = System.Drawing.Color.Empty;
            this.btnElevate.Size = new System.Drawing.Size(57, 92);
            this.btnElevate.TabIndex = 1;
            // 
            // modalEffectTimer
            // 
            this.modalEffectTimer.Enabled = true;
            this.modalEffectTimer.Interval = 1;
            this.modalEffectTimer.Tick += new System.EventHandler(this.modalEffectTimer_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(567, 783);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_signIn.ResumeLayout(false);
            this.panel_signIn.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_signIn;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox TbPassword;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2TextBox TbUsername;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnElevate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer modalEffectTimer;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2Button BtnSignout;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
    }
}

