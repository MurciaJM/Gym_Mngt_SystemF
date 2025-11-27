namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    partial class EquipmentsFrm
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
            this.pnlLiftingEquipment = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLiftingBroken = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLiftingMaintenance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLiftingWorking = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalLifting = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLiftingBroken = new Guna.UI2.WinForms.Guna2Button();
            this.btnLiftingMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.btnLiftingWorking = new Guna.UI2.WinForms.Guna2Button();
            this.btnLiftingTotal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddEquipment = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLiftingEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLiftingEquipment
            // 
            this.pnlLiftingEquipment.Controls.Add(this.lblLiftingBroken);
            this.pnlLiftingEquipment.Controls.Add(this.lblLiftingMaintenance);
            this.pnlLiftingEquipment.Controls.Add(this.lblLiftingWorking);
            this.pnlLiftingEquipment.Controls.Add(this.lblTotalLifting);
            this.pnlLiftingEquipment.Controls.Add(this.FlowLayoutPanel);
            this.pnlLiftingEquipment.Controls.Add(this.btnLiftingBroken);
            this.pnlLiftingEquipment.Controls.Add(this.btnLiftingMaintenance);
            this.pnlLiftingEquipment.Controls.Add(this.btnLiftingWorking);
            this.pnlLiftingEquipment.Controls.Add(this.btnLiftingTotal);
            this.pnlLiftingEquipment.Controls.Add(this.guna2TextBox1);
            this.pnlLiftingEquipment.Controls.Add(this.btnAddEquipment);
            this.pnlLiftingEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLiftingEquipment.Location = new System.Drawing.Point(0, 0);
            this.pnlLiftingEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLiftingEquipment.Name = "pnlLiftingEquipment";
            this.pnlLiftingEquipment.Size = new System.Drawing.Size(1404, 763);
            this.pnlLiftingEquipment.TabIndex = 8;
            this.pnlLiftingEquipment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLiftingEquipment_Paint);
            // 
            // lblLiftingBroken
            // 
            this.lblLiftingBroken.BackColor = System.Drawing.Color.MistyRose;
            this.lblLiftingBroken.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiftingBroken.ForeColor = System.Drawing.Color.Red;
            this.lblLiftingBroken.Location = new System.Drawing.Point(996, 158);
            this.lblLiftingBroken.Margin = new System.Windows.Forms.Padding(2);
            this.lblLiftingBroken.Name = "lblLiftingBroken";
            this.lblLiftingBroken.Size = new System.Drawing.Size(17, 34);
            this.lblLiftingBroken.TabIndex = 15;
            this.lblLiftingBroken.Text = "0";
            // 
            // lblLiftingMaintenance
            // 
            this.lblLiftingMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.lblLiftingMaintenance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiftingMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLiftingMaintenance.Location = new System.Drawing.Point(703, 158);
            this.lblLiftingMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.lblLiftingMaintenance.Name = "lblLiftingMaintenance";
            this.lblLiftingMaintenance.Size = new System.Drawing.Size(17, 34);
            this.lblLiftingMaintenance.TabIndex = 15;
            this.lblLiftingMaintenance.Text = "0";
            this.lblLiftingMaintenance.Click += new System.EventHandler(this.lblLiftingMaintenance_Click);
            // 
            // lblLiftingWorking
            // 
            this.lblLiftingWorking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.lblLiftingWorking.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiftingWorking.ForeColor = System.Drawing.Color.Lime;
            this.lblLiftingWorking.Location = new System.Drawing.Point(418, 158);
            this.lblLiftingWorking.Margin = new System.Windows.Forms.Padding(2);
            this.lblLiftingWorking.Name = "lblLiftingWorking";
            this.lblLiftingWorking.Size = new System.Drawing.Size(17, 34);
            this.lblLiftingWorking.TabIndex = 15;
            this.lblLiftingWorking.Text = "0";
            // 
            // lblTotalLifting
            // 
            this.lblTotalLifting.BackColor = System.Drawing.Color.Lavender;
            this.lblTotalLifting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLifting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalLifting.Location = new System.Drawing.Point(123, 158);
            this.lblTotalLifting.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotalLifting.Name = "lblTotalLifting";
            this.lblTotalLifting.Size = new System.Drawing.Size(17, 34);
            this.lblTotalLifting.TabIndex = 15;
            this.lblTotalLifting.Text = "0";
            this.lblTotalLifting.Click += new System.EventHandler(this.lblTotalLifting_Click);
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.AutoScroll = true;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(35, 206);
            this.FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.FlowLayoutPanel.Size = new System.Drawing.Size(1463, 533);
            this.FlowLayoutPanel.TabIndex = 13;
            this.FlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel_Paint);
            // 
            // btnLiftingBroken
            // 
            this.btnLiftingBroken.Animated = true;
            this.btnLiftingBroken.BorderColor = System.Drawing.Color.Empty;
            this.btnLiftingBroken.BorderRadius = 20;
            this.btnLiftingBroken.BorderThickness = 1;
            this.btnLiftingBroken.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingBroken.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingBroken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLiftingBroken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLiftingBroken.FillColor = System.Drawing.Color.MistyRose;
            this.btnLiftingBroken.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiftingBroken.ForeColor = System.Drawing.Color.DimGray;
            this.btnLiftingBroken.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnLiftingBroken.Image = global::Gym_Mngt_System.Properties.Resources.warning;
            this.btnLiftingBroken.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLiftingBroken.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLiftingBroken.Location = new System.Drawing.Point(979, 77);
            this.btnLiftingBroken.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiftingBroken.Name = "btnLiftingBroken";
            this.btnLiftingBroken.PressedColor = System.Drawing.Color.MistyRose;
            this.btnLiftingBroken.Size = new System.Drawing.Size(279, 125);
            this.btnLiftingBroken.TabIndex = 12;
            this.btnLiftingBroken.Text = "Broken";
            this.btnLiftingBroken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLiftingMaintenance
            // 
            this.btnLiftingMaintenance.Animated = true;
            this.btnLiftingMaintenance.BorderColor = System.Drawing.Color.Empty;
            this.btnLiftingMaintenance.BorderRadius = 20;
            this.btnLiftingMaintenance.BorderThickness = 1;
            this.btnLiftingMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLiftingMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLiftingMaintenance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.btnLiftingMaintenance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiftingMaintenance.ForeColor = System.Drawing.Color.DimGray;
            this.btnLiftingMaintenance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.btnLiftingMaintenance.Image = global::Gym_Mngt_System.Properties.Resources.settings;
            this.btnLiftingMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLiftingMaintenance.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLiftingMaintenance.Location = new System.Drawing.Point(688, 77);
            this.btnLiftingMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiftingMaintenance.Name = "btnLiftingMaintenance";
            this.btnLiftingMaintenance.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.btnLiftingMaintenance.Size = new System.Drawing.Size(279, 125);
            this.btnLiftingMaintenance.TabIndex = 11;
            this.btnLiftingMaintenance.Text = "Maintenance";
            this.btnLiftingMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLiftingMaintenance.Click += new System.EventHandler(this.btnLiftingMaintenance_Click);
            // 
            // btnLiftingWorking
            // 
            this.btnLiftingWorking.Animated = true;
            this.btnLiftingWorking.BorderColor = System.Drawing.Color.Empty;
            this.btnLiftingWorking.BorderRadius = 20;
            this.btnLiftingWorking.BorderThickness = 1;
            this.btnLiftingWorking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingWorking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingWorking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLiftingWorking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLiftingWorking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.btnLiftingWorking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiftingWorking.ForeColor = System.Drawing.Color.DimGray;
            this.btnLiftingWorking.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.btnLiftingWorking.Image = global::Gym_Mngt_System.Properties.Resources._checked;
            this.btnLiftingWorking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLiftingWorking.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLiftingWorking.Location = new System.Drawing.Point(397, 77);
            this.btnLiftingWorking.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiftingWorking.Name = "btnLiftingWorking";
            this.btnLiftingWorking.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.btnLiftingWorking.Size = new System.Drawing.Size(279, 125);
            this.btnLiftingWorking.TabIndex = 10;
            this.btnLiftingWorking.Text = " Working";
            this.btnLiftingWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLiftingWorking.Click += new System.EventHandler(this.btnLiftingWorking_Click);
            // 
            // btnLiftingTotal
            // 
            this.btnLiftingTotal.Animated = true;
            this.btnLiftingTotal.BorderColor = System.Drawing.Color.Empty;
            this.btnLiftingTotal.BorderRadius = 20;
            this.btnLiftingTotal.BorderThickness = 1;
            this.btnLiftingTotal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingTotal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLiftingTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLiftingTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLiftingTotal.FillColor = System.Drawing.Color.Lavender;
            this.btnLiftingTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiftingTotal.ForeColor = System.Drawing.Color.DimGray;
            this.btnLiftingTotal.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.btnLiftingTotal.Image = global::Gym_Mngt_System.Properties.Resources.dumbbell__1_;
            this.btnLiftingTotal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLiftingTotal.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLiftingTotal.Location = new System.Drawing.Point(106, 77);
            this.btnLiftingTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiftingTotal.Name = "btnLiftingTotal";
            this.btnLiftingTotal.PressedColor = System.Drawing.Color.Lavender;
            this.btnLiftingTotal.Size = new System.Drawing.Size(279, 125);
            this.btnLiftingTotal.TabIndex = 9;
            this.btnLiftingTotal.Text = "Total Equipment";
            this.btnLiftingTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLiftingTotal.Click += new System.EventHandler(this.btnLiftingTotal_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.IconLeft = global::Gym_Mngt_System.Properties.Resources.search;
            this.guna2TextBox1.Location = new System.Drawing.Point(35, 13);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.guna2TextBox1.PlaceholderText = "Search here...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(487, 50);
            this.guna2TextBox1.TabIndex = 5;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Animated = true;
            this.btnAddEquipment.AnimatedGIF = true;
            this.btnAddEquipment.BorderRadius = 10;
            this.btnAddEquipment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEquipment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEquipment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEquipment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEquipment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAddEquipment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.ForeColor = System.Drawing.Color.White;
            this.btnAddEquipment.Image = global::Gym_Mngt_System.Properties.Resources.plus__1_;
            this.btnAddEquipment.Location = new System.Drawing.Point(1229, 11);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(164, 52);
            this.btnAddEquipment.TabIndex = 4;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // EquipmentsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1404, 763);
            this.Controls.Add(this.pnlLiftingEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipmentsFrm";
            this.Text = "EquipmentsFrm";
            this.pnlLiftingEquipment.ResumeLayout(false);
            this.pnlLiftingEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLiftingEquipment;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLiftingBroken;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLiftingMaintenance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLiftingWorking;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalLifting;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button btnLiftingBroken;
        private Guna.UI2.WinForms.Guna2Button btnLiftingMaintenance;
        private Guna.UI2.WinForms.Guna2Button btnLiftingWorking;
        private Guna.UI2.WinForms.Guna2Button btnLiftingTotal;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddEquipment;
    }
}