namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    partial class Admin_Inventory
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
            this.btnCheckEquipment = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckMachine = new Guna.UI2.WinForms.Guna2Button();
            this.pnlNav = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLoader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnCheckEquipment
            // 
            this.btnCheckEquipment.CheckedState.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckEquipment.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckEquipment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCheckEquipment.ForeColor = System.Drawing.Color.Black;
            this.btnCheckEquipment.Location = new System.Drawing.Point(233, 12);
            this.btnCheckEquipment.Name = "btnCheckEquipment";
            this.btnCheckEquipment.PressedColor = System.Drawing.Color.Empty;
            this.btnCheckEquipment.Size = new System.Drawing.Size(180, 44);
            this.btnCheckEquipment.TabIndex = 16;
            this.btnCheckEquipment.Text = "Lifting Equipments";
            this.btnCheckEquipment.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnCheckEquipment.Click += new System.EventHandler(this.btnCheckEquipment_Click);
            // 
            // btnCheckMachine
            // 
            this.btnCheckMachine.CheckedState.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckMachine.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckMachine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCheckMachine.ForeColor = System.Drawing.Color.Black;
            this.btnCheckMachine.Location = new System.Drawing.Point(47, 12);
            this.btnCheckMachine.Name = "btnCheckMachine";
            this.btnCheckMachine.PressedColor = System.Drawing.Color.Empty;
            this.btnCheckMachine.ShadowDecoration.BorderRadius = 0;
            this.btnCheckMachine.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnCheckMachine.Size = new System.Drawing.Size(180, 44);
            this.btnCheckMachine.TabIndex = 15;
            this.btnCheckMachine.Text = "Machine Equipments";
            this.btnCheckMachine.Click += new System.EventHandler(this.btnCheckMachine_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.FillColor = System.Drawing.Color.OrangeRed;
            this.pnlNav.Location = new System.Drawing.Point(47, 54);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(180, 3);
            this.pnlNav.TabIndex = 17;
            // 
            // panelLoader
            // 
            this.panelLoader.Location = new System.Drawing.Point(12, 62);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(1438, 761);
            this.panelLoader.TabIndex = 18;
            // 
            // btnInventory
            // 
            this.btnInventory.CheckedState.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInventory.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.Black;
            this.btnInventory.Image = global::Gym_Mngt_System.Properties.Resources.track2;
            this.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.ImageSize = new System.Drawing.Size(27, 27);
            this.btnInventory.Location = new System.Drawing.Point(419, 12);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.PressedColor = System.Drawing.Color.Empty;
            this.btnInventory.Size = new System.Drawing.Size(180, 44);
            this.btnInventory.TabIndex = 19;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // Admin_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1432, 802);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.panelLoader);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnCheckEquipment);
            this.Controls.Add(this.btnCheckMachine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Inventory";
            this.Text = "Admin_Inventory";
            this.Load += new System.EventHandler(this.Admin_Inventory_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCheckEquipment;
        private Guna.UI2.WinForms.Guna2Button btnCheckMachine;
        private Guna.UI2.WinForms.Guna2Panel pnlNav;
        private Guna.UI2.WinForms.Guna2Panel panelLoader;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
    }
}