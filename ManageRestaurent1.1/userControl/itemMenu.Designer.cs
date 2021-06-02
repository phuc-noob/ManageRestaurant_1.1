namespace ManageRestaurent1._1
{
    partial class itemMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_tenMonAn = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.guna2Button_plus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_minus = new Guna.UI2.WinForms.Guna2Button();
            this.label_cost = new System.Windows.Forms.Label();
            this.pictureBox_remove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_remove)).BeginInit();
            this.SuspendLayout();
            // 
            // label_tenMonAn
            // 
            this.label_tenMonAn.Location = new System.Drawing.Point(22, 11);
            this.label_tenMonAn.Name = "label_tenMonAn";
            this.label_tenMonAn.Size = new System.Drawing.Size(131, 31);
            this.label_tenMonAn.TabIndex = 0;
            this.label_tenMonAn.Text = "Món Ăn";
            this.label_tenMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tenMonAn.Click += new System.EventHandler(this.label_tenMonAn_Click);
            // 
            // label_amount
            // 
            this.label_amount.Location = new System.Drawing.Point(371, 7);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(42, 45);
            this.label_amount.TabIndex = 3;
            this.label_amount.Text = "1";
            this.label_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button_plus
            // 
            this.guna2Button_plus.BorderRadius = 3;
            this.guna2Button_plus.CheckedState.Parent = this.guna2Button_plus;
            this.guna2Button_plus.CustomImages.Parent = this.guna2Button_plus;
            this.guna2Button_plus.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_plus.ForeColor = System.Drawing.Color.White;
            this.guna2Button_plus.HoverState.Parent = this.guna2Button_plus;
            this.guna2Button_plus.Location = new System.Drawing.Point(415, 7);
            this.guna2Button_plus.Name = "guna2Button_plus";
            this.guna2Button_plus.ShadowDecoration.Parent = this.guna2Button_plus;
            this.guna2Button_plus.Size = new System.Drawing.Size(48, 45);
            this.guna2Button_plus.TabIndex = 4;
            this.guna2Button_plus.Text = "+";
            this.guna2Button_plus.Click += new System.EventHandler(this.guna2Button_plus_Click);
            // 
            // guna2Button_minus
            // 
            this.guna2Button_minus.BorderRadius = 3;
            this.guna2Button_minus.CheckedState.Parent = this.guna2Button_minus;
            this.guna2Button_minus.CustomImages.Parent = this.guna2Button_minus;
            this.guna2Button_minus.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_minus.ForeColor = System.Drawing.Color.White;
            this.guna2Button_minus.HoverState.Parent = this.guna2Button_minus;
            this.guna2Button_minus.Location = new System.Drawing.Point(318, 6);
            this.guna2Button_minus.Name = "guna2Button_minus";
            this.guna2Button_minus.ShadowDecoration.Parent = this.guna2Button_minus;
            this.guna2Button_minus.Size = new System.Drawing.Size(48, 45);
            this.guna2Button_minus.TabIndex = 5;
            this.guna2Button_minus.Text = "-";
            this.guna2Button_minus.Click += new System.EventHandler(this.guna2Button_minus_Click);
            // 
            // label_cost
            // 
            this.label_cost.Location = new System.Drawing.Point(153, 11);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(140, 31);
            this.label_cost.TabIndex = 6;
            this.label_cost.Text = "00000 đ";
            this.label_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_remove
            // 
            this.pictureBox_remove.Image = global::ManageRestaurent1._1.Properties.Resources.images_removebg_preview4;
            this.pictureBox_remove.Location = new System.Drawing.Point(474, 10);
            this.pictureBox_remove.Name = "pictureBox_remove";
            this.pictureBox_remove.Size = new System.Drawing.Size(44, 37);
            this.pictureBox_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_remove.TabIndex = 7;
            this.pictureBox_remove.TabStop = false;
            this.pictureBox_remove.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox_remove.MouseLeave += new System.EventHandler(this.pictureBox_remove_MouseLeave);
            this.pictureBox_remove.MouseHover += new System.EventHandler(this.pictureBox_remove_MouseHover);
            // 
            // itemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.pictureBox_remove);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.guna2Button_minus);
            this.Controls.Add(this.guna2Button_plus);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_tenMonAn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "itemMenu";
            this.Size = new System.Drawing.Size(530, 58);
            this.Load += new System.EventHandler(this.itemMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_remove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button_plus;
        private Guna.UI2.WinForms.Guna2Button guna2Button_minus;
        public System.Windows.Forms.Label label_cost;
        public System.Windows.Forms.Label label_tenMonAn;
        public System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.PictureBox pictureBox_remove;
    }
}
