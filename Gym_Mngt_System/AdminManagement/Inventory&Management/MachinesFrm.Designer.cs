namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    partial class MachinesFrm
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
            this.pnlMachines = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMachineBroken = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMachineMaintenance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMachineWorking = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalMachine = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanelMachines = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMachineBroken = new Guna.UI2.WinForms.Guna2Button();
            this.btnMachineMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.btnMachineWorking = new Guna.UI2.WinForms.Guna2Button();
            this.btnMachineTotal = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMachine = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMachines.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMachines
            // 
            this.pnlMachines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMachines.Controls.Add(this.lblMachineBroken);
            this.pnlMachines.Controls.Add(this.lblMachineMaintenance);
            this.pnlMachines.Controls.Add(this.lblMachineWorking);
            this.pnlMachines.Controls.Add(this.lblTotalMachine);
            this.pnlMachines.Controls.Add(this.flowLayoutPanelMachines);
            this.pnlMachines.Controls.Add(this.btnMachineBroken);
            this.pnlMachines.Controls.Add(this.btnMachineMaintenance);
            this.pnlMachines.Controls.Add(this.btnMachineWorking);
            this.pnlMachines.Controls.Add(this.btnMachineTotal);
            this.pnlMachines.Controls.Add(this.btnAddMachine);
            this.pnlMachines.Controls.Add(this.tbSearch);
            this.pnlMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMachines.Location = new System.Drawing.Point(0, 0);
            this.pnlMachines.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMachines.Name = "pnlMachines";
            this.pnlMachines.Size = new System.Drawing.Size(1404, 763);
            this.pnlMachines.TabIndex = 7;
            this.pnlMachines.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMachines_Paint);
            // 
            // lblMachineBroken
            // 
            this.lblMachineBroken.BackColor = System.Drawing.Color.MistyRose;
            this.lblMachineBroken.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineBroken.ForeColor = System.Drawing.Color.Red;
            this.lblMachineBroken.Location = new System.Drawing.Point(999, 155);
            this.lblMachineBroken.Margin = new System.Windows.Forms.Padding(2);
            this.lblMachineBroken.Name = "lblMachineBroken";
            this.lblMachineBroken.Size = new System.Drawing.Size(17, 34);
            this.lblMachineBroken.TabIndex = 14;
            this.lblMachineBroken.Text = "0";
            // 
            // lblMachineMaintenance
            // 
            this.lblMachineMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.lblMachineMaintenance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMachineMaintenance.Location = new System.Drawing.Point(704, 155);
            this.lblMachineMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.lblMachineMaintenance.Name = "lblMachineMaintenance";
            this.lblMachineMaintenance.Size = new System.Drawing.Size(17, 34);
            this.lblMachineMaintenance.TabIndex = 13;
            this.lblMachineMaintenance.Text = "0";
            // 
            // lblMachineWorking
            // 
            this.lblMachineWorking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.lblMachineWorking.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineWorking.ForeColor = System.Drawing.Color.Lime;
            this.lblMachineWorking.Location = new System.Drawing.Point(416, 155);
            this.lblMachineWorking.Margin = new System.Windows.Forms.Padding(2);
            this.lblMachineWorking.Name = "lblMachineWorking";
            this.lblMachineWorking.Size = new System.Drawing.Size(17, 34);
            this.lblMachineWorking.TabIndex = 12;
            this.lblMachineWorking.Text = "0";
            // 
            // lblTotalMachine
            // 
            this.lblTotalMachine.BackColor = System.Drawing.Color.Lavender;
            this.lblTotalMachine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalMachine.Location = new System.Drawing.Point(124, 155);
            this.lblTotalMachine.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotalMachine.Name = "lblTotalMachine";
            this.lblTotalMachine.Size = new System.Drawing.Size(17, 34);
            this.lblTotalMachine.TabIndex = 11;
            this.lblTotalMachine.Text = "0";
            // 
            // flowLayoutPanelMachines
            // 
            this.flowLayoutPanelMachines.AutoScroll = true;
            this.flowLayoutPanelMachines.Location = new System.Drawing.Point(35, 206);
            this.flowLayoutPanelMachines.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelMachines.Name = "flowLayoutPanelMachines";
            this.flowLayoutPanelMachines.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanelMachines.Size = new System.Drawing.Size(1463, 533);
            this.flowLayoutPanelMachines.TabIndex = 9;
            this.flowLayoutPanelMachines.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMachines_Paint);
            // 
            // btnMachineBroken
            // 
            this.btnMachineBroken.Animated = true;
            this.btnMachineBroken.BorderColor = System.Drawing.Color.Empty;
            this.btnMachineBroken.BorderRadius = 20;
            this.btnMachineBroken.BorderThickness = 1;
            this.btnMachineBroken.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineBroken.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineBroken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachineBroken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMachineBroken.FillColor = System.Drawing.Color.MistyRose;
            this.btnMachineBroken.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineBroken.ForeColor = System.Drawing.Color.DimGray;
            this.btnMachineBroken.HoverState.FillColor = System.Drawing.Color.MistyRose;
            this.btnMachineBroken.Image = global::Gym_Mngt_System.Properties.Resources.warning;
            this.btnMachineBroken.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMachineBroken.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMachineBroken.Location = new System.Drawing.Point(979, 77);
            this.btnMachineBroken.Margin = new System.Windows.Forms.Padding(2);
            this.btnMachineBroken.Name = "btnMachineBroken";
            this.btnMachineBroken.PressedColor = System.Drawing.Color.MistyRose;
            this.btnMachineBroken.Size = new System.Drawing.Size(279, 125);
            this.btnMachineBroken.TabIndex = 8;
            this.btnMachineBroken.Text = "Broken";
            this.btnMachineBroken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnMachineMaintenance
            // 
            this.btnMachineMaintenance.Animated = true;
            this.btnMachineMaintenance.BorderColor = System.Drawing.Color.Empty;
            this.btnMachineMaintenance.BorderRadius = 20;
            this.btnMachineMaintenance.BorderThickness = 1;
            this.btnMachineMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachineMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMachineMaintenance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.btnMachineMaintenance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineMaintenance.ForeColor = System.Drawing.Color.DimGray;
            this.btnMachineMaintenance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.btnMachineMaintenance.Image = global::Gym_Mngt_System.Properties.Resources.settings;
            this.btnMachineMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMachineMaintenance.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMachineMaintenance.Location = new System.Drawing.Point(688, 77);
            this.btnMachineMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.btnMachineMaintenance.Name = "btnMachineMaintenance";
            this.btnMachineMaintenance.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.btnMachineMaintenance.Size = new System.Drawing.Size(279, 125);
            this.btnMachineMaintenance.TabIndex = 7;
            this.btnMachineMaintenance.Text = "Maintenance";
            this.btnMachineMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnMachineWorking
            // 
            this.btnMachineWorking.Animated = true;
            this.btnMachineWorking.BorderColor = System.Drawing.Color.Empty;
            this.btnMachineWorking.BorderRadius = 20;
            this.btnMachineWorking.BorderThickness = 1;
            this.btnMachineWorking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineWorking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineWorking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachineWorking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMachineWorking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.btnMachineWorking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineWorking.ForeColor = System.Drawing.Color.DimGray;
            this.btnMachineWorking.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.btnMachineWorking.Image = global::Gym_Mngt_System.Properties.Resources._checked;
            this.btnMachineWorking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMachineWorking.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMachineWorking.Location = new System.Drawing.Point(397, 77);
            this.btnMachineWorking.Margin = new System.Windows.Forms.Padding(2);
            this.btnMachineWorking.Name = "btnMachineWorking";
            this.btnMachineWorking.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.btnMachineWorking.Size = new System.Drawing.Size(279, 125);
            this.btnMachineWorking.TabIndex = 6;
            this.btnMachineWorking.Text = " Working";
            this.btnMachineWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnMachineTotal
            // 
            this.btnMachineTotal.Animated = true;
            this.btnMachineTotal.BorderColor = System.Drawing.Color.Empty;
            this.btnMachineTotal.BorderRadius = 20;
            this.btnMachineTotal.BorderThickness = 1;
            this.btnMachineTotal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineTotal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachineTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMachineTotal.FillColor = System.Drawing.Color.Lavender;
            this.btnMachineTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineTotal.ForeColor = System.Drawing.Color.DimGray;
            this.btnMachineTotal.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.btnMachineTotal.Image = global::Gym_Mngt_System.Properties.Resources.dumbbell__1_;
            this.btnMachineTotal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMachineTotal.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMachineTotal.Location = new System.Drawing.Point(106, 77);
            this.btnMachineTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMachineTotal.Name = "btnMachineTotal";
            this.btnMachineTotal.PressedColor = System.Drawing.Color.Lavender;
            this.btnMachineTotal.Size = new System.Drawing.Size(279, 125);
            this.btnMachineTotal.TabIndex = 5;
            this.btnMachineTotal.Text = "Total Machines";
            this.btnMachineTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMachineTotal.Click += new System.EventHandler(this.btnMachineTotal_Click);
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Animated = true;
            this.btnAddMachine.AnimatedGIF = true;
            this.btnAddMachine.BorderRadius = 10;
            this.btnAddMachine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMachine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMachine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMachine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMachine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAddMachine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddMachine.ForeColor = System.Drawing.Color.White;
            this.btnAddMachine.Image = global::Gym_Mngt_System.Properties.Resources.plus__1_;
            this.btnAddMachine.Location = new System.Drawing.Point(1229, 11);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(164, 52);
            this.btnAddMachine.TabIndex = 4;
            this.btnAddMachine.Text = "Add Machine";
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Animated = true;
            this.tbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.tbSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.IconLeft = global::Gym_Mngt_System.Properties.Resources.search;
            this.tbSearch.Location = new System.Drawing.Point(35, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search here...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(487, 50);
            this.tbSearch.TabIndex = 3;
            // 
            // MachinesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1404, 763);
            this.Controls.Add(this.pnlMachines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MachinesFrm";
            this.Text = "MachinesFrm";
            this.pnlMachines.ResumeLayout(false);
            this.pnlMachines.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMachines;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMachineBroken;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMachineMaintenance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMachineWorking;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMachine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMachines;
        private Guna.UI2.WinForms.Guna2Button btnMachineBroken;
        private Guna.UI2.WinForms.Guna2Button btnMachineMaintenance;
        private Guna.UI2.WinForms.Guna2Button btnMachineWorking;
        private Guna.UI2.WinForms.Guna2Button btnMachineTotal;
        private Guna.UI2.WinForms.Guna2Button btnAddMachine;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
    }
}