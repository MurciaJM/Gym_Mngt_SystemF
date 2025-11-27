namespace Gym_Mngt_System.Memberships
{
    partial class GenerateQrFrm
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBoxQR = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnGenerateQR = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(500, 10);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 26;
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxQR.BorderRadius = 20;
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQR.FillColor = System.Drawing.Color.Empty;
            this.pictureBoxQR.ImageRotate = 0F;
            this.pictureBoxQR.Location = new System.Drawing.Point(92, 92);
            this.pictureBoxQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(363, 323);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 31;
            this.pictureBoxQR.TabStop = false;
            this.pictureBoxQR.UseTransparentBackground = true;
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Animated = true;
            this.btnGenerateQR.AutoRoundedCorners = true;
            this.btnGenerateQR.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateQR.BorderColor = System.Drawing.Color.White;
            this.btnGenerateQR.BorderThickness = 1;
            this.btnGenerateQR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateQR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateQR.FillColor = System.Drawing.Color.Empty;
            this.btnGenerateQR.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateQR.ForeColor = System.Drawing.Color.White;
            this.btnGenerateQR.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenerateQR.Location = new System.Drawing.Point(202, 433);
            this.btnGenerateQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(168, 46);
            this.btnGenerateQR.TabIndex = 29;
            this.btnGenerateQR.Text = "Generate QR Code";
            this.btnGenerateQR.UseTransparentBackground = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // GenerateQrFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(545, 580);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GenerateQrFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateQrFrm";
            this.Load += new System.EventHandler(this.GenerateQrFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxQR;
        private Guna.UI2.WinForms.Guna2Button btnGenerateQR;
    }
}