namespace Gym_Mngt_System
{
    partial class AddPaymentFrm
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbAmountPaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStaff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblmemberName = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Gym_Mngt_System.Properties.Resources.plus__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(68, 9);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(69, 60);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Membership plan:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount to pay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payment Method:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Staff-in-charge:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.ForeColor = System.Drawing.Color.White;
            this.lblPlan.Location = new System.Drawing.Point(411, 231);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(24, 27);
            this.lblPlan.TabIndex = 11;
            this.lblPlan.Text = "...";
            this.lblPlan.Click += new System.EventHandler(this.lblPlan_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(411, 373);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(24, 27);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "...";
            this.lblAmount.Click += new System.EventHandler(this.lblAmountDue_Click);
            // 
            // tbAmountPaid
            // 
            this.tbAmountPaid.AutoRoundedCorners = true;
            this.tbAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmountPaid.DefaultText = "";
            this.tbAmountPaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAmountPaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAmountPaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmountPaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmountPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbAmountPaid.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAmountPaid.ForeColor = System.Drawing.Color.White;
            this.tbAmountPaid.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbAmountPaid.Location = new System.Drawing.Point(416, 450);
            this.tbAmountPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAmountPaid.Name = "tbAmountPaid";
            this.tbAmountPaid.PlaceholderText = "";
            this.tbAmountPaid.SelectedText = "";
            this.tbAmountPaid.Size = new System.Drawing.Size(329, 54);
            this.tbAmountPaid.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(192, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cbPaymentMethod.BorderRadius = 19;
            this.cbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbPaymentMethod.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbPaymentMethod.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.cbPaymentMethod.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbPaymentMethod.ItemHeight = 38;
            this.cbPaymentMethod.Location = new System.Drawing.Point(416, 549);
            this.cbPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(568, 44);
            this.cbPaymentMethod.TabIndex = 22;
            // 
            // cbStaff
            // 
            this.cbStaff.BackColor = System.Drawing.Color.Transparent;
            this.cbStaff.BorderRadius = 19;
            this.cbStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbStaff.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbStaff.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaff.ForeColor = System.Drawing.Color.White;
            this.cbStaff.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbStaff.ItemHeight = 38;
            this.cbStaff.Location = new System.Drawing.Point(416, 646);
            this.cbStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(568, 44);
            this.cbStaff.TabIndex = 23;
            this.cbStaff.SelectedIndexChanged += new System.EventHandler(this.cbStaff_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(407, 769);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 24;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Animated = true;
            this.btnConfirmPayment.AutoRoundedCorners = true;
            this.btnConfirmPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmPayment.FillColor = System.Drawing.Color.OrangeRed;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Image = global::Gym_Mngt_System.Properties.Resources.mdi_account_payment;
            this.btnConfirmPayment.Location = new System.Drawing.Point(689, 769);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(296, 65);
            this.btnConfirmPayment.TabIndex = 27;
            this.btnConfirmPayment.Text = "Pay";
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(107, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "Member Name:";
            // 
            // lblmemberName
            // 
            this.lblmemberName.AutoSize = true;
            this.lblmemberName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberName.ForeColor = System.Drawing.Color.White;
            this.lblmemberName.Location = new System.Drawing.Point(411, 154);
            this.lblmemberName.Name = "lblmemberName";
            this.lblmemberName.Size = new System.Drawing.Size(24, 27);
            this.lblmemberName.TabIndex = 29;
            this.lblmemberName.Text = "...";
            this.lblmemberName.Click += new System.EventHandler(this.lblmemberID_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(955, 4);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(146, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trainer plan:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainer.ForeColor = System.Drawing.Color.White;
            this.lblTrainer.Location = new System.Drawing.Point(411, 301);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(24, 27);
            this.lblTrainer.TabIndex = 11;
            this.lblTrainer.Text = "...";
            this.lblTrainer.Click += new System.EventHandler(this.lblPlan_Click);
            // 
            // AddPaymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1000, 868);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblmemberName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStaff);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAmountPaid);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPaymentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPaymentFrm";
            this.Load += new System.EventHandler(this.AddPaymentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2TextBox tbAmountPaid;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaymentMethod;
        private Guna.UI2.WinForms.Guna2ComboBox cbStaff;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnConfirmPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmemberName;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTrainer;
    }
}