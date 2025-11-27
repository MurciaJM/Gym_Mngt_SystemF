namespace Gym_Mngt_System
{
    partial class Inventory
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
            this.flpMachineRecentChecks = new System.Windows.Forms.FlowLayoutPanel();
            this.filter = new System.Windows.Forms.Label();
            this.flpEquipmentRecentChecks = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbFiltering = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // flpMachineRecentChecks
            // 
            this.flpMachineRecentChecks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpMachineRecentChecks.AutoScroll = true;
            this.flpMachineRecentChecks.BackColor = System.Drawing.Color.Transparent;
            this.flpMachineRecentChecks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMachineRecentChecks.Location = new System.Drawing.Point(49, 82);
            this.flpMachineRecentChecks.Margin = new System.Windows.Forms.Padding(2);
            this.flpMachineRecentChecks.Name = "flpMachineRecentChecks";
            this.flpMachineRecentChecks.Size = new System.Drawing.Size(1455, 645);
            this.flpMachineRecentChecks.TabIndex = 11;
            this.flpMachineRecentChecks.WrapContents = false;
            this.flpMachineRecentChecks.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMachineRecentChecks_Paint);
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.Location = new System.Drawing.Point(51, 41);
            this.filter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(300, 32);
            this.filter.TabIndex = 12;
            this.filter.Text = "Recent Inventory Checks";
            // 
            // flpEquipmentRecentChecks
            // 
            this.flpEquipmentRecentChecks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpEquipmentRecentChecks.AutoScroll = true;
            this.flpEquipmentRecentChecks.BackColor = System.Drawing.Color.Transparent;
            this.flpEquipmentRecentChecks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEquipmentRecentChecks.Location = new System.Drawing.Point(49, 103);
            this.flpEquipmentRecentChecks.Margin = new System.Windows.Forms.Padding(2);
            this.flpEquipmentRecentChecks.Name = "flpEquipmentRecentChecks";
            this.flpEquipmentRecentChecks.Size = new System.Drawing.Size(1455, 624);
            this.flpEquipmentRecentChecks.TabIndex = 12;
            this.flpEquipmentRecentChecks.WrapContents = false;
            this.flpEquipmentRecentChecks.Paint += new System.Windows.Forms.PaintEventHandler(this.flpEquipmentRecentChecks_Paint);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(1156, 41);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(231, 36);
            this.guna2DateTimePicker1.TabIndex = 13;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 11, 19, 16, 46, 24, 727);
            // 
            // cbFiltering
            // 
            this.cbFiltering.BackColor = System.Drawing.Color.Transparent;
            this.cbFiltering.BorderColor = System.Drawing.Color.Empty;
            this.cbFiltering.BorderThickness = 0;
            this.cbFiltering.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltering.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbFiltering.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFiltering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFiltering.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFiltering.ItemHeight = 30;
            this.cbFiltering.Items.AddRange(new object[] {
            "Machine Inventory",
            "Lifting Inventory"});
            this.cbFiltering.Location = new System.Drawing.Point(187, 41);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(196, 36);
            this.cbFiltering.TabIndex = 15;
            this.cbFiltering.SelectedIndexChanged += new System.EventHandler(this.cbFiltering_SelectedIndexChanged);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1438, 761);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.cbFiltering);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.flpMachineRecentChecks);
            this.Controls.Add(this.flpEquipmentRecentChecks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentFrm";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpMachineRecentChecks;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.FlowLayoutPanel flpEquipmentRecentChecks;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFiltering;
    }
}