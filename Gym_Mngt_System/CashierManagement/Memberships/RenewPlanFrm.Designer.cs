namespace Gym_Mngt_System
{
    partial class RenewPlanFrm
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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPlan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRenewDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTrainers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTrainerPlan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F);
            this.lblMemberName.ForeColor = System.Drawing.Color.White;
            this.lblMemberName.Location = new System.Drawing.Point(360, 177);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(74, 32);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plan:";
            // 
            // cbPlan
            // 
            this.cbPlan.BackColor = System.Drawing.Color.Transparent;
            this.cbPlan.BorderRadius = 20;
            this.cbPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbPlan.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbPlan.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPlan.ForeColor = System.Drawing.Color.White;
            this.cbPlan.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbPlan.ItemHeight = 38;
            this.cbPlan.Location = new System.Drawing.Point(364, 250);
            this.cbPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(467, 44);
            this.cbPlan.TabIndex = 3;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Renew:";
            // 
            // dtpRenewDate
            // 
            this.dtpRenewDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpRenewDate.BorderColor = System.Drawing.Color.White;
            this.dtpRenewDate.BorderRadius = 20;
            this.dtpRenewDate.BorderThickness = 1;
            this.dtpRenewDate.Checked = true;
            this.dtpRenewDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.dtpRenewDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRenewDate.ForeColor = System.Drawing.Color.White;
            this.dtpRenewDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpRenewDate.Location = new System.Drawing.Point(366, 488);
            this.dtpRenewDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRenewDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRenewDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRenewDate.Name = "dtpRenewDate";
            this.dtpRenewDate.Size = new System.Drawing.Size(468, 54);
            this.dtpRenewDate.TabIndex = 5;
            this.dtpRenewDate.UseTransparentBackground = true;
            this.dtpRenewDate.Value = new System.DateTime(2025, 10, 11, 13, 12, 55, 512);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(199, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(361, 576);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 27);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "price";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Gym_Mngt_System.Properties.Resources.diskette;
            this.guna2Button2.Location = new System.Drawing.Point(576, 651);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(256, 65);
            this.guna2Button2.TabIndex = 17;
            this.guna2Button2.Text = "Confirm";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Panel1.Location = new System.Drawing.Point(25, 65);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(828, 70);
            this.guna2Panel1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(211, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 63);
            this.label8.TabIndex = 25;
            this.label8.Text = "Renew Member";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(820, 2);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trainer (optional):";
            // 
            // cbTrainers
            // 
            this.cbTrainers.BackColor = System.Drawing.Color.Transparent;
            this.cbTrainers.BorderRadius = 20;
            this.cbTrainers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbTrainers.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbTrainers.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbTrainers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrainers.ForeColor = System.Drawing.Color.White;
            this.cbTrainers.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbTrainers.ItemHeight = 38;
            this.cbTrainers.Location = new System.Drawing.Point(366, 331);
            this.cbTrainers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrainers.Name = "cbTrainers";
            this.cbTrainers.Size = new System.Drawing.Size(467, 44);
            this.cbTrainers.TabIndex = 3;
            this.cbTrainers.SelectedIndexChanged += new System.EventHandler(this.cbTrainers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(100, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Trainer plan:";
            // 
            // cbTrainerPlan
            // 
            this.cbTrainerPlan.BackColor = System.Drawing.Color.Transparent;
            this.cbTrainerPlan.BorderRadius = 20;
            this.cbTrainerPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrainerPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainerPlan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbTrainerPlan.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbTrainerPlan.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbTrainerPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrainerPlan.ForeColor = System.Drawing.Color.White;
            this.cbTrainerPlan.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbTrainerPlan.ItemHeight = 38;
            this.cbTrainerPlan.Location = new System.Drawing.Point(364, 413);
            this.cbTrainerPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrainerPlan.Name = "cbTrainerPlan";
            this.cbTrainerPlan.Size = new System.Drawing.Size(467, 44);
            this.cbTrainerPlan.TabIndex = 3;
            this.cbTrainerPlan.SelectedIndexChanged += new System.EventHandler(this.cbTrainerPlan_SelectedIndexChanged);
            // 
            // RenewPlanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(868, 747);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpRenewDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTrainerPlan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTrainers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RenewPlanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberViewDetailsFrm";
            this.Load += new System.EventHandler(this.RenewPlanFrm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbPlan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpRenewDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrainers;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrainerPlan;
    }
}