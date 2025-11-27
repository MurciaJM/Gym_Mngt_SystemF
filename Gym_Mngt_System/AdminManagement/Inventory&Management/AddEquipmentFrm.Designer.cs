namespace Gym_Mngt_System
{
    partial class AddEquipmentFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEquipmentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEquipmentModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbEquipmentCondition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateEquipment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBrand = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add New Equipment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Equipment Name*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbEquipmentName
            // 
            this.tbEquipmentName.AutoRoundedCorners = true;
            this.tbEquipmentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEquipmentName.DefaultText = "";
            this.tbEquipmentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEquipmentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEquipmentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEquipmentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEquipmentName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbEquipmentName.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbEquipmentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEquipmentName.ForeColor = System.Drawing.Color.White;
            this.tbEquipmentName.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbEquipmentName.Location = new System.Drawing.Point(89, 142);
            this.tbEquipmentName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEquipmentName.Name = "tbEquipmentName";
            this.tbEquipmentName.PlaceholderText = "e.g., Dumbbells, Kettlebells ";
            this.tbEquipmentName.SelectedText = "";
            this.tbEquipmentName.Size = new System.Drawing.Size(543, 44);
            this.tbEquipmentName.TabIndex = 21;
            this.tbEquipmentName.TextChanged += new System.EventHandler(this.tbEquipmentName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quantity*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nupQuantity
            // 
            this.nupQuantity.AutoRoundedCorners = true;
            this.nupQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nupQuantity.BorderRadius = 21;
            this.nupQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.nupQuantity.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.nupQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupQuantity.ForeColor = System.Drawing.Color.White;
            this.nupQuantity.Location = new System.Drawing.Point(89, 436);
            this.nupQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(201, 44);
            this.nupQuantity.TabIndex = 24;
            this.nupQuantity.UpDownButtonFillColor = System.Drawing.Color.OrangeRed;
            this.nupQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nupQuantity.UseTransparentBackground = true;
            this.nupQuantity.ValueChanged += new System.EventHandler(this.nupQuantity_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbEquipmentModel
            // 
            this.tbEquipmentModel.AutoRoundedCorners = true;
            this.tbEquipmentModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEquipmentModel.DefaultText = "";
            this.tbEquipmentModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEquipmentModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEquipmentModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEquipmentModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEquipmentModel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbEquipmentModel.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbEquipmentModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEquipmentModel.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbEquipmentModel.Location = new System.Drawing.Point(89, 240);
            this.tbEquipmentModel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEquipmentModel.Name = "tbEquipmentModel";
            this.tbEquipmentModel.PlaceholderText = "e.g., 5-50 lbs";
            this.tbEquipmentModel.SelectedText = "";
            this.tbEquipmentModel.Size = new System.Drawing.Size(543, 44);
            this.tbEquipmentModel.TabIndex = 25;
            this.tbEquipmentModel.TextChanged += new System.EventHandler(this.tbEquipmentModel_TextChanged);
            // 
            // cbEquipmentCondition
            // 
            this.cbEquipmentCondition.BackColor = System.Drawing.Color.Transparent;
            this.cbEquipmentCondition.BorderRadius = 20;
            this.cbEquipmentCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEquipmentCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipmentCondition.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.cbEquipmentCondition.FocusedColor = System.Drawing.Color.OrangeRed;
            this.cbEquipmentCondition.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbEquipmentCondition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipmentCondition.ForeColor = System.Drawing.Color.White;
            this.cbEquipmentCondition.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.cbEquipmentCondition.ItemHeight = 38;
            this.cbEquipmentCondition.Location = new System.Drawing.Point(93, 534);
            this.cbEquipmentCondition.Margin = new System.Windows.Forms.Padding(2);
            this.cbEquipmentCondition.Name = "cbEquipmentCondition";
            this.cbEquipmentCondition.Size = new System.Drawing.Size(539, 44);
            this.cbEquipmentCondition.TabIndex = 28;
            this.cbEquipmentCondition.SelectedIndexChanged += new System.EventHandler(this.cbEquipmentCondition_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 507);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Condition";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCreateEquipment
            // 
            this.btnCreateEquipment.AutoRoundedCorners = true;
            this.btnCreateEquipment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateEquipment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateEquipment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateEquipment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateEquipment.FillColor = System.Drawing.Color.OrangeRed;
            this.btnCreateEquipment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEquipment.ForeColor = System.Drawing.Color.White;
            this.btnCreateEquipment.Image = global::Gym_Mngt_System.Properties.Resources.diskette;
            this.btnCreateEquipment.Location = new System.Drawing.Point(410, 601);
            this.btnCreateEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateEquipment.Name = "btnCreateEquipment";
            this.btnCreateEquipment.Size = new System.Drawing.Size(222, 53);
            this.btnCreateEquipment.TabIndex = 34;
            this.btnCreateEquipment.Text = "Create Equipment";
            this.btnCreateEquipment.Click += new System.EventHandler(this.btnCreateEquipment_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Gym_Mngt_System.Properties.Resources.plus__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(29, 28);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(34, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.tbBrand);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnCreateEquipment);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.tbEquipmentName);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.nupQuantity);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(670, 675);
            this.guna2GradientPanel1.TabIndex = 35;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(636, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Brand";
            // 
            // tbBrand
            // 
            this.tbBrand.AutoRoundedCorners = true;
            this.tbBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBrand.DefaultText = "";
            this.tbBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.tbBrand.FocusedState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbBrand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBrand.ForeColor = System.Drawing.Color.White;
            this.tbBrand.HoverState.BorderColor = System.Drawing.Color.OrangeRed;
            this.tbBrand.Location = new System.Drawing.Point(89, 338);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.PlaceholderText = "e.g., Life Fitness";
            this.tbBrand.SelectedText = "";
            this.tbBrand.Size = new System.Drawing.Size(543, 44);
            this.tbBrand.TabIndex = 37;
            // 
            // AddEquipmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(670, 675);
            this.Controls.Add(this.cbEquipmentCondition);
            this.Controls.Add(this.tbEquipmentModel);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEquipmentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEquipmentFrm";
            this.Load += new System.EventHandler(this.AddEquipmentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbEquipmentName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupQuantity;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbEquipmentModel;
        private Guna.UI2.WinForms.Guna2ComboBox cbEquipmentCondition;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnCreateEquipment;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbBrand;
    }
}