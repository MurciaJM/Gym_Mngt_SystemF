namespace Gym_Mngt_System
{
    partial class WelcomeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeFrm));
            this.frmLoader = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.labelLogs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlans = new System.Windows.Forms.Label();
            this.labelSession = new System.Windows.Forms.Label();
            this.labelSms = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrainors = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTrainer = new Guna.UI2.WinForms.Guna2Button();
            this.btnNotification = new Guna.UI2.WinForms.Guna2Button();
            this.btnElevate = new Guna.UI2.WinForms.Guna2Button();
            this.btnMemberLogs = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlans = new Guna.UI2.WinForms.Guna2Button();
            this.btnSession = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLoader
            // 
            this.frmLoader.Location = new System.Drawing.Point(206, 152);
            this.frmLoader.Margin = new System.Windows.Forms.Padding(2);
            this.frmLoader.Name = "frmLoader";
            this.frmLoader.Size = new System.Drawing.Size(1432, 802);
            this.frmLoader.TabIndex = 1;
            this.frmLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLoader_Paint);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbl1.Location = new System.Drawing.Point(216, 11);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(427, 68);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Welcome back!";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbl2.Location = new System.Drawing.Point(222, 79);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(471, 32);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Here\'s what happening at your gym today!";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(1294, 44);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(1296, 69);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // labelLogs
            // 
            this.labelLogs.AutoSize = true;
            this.labelLogs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLogs.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogs.ForeColor = System.Drawing.Color.Black;
            this.labelLogs.Location = new System.Drawing.Point(82, 235);
            this.labelLogs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogs.Name = "labelLogs";
            this.labelLogs.Size = new System.Drawing.Size(91, 15);
            this.labelLogs.TabIndex = 22;
            this.labelLogs.Text = "Member Logs";
            this.labelLogs.Visible = false;
            this.labelLogs.Click += new System.EventHandler(this.labelLogs_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnElevate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 155);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "-E  L  E  V  Λ  T  E -";
            // 
            // labelPlans
            // 
            this.labelPlans.AutoSize = true;
            this.labelPlans.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPlans.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlans.ForeColor = System.Drawing.Color.Black;
            this.labelPlans.Location = new System.Drawing.Point(92, 347);
            this.labelPlans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlans.Name = "labelPlans";
            this.labelPlans.Size = new System.Drawing.Size(84, 15);
            this.labelPlans.TabIndex = 26;
            this.labelPlans.Text = "Membership";
            this.labelPlans.Visible = false;
            this.labelPlans.Click += new System.EventHandler(this.labelPlans_Click);
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSession.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.ForeColor = System.Drawing.Color.Black;
            this.labelSession.Location = new System.Drawing.Point(103, 453);
            this.labelSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(53, 15);
            this.labelSession.TabIndex = 23;
            this.labelSession.Text = "Session";
            this.labelSession.Visible = false;
            this.labelSession.Click += new System.EventHandler(this.labelSession_Click);
            // 
            // labelSms
            // 
            this.labelSms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSms.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSms.ForeColor = System.Drawing.Color.Black;
            this.labelSms.Location = new System.Drawing.Point(94, 671);
            this.labelSms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSms.Name = "labelSms";
            this.labelSms.Size = new System.Drawing.Size(88, 16);
            this.labelSms.TabIndex = 29;
            this.labelSms.Text = "Notification";
            this.labelSms.Visible = false;
            this.labelSms.Click += new System.EventHandler(this.labelSms_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.lblCashierName);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.lblTrainors);
            this.guna2Panel1.Controls.Add(this.btnTrainer);
            this.guna2Panel1.Controls.Add(this.labelSms);
            this.guna2Panel1.Controls.Add(this.btnNotification);
            this.guna2Panel1.Controls.Add(this.labelSession);
            this.guna2Panel1.Controls.Add(this.labelPlans);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.labelLogs);
            this.guna2Panel1.Controls.Add(this.btnMemberLogs);
            this.guna2Panel1.Controls.Add(this.btnPlans);
            this.guna2Panel1.Controls.Add(this.btnSession);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(202, 959);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblTrainors
            // 
            this.lblTrainors.AutoSize = true;
            this.lblTrainors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTrainors.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainors.ForeColor = System.Drawing.Color.Black;
            this.lblTrainors.Location = new System.Drawing.Point(103, 563);
            this.lblTrainors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainors.Name = "lblTrainors";
            this.lblTrainors.Size = new System.Drawing.Size(57, 15);
            this.lblTrainors.TabIndex = 33;
            this.lblTrainors.Text = "Trainers";
            this.lblTrainors.Visible = false;
            this.lblTrainors.Click += new System.EventHandler(this.lblTrainors_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 858);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cashier";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2Separator2.Location = new System.Drawing.Point(3, 820);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(201, 10);
            this.guna2Separator2.TabIndex = 37;
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.White;
            this.lblCashierName.Location = new System.Drawing.Point(58, 838);
            this.lblCashierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(102, 20);
            this.lblCashierName.TabIndex = 34;
            this.lblCashierName.Text = "Cashier User";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2Separator1.Location = new System.Drawing.Point(1, 877);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(201, 10);
            this.guna2Separator1.TabIndex = 36;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Gym_Mngt_System.Properties.Resources.logout;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(0, 892);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.guna2Button1.Size = new System.Drawing.Size(202, 67);
            this.guna2Button1.TabIndex = 39;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Gym_Mngt_System.Properties.Resources.letter_c;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(8, 832);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 35;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrainer.BackgroundImage")));
            this.btnTrainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnTrainer.BorderRadius = 20;
            this.btnTrainer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrainer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrainer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrainer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnTrainer.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F);
            this.btnTrainer.ForeColor = System.Drawing.Color.Silver;
            this.btnTrainer.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrainer.Image = ((System.Drawing.Image)(resources.GetObject("btnTrainer.Image")));
            this.btnTrainer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrainer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTrainer.Location = new System.Drawing.Point(15, 537);
            this.btnTrainer.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.PressedColor = System.Drawing.Color.White;
            this.btnTrainer.Size = new System.Drawing.Size(221, 63);
            this.btnTrainer.TabIndex = 32;
            this.btnTrainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotification.BackgroundImage")));
            this.btnNotification.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnNotification.BorderRadius = 20;
            this.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F);
            this.btnNotification.ForeColor = System.Drawing.Color.Silver;
            this.btnNotification.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotification.Image = global::Gym_Mngt_System.Properties.Resources.active__2_;
            this.btnNotification.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNotification.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNotification.Location = new System.Drawing.Point(15, 646);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.PressedColor = System.Drawing.Color.White;
            this.btnNotification.Size = new System.Drawing.Size(223, 63);
            this.btnNotification.TabIndex = 28;
            this.btnNotification.Click += new System.EventHandler(this.btnSms_Click);
            // 
            // btnElevate
            // 
            this.btnElevate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnElevate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnElevate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnElevate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnElevate.FillColor = System.Drawing.Color.Empty;
            this.btnElevate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnElevate.ForeColor = System.Drawing.Color.White;
            this.btnElevate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnElevate.Image = global::Gym_Mngt_System.Properties.Resources.logo_elevate;
            this.btnElevate.ImageSize = new System.Drawing.Size(150, 150);
            this.btnElevate.Location = new System.Drawing.Point(41, 11);
            this.btnElevate.Name = "btnElevate";
            this.btnElevate.PressedColor = System.Drawing.Color.Empty;
            this.btnElevate.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnElevate.Size = new System.Drawing.Size(126, 110);
            this.btnElevate.TabIndex = 0;
            // 
            // btnMemberLogs
            // 
            this.btnMemberLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMemberLogs.BackgroundImage")));
            this.btnMemberLogs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnMemberLogs.BorderRadius = 20;
            this.btnMemberLogs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnMemberLogs.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F);
            this.btnMemberLogs.ForeColor = System.Drawing.Color.Silver;
            this.btnMemberLogs.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMemberLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberLogs.Image")));
            this.btnMemberLogs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMemberLogs.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMemberLogs.Location = new System.Drawing.Point(12, 210);
            this.btnMemberLogs.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberLogs.Name = "btnMemberLogs";
            this.btnMemberLogs.PressedColor = System.Drawing.Color.White;
            this.btnMemberLogs.Size = new System.Drawing.Size(224, 63);
            this.btnMemberLogs.TabIndex = 14;
            this.btnMemberLogs.Click += new System.EventHandler(this.btnCheck_ins_Click);
            // 
            // btnPlans
            // 
            this.btnPlans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlans.BackgroundImage")));
            this.btnPlans.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnPlans.BorderRadius = 20;
            this.btnPlans.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnPlans.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F);
            this.btnPlans.ForeColor = System.Drawing.Color.Silver;
            this.btnPlans.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlans.Image = ((System.Drawing.Image)(resources.GetObject("btnPlans.Image")));
            this.btnPlans.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlans.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPlans.Location = new System.Drawing.Point(15, 319);
            this.btnPlans.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlans.Name = "btnPlans";
            this.btnPlans.PressedColor = System.Drawing.Color.White;
            this.btnPlans.Size = new System.Drawing.Size(221, 63);
            this.btnPlans.TabIndex = 18;
            this.btnPlans.Click += new System.EventHandler(this.btnPlans_Click);
            // 
            // btnSession
            // 
            this.btnSession.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSession.BackgroundImage")));
            this.btnSession.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnSession.BorderRadius = 20;
            this.btnSession.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnSession.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F);
            this.btnSession.ForeColor = System.Drawing.Color.Silver;
            this.btnSession.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSession.Image = global::Gym_Mngt_System.Properties.Resources.calendar__1_;
            this.btnSession.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSession.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSession.Location = new System.Drawing.Point(15, 428);
            this.btnSession.Margin = new System.Windows.Forms.Padding(2);
            this.btnSession.Name = "btnSession";
            this.btnSession.PressedColor = System.Drawing.Color.White;
            this.btnSession.Size = new System.Drawing.Size(221, 63);
            this.btnSession.TabIndex = 15;
            this.btnSession.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // WelcomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1642, 959);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.frmLoader);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeFrm";
            this.Load += new System.EventHandler(this.WelcomeFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label labelLogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPlans;
        private Guna.UI2.WinForms.Guna2Button btnPlans;
        private Guna.UI2.WinForms.Guna2Button btnMemberLogs;
        private System.Windows.Forms.Label labelSession;
        private Guna.UI2.WinForms.Guna2Button btnSession;
        private Guna.UI2.WinForms.Guna2Button btnNotification;
        private System.Windows.Forms.Label labelSms;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Timer timer2;
        public Guna.UI2.WinForms.Guna2Panel frmLoader;
        private System.Windows.Forms.Label lblTrainors;
        private Guna.UI2.WinForms.Guna2Button btnTrainer;
        private Guna.UI2.WinForms.Guna2Button btnElevate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label lblCashierName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}