namespace Gym_Mngt_System.CashierManagement.MemberLogs
{
    partial class qrScanner
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
            this.components = new System.ComponentModel.Container();
            this.importQr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // importQr
            // 
            this.importQr.BackColor = System.Drawing.SystemColors.Control;
            this.importQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importQr.Font = new System.Drawing.Font("Courier New", 9.98F);
            this.importQr.ForeColor = System.Drawing.Color.Black;
            this.importQr.Location = new System.Drawing.Point(92, 289);
            this.importQr.Name = "importQr";
            this.importQr.Size = new System.Drawing.Size(119, 43);
            this.importQr.TabIndex = 50;
            this.importQr.Text = "IMPORT";
            this.importQr.UseVisualStyleBackColor = false;
            this.importQr.Click += new System.EventHandler(this.importQr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 251);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // qrScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 355);
            this.Controls.Add(this.importQr);
            this.Controls.Add(this.pictureBox1);
            this.Name = "qrScanner";
            this.Text = "qrScanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qrScanner_FormClosing);
            this.Load += new System.EventHandler(this.qrScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importQr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}