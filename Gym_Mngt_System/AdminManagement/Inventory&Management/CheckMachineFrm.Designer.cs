namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    partial class CheckMachineFrm
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnLogCheck = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCheckingMachine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(881, 15);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 43;
            // 
            // btnLogCheck
            // 
            this.btnLogCheck.AutoRoundedCorners = true;
            this.btnLogCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogCheck.FillColor = System.Drawing.Color.OrangeRed;
            this.btnLogCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogCheck.ForeColor = System.Drawing.Color.White;
            this.btnLogCheck.Image = global::Gym_Mngt_System.Properties.Resources.check_mark__1_;
            this.btnLogCheck.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogCheck.Location = new System.Drawing.Point(605, 736);
            this.btnLogCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogCheck.Name = "btnLogCheck";
            this.btnLogCheck.Size = new System.Drawing.Size(296, 65);
            this.btnLogCheck.TabIndex = 42;
            this.btnLogCheck.Text = "Log Check";
            this.btnLogCheck.Click += new System.EventHandler(this.btnLogCheck_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblCheckingMachine);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(36, 134);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(865, 139);
            this.guna2Panel1.TabIndex = 39;
            // 
            // lblCheckingMachine
            // 
            this.lblCheckingMachine.AutoSize = true;
            this.lblCheckingMachine.BackColor = System.Drawing.Color.White;
            this.lblCheckingMachine.Font = new System.Drawing.Font("Segoe UI Variable Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingMachine.ForeColor = System.Drawing.Color.Black;
            this.lblCheckingMachine.Location = new System.Drawing.Point(75, 64);
            this.lblCheckingMachine.Name = "lblCheckingMachine";
            this.lblCheckingMachine.Size = new System.Drawing.Size(147, 40);
            this.lblCheckingMachine.TabIndex = 31;
            this.lblCheckingMachine.Text = "Leg Press";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(77, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Checking:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 50);
            this.label1.TabIndex = 38;
            this.label1.Text = "Log Inventory Check";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoRoundedCorners = true;
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderRadius = 21;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbStatus.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbStatus.ItemHeight = 38;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "Working",
            "Under Maintenance"});
            this.cbStatus.Location = new System.Drawing.Point(395, 348);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(456, 44);
            this.cbStatus.TabIndex = 45;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(210, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 48;
            this.label6.Text = "Category";
            // 
            // tbCat
            // 
            this.tbCat.AutoRoundedCorners = true;
            this.tbCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCat.DefaultText = "   ";
            this.tbCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbCat.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCat.ForeColor = System.Drawing.Color.White;
            this.tbCat.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbCat.Location = new System.Drawing.Point(395, 461);
            this.tbCat.Name = "tbCat";
            this.tbCat.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbCat.PlaceholderText = "0";
            this.tbCat.SelectedText = "";
            this.tbCat.Size = new System.Drawing.Size(456, 44);
            this.tbCat.TabIndex = 50;
            // 
            // CheckMachineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(943, 828);
            this.Controls.Add(this.tbCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnLogCheck);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckMachineFrm";
            this.Text = "CheckMachineFrm";
            this.Load += new System.EventHandler(this.CheckMachineFrm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogCheck;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblCheckingMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbCat;
    }
}