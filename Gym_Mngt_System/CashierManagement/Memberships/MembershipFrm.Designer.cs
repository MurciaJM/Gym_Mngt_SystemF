namespace Gym_Mngt_System
{
    partial class MembershipFrm
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.flpMemberships = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.btnAddMember = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Honeydew;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1108, 100);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(123, 41);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Active";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.Honeydew;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1235, 100);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(123, 41);
            this.guna2Button2.TabIndex = 16;
            this.guna2Button2.Text = "Expired";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // flpMemberships
            // 
            this.flpMemberships.AutoScroll = true;
            this.flpMemberships.Location = new System.Drawing.Point(50, 145);
            this.flpMemberships.Margin = new System.Windows.Forms.Padding(2);
            this.flpMemberships.Name = "flpMemberships";
            this.flpMemberships.Size = new System.Drawing.Size(1425, 646);
            this.flpMemberships.TabIndex = 18;
            this.flpMemberships.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMemberships_Paint);
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.lblAddMember.Location = new System.Drawing.Point(527, 8);
            this.lblAddMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(97, 20);
            this.lblAddMember.TabIndex = 24;
            this.lblAddMember.Text = "Add Member";
            this.lblAddMember.Visible = false;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Animated = true;
            this.btnAddMember.AnimatedGIF = true;
            this.btnAddMember.BorderRadius = 10;
            this.btnAddMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMember.FillColor = System.Drawing.Color.OrangeRed;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Image = global::Gym_Mngt_System.Properties.Resources.man;
            this.btnAddMember.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMember.Location = new System.Drawing.Point(542, 31);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(60, 50);
            this.btnAddMember.TabIndex = 12;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
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
            this.tbSearch.Location = new System.Drawing.Point(50, 31);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search here...";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(487, 50);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // MembershipFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1432, 802);
            this.Controls.Add(this.lblAddMember);
            this.Controls.Add(this.flpMemberships);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MembershipFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlansFrm";
            this.Load += new System.EventHandler(this.MembershipFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddMember;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel flpMemberships;
        private System.Windows.Forms.Label lblAddMember;
    }
}