namespace ManageRestaurent1._1
{
    partial class scheduleListItem
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
            this.pictureBoxPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxPicture.Location = new System.Drawing.Point(6, 5);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxPicture.ShadowDecoration.Parent = this.pictureBoxPicture;
            this.pictureBoxPicture.Size = new System.Drawing.Size(55, 55);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPicture.TabIndex = 0;
            this.pictureBoxPicture.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(76, 10);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(12, 22);
            this.guna2HtmlLabel2.TabIndex = 16;
            this.guna2HtmlLabel2.Text = "#";
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelID.Location = new System.Drawing.Point(88, 8);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 22);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Location = new System.Drawing.Point(76, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 22);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStatus.Location = new System.Drawing.Point(333, 23);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(92, 22);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "Not Working";
            this.labelStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Enabled = false;
            this.guna2Button1.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(316, 25);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(13, 13);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // scheduleListItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxPicture);
            this.Name = "scheduleListItem";
            this.Size = new System.Drawing.Size(422, 65);
            this.Load += new System.EventHandler(this.scheduleListItem_Load);
            this.Click += new System.EventHandler(this.scheduleListItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxPicture;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelID;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelName;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelStatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
