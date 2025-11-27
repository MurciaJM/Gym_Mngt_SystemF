namespace Gym_Mngt_System
{
    partial class Schedule
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
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpSession = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddSession = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
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
            this.tbSearch.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.IconLeft = global::Gym_Mngt_System.Properties.Resources.search;
            this.tbSearch.Location = new System.Drawing.Point(28, 12);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search here...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(487, 50);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // flpSession
            // 
            this.flpSession.AutoScroll = true;
            this.flpSession.Location = new System.Drawing.Point(50, 145);
            this.flpSession.Margin = new System.Windows.Forms.Padding(8);
            this.flpSession.Name = "flpSession";
            this.flpSession.Size = new System.Drawing.Size(1473, 681);
            this.flpSession.TabIndex = 21;
            // 
            // btnAddSession
            // 
            this.btnAddSession.Animated = true;
            this.btnAddSession.BorderColor = System.Drawing.Color.Honeydew;
            this.btnAddSession.BorderRadius = 15;
            this.btnAddSession.BorderThickness = 1;
            this.btnAddSession.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSession.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSession.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAddSession.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddSession.ForeColor = System.Drawing.Color.White;
            this.btnAddSession.Image = global::Gym_Mngt_System.Properties.Resources.plus__1_;
            this.btnAddSession.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddSession.IndicateFocus = true;
            this.btnAddSession.Location = new System.Drawing.Point(1227, 100);
            this.btnAddSession.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(131, 41);
            this.btnAddSession.TabIndex = 26;
            this.btnAddSession.Text = "Add";
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click_1);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(520, 11);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(299, 50);
            this.guna2DateTimePicker1.TabIndex = 25;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 10, 30, 12, 44, 21, 88);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1452, 837);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.flpSession);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Schedule";
            this.Text = "SessionFrm";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flpSession;
        private Guna.UI2.WinForms.Guna2Button btnAddSession;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}