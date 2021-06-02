namespace ManageRestaurent1._1
{
    partial class typeFood
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
            this.Button_Table = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // Button_Table
            // 
            this.Button_Table.BackColor = System.Drawing.Color.Transparent;
            this.Button_Table.BorderRadius = 5;
            this.Button_Table.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Table.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Table.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.Button_Table.CheckedState.Parent = this.Button_Table;
            this.Button_Table.CustomImages.Parent = this.Button_Table;
            this.Button_Table.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Button_Table.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.Button_Table.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Table.ForeColor = System.Drawing.Color.OrangeRed;
            this.Button_Table.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Button_Table.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Button_Table.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Table.HoverState.Parent = this.Button_Table;
            this.Button_Table.Image = global::ManageRestaurent1._1.Properties.Resources.New_Order_512_removebg_preview;
            this.Button_Table.ImageSize = new System.Drawing.Size(60, 32);
            this.Button_Table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_Table.Location = new System.Drawing.Point(0, 0);
            this.Button_Table.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Table.Name = "Button_Table";
            this.Button_Table.ShadowDecoration.Parent = this.Button_Table;
            this.Button_Table.Size = new System.Drawing.Size(111, 88);
            this.Button_Table.TabIndex = 31;
            this.Button_Table.Text = "Table";
            this.Button_Table.Click += new System.EventHandler(this.Button_Table_Click);
            // 
            // typeFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Button_Table);
            this.Name = "typeFood";
            this.Size = new System.Drawing.Size(111, 88);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton Button_Table;
    }
}
