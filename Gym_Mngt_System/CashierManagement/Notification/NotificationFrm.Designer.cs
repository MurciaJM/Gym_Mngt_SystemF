namespace Gym_Mngt_System
{
    partial class NotificationFrm
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
            this.cbNotification = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
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
            this.tbSearch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.IconLeft = global::Gym_Mngt_System.Properties.Resources.search;
            this.tbSearch.Location = new System.Drawing.Point(12, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search here...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(487, 50);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // cbNotification
            // 
            this.cbNotification.BackColor = System.Drawing.Color.Transparent;
            this.cbNotification.BorderRadius = 10;
            this.cbNotification.BorderThickness = 0;
            this.cbNotification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNotification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNotification.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNotification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNotification.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNotification.ItemHeight = 45;
            this.cbNotification.Items.AddRange(new object[] {
            " "});
            this.cbNotification.Location = new System.Drawing.Point(504, 11);
            this.cbNotification.Margin = new System.Windows.Forms.Padding(2);
            this.cbNotification.Name = "cbNotification";
            this.cbNotification.Size = new System.Drawing.Size(265, 51);
            this.cbNotification.StartIndex = 0;
            this.cbNotification.TabIndex = 22;
            this.cbNotification.SelectedIndexChanged += new System.EventHandler(this.cbNotification_SelectedIndexChanged);
            // 
            // flpNotification
            // 
            this.flpNotification.AutoScroll = true;
            this.flpNotification.Location = new System.Drawing.Point(46, 145);
            this.flpNotification.Margin = new System.Windows.Forms.Padding(2);
            this.flpNotification.Name = "flpNotification";
            this.flpNotification.Size = new System.Drawing.Size(1455, 664);
            this.flpNotification.TabIndex = 23;
            // 
            // NotificationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1452, 837);
            this.Controls.Add(this.flpNotification);
            this.Controls.Add(this.cbNotification);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NotificationFrm";
            this.Text = "NotificationFrm";
            this.Load += new System.EventHandler(this.NotificationFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbNotification;
        private System.Windows.Forms.FlowLayoutPanel flpNotification;
    }
}