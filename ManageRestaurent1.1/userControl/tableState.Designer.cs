namespace ManageRestaurent1._1
{
    partial class tableState
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
            this.guna2Button_label = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button_label
            // 
            this.guna2Button_label.BorderRadius = 7;
            this.guna2Button_label.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_label.CheckedState.Parent = this.guna2Button_label;
            this.guna2Button_label.CustomImages.Parent = this.guna2Button_label;
            this.guna2Button_label.Font = new System.Drawing.Font("VNI-Briquet", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_label.ForeColor = System.Drawing.Color.White;
            this.guna2Button_label.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_label.HoverState.Parent = this.guna2Button_label;
            this.guna2Button_label.Location = new System.Drawing.Point(1, 1);
            this.guna2Button_label.Name = "guna2Button_label";
            this.guna2Button_label.ShadowDecoration.Parent = this.guna2Button_label;
            this.guna2Button_label.Size = new System.Drawing.Size(253, 126);
            this.guna2Button_label.TabIndex = 0;
            this.guna2Button_label.Text = "Table - 00";
            this.guna2Button_label.Click += new System.EventHandler(this.guna2Button_label_Click);
            // 
            // tableState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Button_label);
            this.Name = "tableState";
            this.Size = new System.Drawing.Size(253, 126);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button guna2Button_label;
    }
}
