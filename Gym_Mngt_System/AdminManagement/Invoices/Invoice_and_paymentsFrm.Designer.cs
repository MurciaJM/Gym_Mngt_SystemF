namespace Gym_Mngt_System
{
    partial class Invoice_and_paymentsFrm
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
            this.lblTotalRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalInvoices = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowInvoices = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTotalInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnTotalRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMachine = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(71, 220);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(81, 43);
            this.lblTotalRevenue.TabIndex = 7;
            this.lblTotalRevenue.Text = "₱0.00";
            // 
            // lblTotalInvoices
            // 
            this.lblTotalInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.lblTotalInvoices.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoices.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalInvoices.Location = new System.Drawing.Point(728, 231);
            this.lblTotalInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalInvoices.Name = "lblTotalInvoices";
            this.lblTotalInvoices.Size = new System.Drawing.Size(20, 43);
            this.lblTotalInvoices.TabIndex = 9;
            this.lblTotalInvoices.Text = "0";
            // 
            // flowInvoices
            // 
            this.flowInvoices.AutoScroll = true;
            this.flowInvoices.Location = new System.Drawing.Point(48, 311);
            this.flowInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowInvoices.Name = "flowInvoices";
            this.flowInvoices.Size = new System.Drawing.Size(1940, 662);
            this.flowInvoices.TabIndex = 21;
            // 
            // btnTotalInvoice
            // 
            this.btnTotalInvoice.Animated = true;
            this.btnTotalInvoice.BorderColor = System.Drawing.Color.Empty;
            this.btnTotalInvoice.BorderRadius = 20;
            this.btnTotalInvoice.BorderThickness = 1;
            this.btnTotalInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnTotalInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalInvoice.ForeColor = System.Drawing.Color.DimGray;
            this.btnTotalInvoice.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnTotalInvoice.Image = global::Gym_Mngt_System.Properties.Resources.growth;
            this.btnTotalInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTotalInvoice.ImageSize = new System.Drawing.Size(60, 60);
            this.btnTotalInvoice.Location = new System.Drawing.Point(707, 111);
            this.btnTotalInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotalInvoice.Name = "btnTotalInvoice";
            this.btnTotalInvoice.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnTotalInvoice.Size = new System.Drawing.Size(592, 186);
            this.btnTotalInvoice.TabIndex = 8;
            this.btnTotalInvoice.Text = "Total Sales";
            this.btnTotalInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTotalRevenue
            // 
            this.btnTotalRevenue.Animated = true;
            this.btnTotalRevenue.BorderColor = System.Drawing.Color.Empty;
            this.btnTotalRevenue.BorderRadius = 20;
            this.btnTotalRevenue.BorderThickness = 1;
            this.btnTotalRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.btnTotalRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnTotalRevenue.ForeColor = System.Drawing.Color.DimGray;
            this.btnTotalRevenue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.btnTotalRevenue.Image = global::Gym_Mngt_System.Properties.Resources.clarity_dollar_solid__1_;
            this.btnTotalRevenue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTotalRevenue.ImageSize = new System.Drawing.Size(60, 60);
            this.btnTotalRevenue.Location = new System.Drawing.Point(49, 110);
            this.btnTotalRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotalRevenue.Name = "btnTotalRevenue";
            this.btnTotalRevenue.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.btnTotalRevenue.Size = new System.Drawing.Size(616, 186);
            this.btnTotalRevenue.TabIndex = 6;
            this.btnTotalRevenue.Text = "Total Revenue";
            this.btnTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Animated = true;
            this.btnAddMachine.AnimatedGIF = true;
            this.btnAddMachine.BorderColor = System.Drawing.Color.Empty;
            this.btnAddMachine.BorderRadius = 10;
            this.btnAddMachine.BorderThickness = 1;
            this.btnAddMachine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMachine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMachine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMachine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMachine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAddMachine.FocusedColor = System.Drawing.Color.Black;
            this.btnAddMachine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachine.ForeColor = System.Drawing.Color.White;
            this.btnAddMachine.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAddMachine.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnAddMachine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddMachine.HoverState.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMachine.HoverState.Image = global::Gym_Mngt_System.Properties.Resources.uil_down_arrow;
            this.btnAddMachine.Image = global::Gym_Mngt_System.Properties.Resources.uil_down_arrow__1_;
            this.btnAddMachine.Location = new System.Drawing.Point(1637, 204);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(219, 64);
            this.btnAddMachine.TabIndex = 5;
            this.btnAddMachine.Text = "Export Report";
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Animated = true;
            this.tbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearch.BorderColor = System.Drawing.Color.Silver;
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.tbSearch.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.IconLeft = global::Gym_Mngt_System.Properties.Resources.search;
            this.tbSearch.Location = new System.Drawing.Point(48, 14);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search here...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(649, 62);
            this.tbSearch.TabIndex = 22;
            // 
            // Invoice_and_paymentsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1909, 987);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.lblTotalInvoices);
            this.Controls.Add(this.btnTotalInvoice);
            this.Controls.Add(this.btnTotalRevenue);
            this.Controls.Add(this.flowInvoices);
            this.Controls.Add(this.btnAddMachine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Invoice_and_paymentsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Invoice_and_paymentsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddMachine;
        private Guna.UI2.WinForms.Guna2Button btnTotalRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRevenue;
        private Guna.UI2.WinForms.Guna2Button btnTotalInvoice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalInvoices;
        private System.Windows.Forms.FlowLayoutPanel flowInvoices;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
    }
}