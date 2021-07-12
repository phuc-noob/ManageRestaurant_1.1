namespace ManageRestaurent1._1
{
    partial class cooker
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
            this.dataGridView_cooker = new System.Windows.Forms.DataGridView();
            this.guna2Button_cancer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_done = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cooker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cooker
            // 
            this.dataGridView_cooker.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_cooker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cooker.Location = new System.Drawing.Point(12, 71);
            this.dataGridView_cooker.Name = "dataGridView_cooker";
            this.dataGridView_cooker.RowHeadersWidth = 51;
            this.dataGridView_cooker.RowTemplate.Height = 24;
            this.dataGridView_cooker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cooker.Size = new System.Drawing.Size(743, 740);
            this.dataGridView_cooker.TabIndex = 0;
            // 
            // guna2Button_cancer
            // 
            this.guna2Button_cancer.BorderRadius = 3;
            this.guna2Button_cancer.CheckedState.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.CustomImages.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button_cancer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_cancer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_cancer.HoverState.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.Location = new System.Drawing.Point(607, 23);
            this.guna2Button_cancer.Name = "guna2Button_cancer";
            this.guna2Button_cancer.ShadowDecoration.Parent = this.guna2Button_cancer;
            this.guna2Button_cancer.Size = new System.Drawing.Size(148, 31);
            this.guna2Button_cancer.TabIndex = 1;
            this.guna2Button_cancer.Text = "Cheated";
            this.guna2Button_cancer.Click += new System.EventHandler(this.guna2Button_cancer_Click);
            // 
            // guna2Button_done
            // 
            this.guna2Button_done.BorderRadius = 3;
            this.guna2Button_done.CheckedState.Parent = this.guna2Button_done;
            this.guna2Button_done.CustomImages.Parent = this.guna2Button_done;
            this.guna2Button_done.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button_done.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_done.HoverState.Parent = this.guna2Button_done;
            this.guna2Button_done.Location = new System.Drawing.Point(436, 23);
            this.guna2Button_done.Name = "guna2Button_done";
            this.guna2Button_done.ShadowDecoration.Parent = this.guna2Button_done;
            this.guna2Button_done.Size = new System.Drawing.Size(152, 31);
            this.guna2Button_done.TabIndex = 2;
            this.guna2Button_done.Text = "hoàn tất";
            this.guna2Button_done.Click += new System.EventHandler(this.guna2Button_done_Click);
            // 
            // cooker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 823);
            this.Controls.Add(this.guna2Button_done);
            this.Controls.Add(this.guna2Button_cancer);
            this.Controls.Add(this.dataGridView_cooker);
            this.Name = "cooker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cooker";
            this.Load += new System.EventHandler(this.cooker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cooker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cooker;
        private Guna.UI2.WinForms.Guna2Button guna2Button_cancer;
        private Guna.UI2.WinForms.Guna2Button guna2Button_done;
    }
}