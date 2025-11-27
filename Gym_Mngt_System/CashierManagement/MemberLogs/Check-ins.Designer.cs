namespace Gym_Mngt_System
{
    partial class MemberLogs
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
            this.lblScanQr = new System.Windows.Forms.Label();
            this.btnScanQR = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpMemberLogs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblScanQr
            // 
            this.lblScanQr.AutoSize = true;
            this.lblScanQr.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanQr.Location = new System.Drawing.Point(1731, 92);
            this.lblScanQr.Name = "lblScanQr";
            this.lblScanQr.Size = new System.Drawing.Size(82, 25);
            this.lblScanQr.TabIndex = 72;
            this.lblScanQr.Text = "Scan QR";
            this.lblScanQr.Visible = false;
            // 
            // btnScanQR
            // 
            this.btnScanQR.BackColor = System.Drawing.Color.Transparent;
            this.btnScanQR.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnScanQR.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.btnScanQR.Image = global::Gym_Mngt_System.Properties.Resources.qr_scan;
            this.btnScanQR.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnScanQR.ImageRotate = 0F;
            this.btnScanQR.ImageSize = new System.Drawing.Size(50, 50);
            this.btnScanQR.Location = new System.Drawing.Point(1731, 119);
            this.btnScanQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScanQR.Name = "btnScanQR";
            this.btnScanQR.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnScanQR.Size = new System.Drawing.Size(85, 54);
            this.btnScanQR.TabIndex = 71;
            this.btnScanQR.UseTransparentBackground = true;
            this.btnScanQR.Click += new System.EventHandler(this.btnScanQR_Click);
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
            this.tbSearch.Location = new System.Drawing.Point(61, 16);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search here...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(649, 62);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // flpMemberLogs
            // 
            this.flpMemberLogs.AutoScroll = true;
            this.flpMemberLogs.Location = new System.Drawing.Point(61, 178);
            this.flpMemberLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpMemberLogs.Name = "flpMemberLogs";
            this.flpMemberLogs.Size = new System.Drawing.Size(1940, 838);
            this.flpMemberLogs.TabIndex = 73;
            // 
            // MemberLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1936, 1030);
            this.Controls.Add(this.flpMemberLogs);
            this.Controls.Add(this.lblScanQr);
            this.Controls.Add(this.btnScanQR);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MemberLogs";
            this.Text = "Check_insFrm";
            this.Load += new System.EventHandler(this.Check_insFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.Label lblScanQr;
        private Guna.UI2.WinForms.Guna2ImageButton btnScanQR;
        private System.Windows.Forms.FlowLayoutPanel flpMemberLogs;
    }
}