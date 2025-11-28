namespace Gym_Mngt_System.Staffs
{
    partial class EditStaff
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
            this.cbPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStaffid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rbFemale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbMale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStaffDetails = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblUploadImage = new System.Windows.Forms.Label();
            this.btnUploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cbDays = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTimeOut = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTimeIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.tbMiddle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.tbLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.Transparent;
            this.cbPosition.BorderRadius = 19;
            this.cbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbPosition.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbPosition.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbPosition.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.ForeColor = System.Drawing.Color.White;
            this.cbPosition.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbPosition.ItemHeight = 38;
            this.cbPosition.Items.AddRange(new object[] {
            "Basic - ₱500 / 15 days",
            "Premium - ₱1,000 / 30 days",
            "Gold - ₱1,500 / 45 days",
            "Elite - ₱2,000 / 60 days"});
            this.cbPosition.Location = new System.Drawing.Point(297, 686);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(615, 44);
            this.cbPosition.TabIndex = 119;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderRadius = 19;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbStatus.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbStatus.ItemHeight = 38;
            this.cbStatus.Items.AddRange(new object[] {
            "Basic - ₱500 / 15 days",
            "Premium - ₱1,000 / 30 days",
            "Gold - ₱1,500 / 45 days",
            "Elite - ₱2,000 / 60 days"});
            this.cbStatus.Location = new System.Drawing.Point(297, 775);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(615, 44);
            this.cbStatus.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 117;
            this.label4.Text = "Gender:";
            // 
            // lblStaffid
            // 
            this.lblStaffid.AutoSize = true;
            this.lblStaffid.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffid.ForeColor = System.Drawing.Color.White;
            this.lblStaffid.Location = new System.Drawing.Point(291, 178);
            this.lblStaffid.Name = "lblStaffid";
            this.lblStaffid.Size = new System.Drawing.Size(73, 28);
            this.lblStaffid.TabIndex = 116;
            this.lblStaffid.Text = "staffId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(96, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 32);
            this.label9.TabIndex = 115;
            this.label9.Text = "Birth Date:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Animated = true;
            this.dtpBirthdate.AutoRoundedCorners = true;
            this.dtpBirthdate.BorderColor = System.Drawing.Color.White;
            this.dtpBirthdate.Checked = true;
            this.dtpBirthdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.dtpBirthdate.FocusedColor = System.Drawing.Color.OrangeRed;
            this.dtpBirthdate.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.ForeColor = System.Drawing.Color.White;
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthdate.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.dtpBirthdate.Location = new System.Drawing.Point(296, 526);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(616, 54);
            this.dtpBirthdate.TabIndex = 114;
            this.dtpBirthdate.Value = new System.DateTime(2025, 10, 5, 20, 7, 8, 156);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(447, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 28);
            this.label8.TabIndex = 113;
            this.label8.Text = "Female";
            // 
            // rbFemale
            // 
            this.rbFemale.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(532, 622);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(27, 25);
            this.rbFemale.TabIndex = 112;
            this.rbFemale.Text = "guna2CustomRadioButton1";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(310, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 111;
            this.label5.Text = "Male";
            // 
            // tbFname
            // 
            this.tbFname.AutoRoundedCorners = true;
            this.tbFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFname.DefaultText = "";
            this.tbFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbFname.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbFname.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFname.ForeColor = System.Drawing.Color.White;
            this.tbFname.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbFname.Location = new System.Drawing.Point(291, 258);
            this.tbFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFname.Name = "tbFname";
            this.tbFname.PlaceholderText = "";
            this.tbFname.SelectedText = "";
            this.tbFname.Size = new System.Drawing.Size(411, 54);
            this.tbFname.TabIndex = 110;
            // 
            // rbMale
            // 
            this.rbMale.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(374, 622);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(27, 25);
            this.rbMale.TabIndex = 109;
            this.rbMale.Text = "guna2CustomRadioButton1";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(121, 710);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 107;
            this.label6.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 106;
            this.label1.Text = "Staff Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 798);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 105;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 104;
            this.label2.Text = "First name:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblStaffDetails);
            this.guna2Panel1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Panel1.Location = new System.Drawing.Point(41, 44);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(891, 71);
            this.guna2Panel1.TabIndex = 103;
            // 
            // lblStaffDetails
            // 
            this.lblStaffDetails.AutoSize = true;
            this.lblStaffDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStaffDetails.Font = new System.Drawing.Font("Segoe UI Variable Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblStaffDetails.ForeColor = System.Drawing.Color.White;
            this.lblStaffDetails.Location = new System.Drawing.Point(357, 16);
            this.lblStaffDetails.Name = "lblStaffDetails";
            this.lblStaffDetails.Size = new System.Drawing.Size(166, 46);
            this.lblStaffDetails.TabIndex = 25;
            this.lblStaffDetails.Text = "Edit Staff";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(899, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 120;
            // 
            // lblUploadImage
            // 
            this.lblUploadImage.AutoSize = true;
            this.lblUploadImage.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.lblUploadImage.ForeColor = System.Drawing.Color.White;
            this.lblUploadImage.Location = new System.Drawing.Point(843, 305);
            this.lblUploadImage.Name = "lblUploadImage";
            this.lblUploadImage.Size = new System.Drawing.Size(101, 25);
            this.lblUploadImage.TabIndex = 123;
            this.lblUploadImage.Text = "Edit Image";
            this.lblUploadImage.Visible = false;
            this.lblUploadImage.Click += new System.EventHandler(this.lblUploadImage_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadImage.BorderColor = System.Drawing.Color.Empty;
            this.btnUploadImage.BorderRadius = 15;
            this.btnUploadImage.BorderThickness = 1;
            this.btnUploadImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadImage.FillColor = System.Drawing.Color.OrangeRed;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Image = global::Gym_Mngt_System.Properties.Resources.plus__1_1;
            this.btnUploadImage.Location = new System.Drawing.Point(848, 275);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(27, 26);
            this.btnUploadImage.TabIndex = 122;
            this.btnUploadImage.UseTransparentBackground = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::Gym_Mngt_System.Properties.Resources.webcam_toy_photo41;
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(732, 139);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.BorderRadius = 0;
            this.pictureBox.ShadowDecoration.Depth = 35;
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.Size = new System.Drawing.Size(174, 162);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 121;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.OrangeRed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Gym_Mngt_System.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageOffset = new System.Drawing.Point(50, 0);
            this.btnSave.Location = new System.Drawing.Point(616, 955);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(296, 65);
            this.btnSave.TabIndex = 108;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbDays
            // 
            this.cbDays.BackColor = System.Drawing.Color.Transparent;
            this.cbDays.BorderRadius = 19;
            this.cbDays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDays.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbDays.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbDays.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbDays.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbDays.ForeColor = System.Drawing.Color.White;
            this.cbDays.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbDays.ItemHeight = 45;
            this.cbDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbDays.Location = new System.Drawing.Point(58, 885);
            this.cbDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDays.Name = "cbDays";
            this.cbDays.Size = new System.Drawing.Size(219, 51);
            this.cbDays.TabIndex = 130;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(853, 887);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 37);
            this.label13.TabIndex = 124;
            this.label13.Text = "PM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(520, 889);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 37);
            this.label12.TabIndex = 125;
            this.label12.Text = "AM  to";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(290, 835);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 37);
            this.label11.TabIndex = 126;
            this.label11.Text = "Time schedule";
            // 
            // tbTimeOut
            // 
            this.tbTimeOut.AutoRoundedCorners = true;
            this.tbTimeOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.tbTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimeOut.DefaultText = "";
            this.tbTimeOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimeOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimeOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimeOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimeOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbTimeOut.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbTimeOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimeOut.ForeColor = System.Drawing.Color.Black;
            this.tbTimeOut.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbTimeOut.Location = new System.Drawing.Point(630, 874);
            this.tbTimeOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTimeOut.Name = "tbTimeOut";
            this.tbTimeOut.PlaceholderText = "Time out.";
            this.tbTimeOut.SelectedText = "";
            this.tbTimeOut.Size = new System.Drawing.Size(217, 62);
            this.tbTimeOut.TabIndex = 128;
            // 
            // tbTimeIn
            // 
            this.tbTimeIn.AutoRoundedCorners = true;
            this.tbTimeIn.BackColor = System.Drawing.Color.Transparent;
            this.tbTimeIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.tbTimeIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimeIn.DefaultText = "";
            this.tbTimeIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimeIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimeIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimeIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimeIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbTimeIn.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbTimeIn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTimeIn.ForeColor = System.Drawing.Color.Black;
            this.tbTimeIn.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbTimeIn.Location = new System.Drawing.Point(297, 876);
            this.tbTimeIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTimeIn.Name = "tbTimeIn";
            this.tbTimeIn.PlaceholderText = "Time in.";
            this.tbTimeIn.SelectedText = "";
            this.tbTimeIn.Size = new System.Drawing.Size(217, 62);
            this.tbTimeIn.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(51, 846);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 37);
            this.label7.TabIndex = 127;
            this.label7.Text = "Day schedule";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMiddle.ForeColor = System.Drawing.Color.White;
            this.lblMiddle.Location = new System.Drawing.Point(51, 352);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(173, 32);
            this.lblMiddle.TabIndex = 104;
            this.lblMiddle.Text = "Middle name:";
            // 
            // tbMiddle
            // 
            this.tbMiddle.AutoRoundedCorners = true;
            this.tbMiddle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMiddle.DefaultText = "";
            this.tbMiddle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMiddle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMiddle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMiddle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMiddle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbMiddle.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbMiddle.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddle.ForeColor = System.Drawing.Color.White;
            this.tbMiddle.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbMiddle.Location = new System.Drawing.Point(291, 341);
            this.tbMiddle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.PlaceholderText = "";
            this.tbMiddle.SelectedText = "";
            this.tbMiddle.Size = new System.Drawing.Size(411, 54);
            this.tbMiddle.TabIndex = 110;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLname.ForeColor = System.Drawing.Color.White;
            this.lblLname.Location = new System.Drawing.Point(87, 443);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(137, 32);
            this.lblLname.TabIndex = 104;
            this.lblLname.Text = "Last name:";
            // 
            // tbLname
            // 
            this.tbLname.AutoRoundedCorners = true;
            this.tbLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLname.DefaultText = "";
            this.tbLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbLname.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbLname.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLname.ForeColor = System.Drawing.Color.White;
            this.tbLname.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbLname.Location = new System.Drawing.Point(291, 432);
            this.tbLname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLname.Name = "tbLname";
            this.tbLname.PlaceholderText = "";
            this.tbLname.SelectedText = "";
            this.tbLname.Size = new System.Drawing.Size(411, 54);
            this.tbLname.TabIndex = 110;
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(947, 1045);
            this.Controls.Add(this.cbDays);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTimeOut);
            this.Controls.Add(this.tbTimeIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUploadImage);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStaffid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbMiddle);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStaff";
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbPosition;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStaffid;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbFemale;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbFname;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbMale;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblStaffDetails;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblUploadImage;
        private Guna.UI2.WinForms.Guna2Button btnUploadImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2ComboBox cbDays;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox tbTimeOut;
        private Guna.UI2.WinForms.Guna2TextBox tbTimeIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMiddle;
        private Guna.UI2.WinForms.Guna2TextBox tbMiddle;
        private System.Windows.Forms.Label lblLname;
        private Guna.UI2.WinForms.Guna2TextBox tbLname;
    }
}