namespace Gym_Mngt_System
{
    partial class AddMachineFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMachineType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMachineStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateMachine = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New Machine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Machine Type*";
            // 
            // tbMachineType
            // 
            this.tbMachineType.AutoRoundedCorners = true;
            this.tbMachineType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMachineType.DefaultText = "";
            this.tbMachineType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMachineType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMachineType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMachineType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMachineType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbMachineType.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbMachineType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbMachineType.ForeColor = System.Drawing.Color.White;
            this.tbMachineType.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbMachineType.Location = new System.Drawing.Point(74, 157);
            this.tbMachineType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMachineType.Name = "tbMachineType";
            this.tbMachineType.PlaceholderText = "e.g., Treadmill, Elliptical";
            this.tbMachineType.SelectedText = "";
            this.tbMachineType.Size = new System.Drawing.Size(527, 44);
            this.tbMachineType.TabIndex = 19;
            this.tbMachineType.TextChanged += new System.EventHandler(this.tbMachineType_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Brand";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbBrand
            // 
            this.tbBrand.AutoRoundedCorners = true;
            this.tbBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBrand.DefaultText = "";
            this.tbBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbBrand.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbBrand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBrand.ForeColor = System.Drawing.Color.White;
            this.tbBrand.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbBrand.Location = new System.Drawing.Point(74, 254);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.PlaceholderText = "e.g., Life Fitness";
            this.tbBrand.SelectedText = "";
            this.tbBrand.Size = new System.Drawing.Size(527, 44);
            this.tbBrand.TabIndex = 21;
            this.tbBrand.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbModel
            // 
            this.tbModel.AutoRoundedCorners = true;
            this.tbModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbModel.DefaultText = "";
            this.tbModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbModel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbModel.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbModel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbModel.ForeColor = System.Drawing.Color.White;
            this.tbModel.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbModel.Location = new System.Drawing.Point(74, 354);
            this.tbModel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbModel.Name = "tbModel";
            this.tbModel.PlaceholderText = "e.g., T5";
            this.tbModel.SelectedText = "";
            this.tbModel.Size = new System.Drawing.Size(527, 44);
            this.tbModel.TabIndex = 23;
            this.tbModel.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 430);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status";
            // 
            // cbMachineStatus
            // 
            this.cbMachineStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbMachineStatus.BorderRadius = 20;
            this.cbMachineStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMachineStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachineStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbMachineStatus.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbMachineStatus.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbMachineStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbMachineStatus.ForeColor = System.Drawing.Color.White;
            this.cbMachineStatus.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbMachineStatus.ItemHeight = 38;
            this.cbMachineStatus.Items.AddRange(new object[] {
            "Operating",
            "Maintenance",
            "OutofService",
            "Broken"});
            this.cbMachineStatus.Location = new System.Drawing.Point(74, 457);
            this.cbMachineStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbMachineStatus.Name = "cbMachineStatus";
            this.cbMachineStatus.Size = new System.Drawing.Size(527, 44);
            this.cbMachineStatus.StartIndex = 1;
            this.cbMachineStatus.TabIndex = 26;
            this.cbMachineStatus.SelectedIndexChanged += new System.EventHandler(this.cbMachineStatus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(69, 530);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Location";
            // 
            // btnCreateMachine
            // 
            this.btnCreateMachine.AutoRoundedCorners = true;
            this.btnCreateMachine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateMachine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateMachine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateMachine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateMachine.FillColor = System.Drawing.Color.OrangeRed;
            this.btnCreateMachine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCreateMachine.ForeColor = System.Drawing.Color.White;
            this.btnCreateMachine.Image = global::Gym_Mngt_System.Properties.Resources.diskette;
            this.btnCreateMachine.Location = new System.Drawing.Point(379, 630);
            this.btnCreateMachine.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateMachine.Name = "btnCreateMachine";
            this.btnCreateMachine.Size = new System.Drawing.Size(222, 53);
            this.btnCreateMachine.TabIndex = 32;
            this.btnCreateMachine.Text = "Create Machine";
            this.btnCreateMachine.Click += new System.EventHandler(this.btnCreateMachine_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Gym_Mngt_System.Properties.Resources.plus__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(29, 28);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(34, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbLocation.BorderRadius = 20;
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbLocation.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbLocation.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbLocation.ForeColor = System.Drawing.Color.White;
            this.cbLocation.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbLocation.ItemHeight = 38;
            this.cbLocation.Items.AddRange(new object[] {
            "Strength Area",
            "Cardio Zone",
            "Free Weights",
            "Functional Area"});
            this.cbLocation.Location = new System.Drawing.Point(74, 557);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(524, 44);
            this.cbLocation.StartIndex = 1;
            this.cbLocation.TabIndex = 33;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(602, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 34;
            // 
            // AddMachineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(636, 703);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.btnCreateMachine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMachineStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMachineType);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddMachineFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMachineFrm";
            this.Load += new System.EventHandler(this.AddMachineFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbMachineType;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbBrand;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbModel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbMachineStatus;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnCreateMachine;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocation;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}