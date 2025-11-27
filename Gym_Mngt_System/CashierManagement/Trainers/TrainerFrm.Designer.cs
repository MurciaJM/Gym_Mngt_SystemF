namespace Gym_Mngt_System.CashierManagement.Trainers
{
    partial class TrainerFrm
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
            this.flpTrainer = new System.Windows.Forms.FlowLayoutPanel();
            this.dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            this.tbSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.IconLeft = global::Gym_Mngt_System.Properties.Resources.search;
            this.tbSearch.Location = new System.Drawing.Point(61, 15);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search here...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(649, 62);
            this.tbSearch.TabIndex = 26;
            // 
            // flpTrainer
            // 
            this.flpTrainer.AutoScroll = true;
            this.flpTrainer.Location = new System.Drawing.Point(61, 178);
            this.flpTrainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTrainer.Name = "flpTrainer";
            this.flpTrainer.Size = new System.Drawing.Size(1940, 838);
            this.flpTrainer.TabIndex = 28;
            // 
            // dtp
            // 
            this.dtp.AutoRoundedCorners = true;
            this.dtp.Checked = true;
            this.dtp.FillColor = System.Drawing.Color.White;
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp.Location = new System.Drawing.Point(732, 15);
            this.dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(299, 50);
            this.dtp.TabIndex = 30;
            this.dtp.Value = new System.DateTime(2025, 10, 30, 12, 44, 21, 88);
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged_1);
            // 
            // TrainerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1936, 1030);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.flpTrainer);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrainerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrainerFrm";
            this.Load += new System.EventHandler(this.TrainerFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flpTrainer;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp;
    }
}