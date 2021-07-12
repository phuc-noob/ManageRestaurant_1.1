namespace ManageRestaurent1._1
{
    partial class Pay
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
            this.dataGridView_bill = new System.Windows.Forms.DataGridView();
            this.guna2Button_cancer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_print = new Guna.UI2.WinForms.Guna2Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_bill = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_bill
            // 
            this.dataGridView_bill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bill.Location = new System.Drawing.Point(12, 68);
            this.dataGridView_bill.Name = "dataGridView_bill";
            this.dataGridView_bill.RowHeadersWidth = 51;
            this.dataGridView_bill.RowTemplate.Height = 24;
            this.dataGridView_bill.Size = new System.Drawing.Size(649, 624);
            this.dataGridView_bill.TabIndex = 0;
            this.dataGridView_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bill_CellContentClick);
            // 
            // guna2Button_cancer
            // 
            this.guna2Button_cancer.BorderRadius = 4;
            this.guna2Button_cancer.CheckedState.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.CustomImages.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button_cancer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_cancer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_cancer.HoverState.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.Location = new System.Drawing.Point(364, 748);
            this.guna2Button_cancer.Name = "guna2Button_cancer";
            this.guna2Button_cancer.ShadowDecoration.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.Size = new System.Drawing.Size(138, 39);
            this.guna2Button_cancer.TabIndex = 1;
            this.guna2Button_cancer.Text = "Cancer";
            this.guna2Button_cancer.Click += new System.EventHandler(this.guna2Button_cancer_Click);
            // 
            // guna2Button_print
            // 
            this.guna2Button_print.BorderRadius = 4;
            this.guna2Button_print.CheckedState.Parent = this.guna2Button_print;
            this.guna2Button_print.CustomImages.Parent = this.guna2Button_print;
            this.guna2Button_print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button_print.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_print.HoverState.Parent = this.guna2Button_print;
            this.guna2Button_print.Location = new System.Drawing.Point(525, 748);
            this.guna2Button_print.Name = "guna2Button_print";
            this.guna2Button_print.ShadowDecoration.Parent = this.guna2Button_print;
            this.guna2Button_print.Size = new System.Drawing.Size(141, 39);
            this.guna2Button_print.TabIndex = 2;
            this.guna2Button_print.Text = "Print";
            this.guna2Button_print.Click += new System.EventHandler(this.guna2Button_print_Click);
            // 
            // label_total
            // 
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.Lime;
            this.label_total.Location = new System.Drawing.Point(448, 707);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(132, 27);
            this.label_total.TabIndex = 3;
            this.label_total.Text = "000";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(359, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(560, 707);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "vnđ";
            // 
            // label_bill
            // 
            this.label_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_bill.Location = new System.Drawing.Point(12, 9);
            this.label_bill.Name = "label_bill";
            this.label_bill.Size = new System.Drawing.Size(206, 40);
            this.label_bill.TabIndex = 6;
            this.label_bill.Text = "Bill - Ban So 00";
            this.label_bill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 4;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(364, 799);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(302, 39);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Pay";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(682, 848);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.label_bill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.guna2Button_print);
            this.Controls.Add(this.guna2Button_cancer);
            this.Controls.Add(this.dataGridView_bill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button_cancer;
        private Guna.UI2.WinForms.Guna2Button guna2Button_print;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        public System.Windows.Forms.Label label_total;
        public System.Windows.Forms.Label label_bill;
        public System.Windows.Forms.DataGridView dataGridView_bill;
    }
}