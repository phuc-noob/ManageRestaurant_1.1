namespace ManageRestaurent1._1
{
    partial class itemEmployee
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
            this.guna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button
            // 
            this.guna2Button.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button.BorderRadius = 4;
            this.guna2Button.CheckedState.Parent = this.guna2Button;
            this.guna2Button.CustomImages.Parent = this.guna2Button;
            this.guna2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button.ForeColor = System.Drawing.Color.Blue;
            this.guna2Button.HoverState.Parent = this.guna2Button;
            this.guna2Button.Location = new System.Drawing.Point(3, 3);
            this.guna2Button.Name = "guna2Button";
            this.guna2Button.ShadowDecoration.Parent = this.guna2Button;
            this.guna2Button.Size = new System.Drawing.Size(195, 116);
            this.guna2Button.TabIndex = 0;
            this.guna2Button.Text = "Function";
            this.guna2Button.Click += new System.EventHandler(this.guna2Button_Click);
            // 
            // itemEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Button);
            this.Name = "itemEmployee";
            this.Size = new System.Drawing.Size(204, 124);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button guna2Button;
    }
}
