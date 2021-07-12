using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class changePasswordForm_1 : Form
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSalary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxOldPassword;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNewPassword;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxConfirm;
        private Guna.UI2.WinForms.Guna2Button buttonUpdatePassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonClose;

        public changePasswordForm_1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonUpdatePassword = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(17, 40);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(177, 31);
            this.labelSalary.TabIndex = 13;
            this.labelSalary.Text = "Reset Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirm new password";
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator5.Location = new System.Drawing.Point(17, 136);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(260, 21);
            this.guna2Separator5.TabIndex = 20;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.AutoRoundedCorners = true;
            this.textBoxOldPassword.BorderColor = System.Drawing.Color.Black;
            this.textBoxOldPassword.BorderRadius = 13;
            this.textBoxOldPassword.BorderThickness = 0;
            this.textBoxOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOldPassword.DefaultText = "";
            this.textBoxOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOldPassword.DisabledState.Parent = this.textBoxOldPassword;
            this.textBoxOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOldPassword.FocusedState.Parent = this.textBoxOldPassword;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOldPassword.HoverState.Parent = this.textBoxOldPassword;
            this.textBoxOldPassword.Location = new System.Drawing.Point(17, 114);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.PlaceholderText = "";
            this.textBoxOldPassword.SelectedText = "";
            this.textBoxOldPassword.ShadowDecoration.Parent = this.textBoxOldPassword;
            this.textBoxOldPassword.Size = new System.Drawing.Size(260, 28);
            this.textBoxOldPassword.TabIndex = 19;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator1.Location = new System.Drawing.Point(17, 203);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(260, 10);
            this.guna2Separator1.TabIndex = 22;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.AutoRoundedCorners = true;
            this.textBoxNewPassword.BorderColor = System.Drawing.Color.Black;
            this.textBoxNewPassword.BorderRadius = 13;
            this.textBoxNewPassword.BorderThickness = 0;
            this.textBoxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNewPassword.DefaultText = "";
            this.textBoxNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNewPassword.DisabledState.Parent = this.textBoxNewPassword;
            this.textBoxNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNewPassword.FocusedState.Parent = this.textBoxNewPassword;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNewPassword.HoverState.Parent = this.textBoxNewPassword;
            this.textBoxNewPassword.Location = new System.Drawing.Point(17, 181);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.PlaceholderText = "";
            this.textBoxNewPassword.SelectedText = "";
            this.textBoxNewPassword.ShadowDecoration.Parent = this.textBoxNewPassword;
            this.textBoxNewPassword.Size = new System.Drawing.Size(260, 28);
            this.textBoxNewPassword.TabIndex = 21;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator2.Location = new System.Drawing.Point(17, 271);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(260, 10);
            this.guna2Separator2.TabIndex = 24;
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.AutoRoundedCorners = true;
            this.textBoxConfirm.BorderColor = System.Drawing.Color.Black;
            this.textBoxConfirm.BorderRadius = 13;
            this.textBoxConfirm.BorderThickness = 0;
            this.textBoxConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConfirm.DefaultText = "";
            this.textBoxConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxConfirm.DisabledState.Parent = this.textBoxConfirm;
            this.textBoxConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxConfirm.FocusedState.Parent = this.textBoxConfirm;
            this.textBoxConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxConfirm.HoverState.Parent = this.textBoxConfirm;
            this.textBoxConfirm.Location = new System.Drawing.Point(17, 249);
            this.textBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.PasswordChar = '*';
            this.textBoxConfirm.PlaceholderText = "";
            this.textBoxConfirm.SelectedText = "";
            this.textBoxConfirm.ShadowDecoration.Parent = this.textBoxConfirm;
            this.textBoxConfirm.Size = new System.Drawing.Size(260, 28);
            this.textBoxConfirm.TabIndex = 23;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.CheckedState.Parent = this.buttonUpdatePassword;
            this.buttonUpdatePassword.CustomImages.Parent = this.buttonUpdatePassword;
            this.buttonUpdatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonUpdatePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.buttonUpdatePassword.HoverState.Parent = this.buttonUpdatePassword;
            this.buttonUpdatePassword.Location = new System.Drawing.Point(17, 294);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.ShadowDecoration.Parent = this.buttonUpdatePassword;
            this.buttonUpdatePassword.Size = new System.Drawing.Size(260, 40);
            this.buttonUpdatePassword.TabIndex = 25;
            this.buttonUpdatePassword.Text = "UPDATE PASSWORD";
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BorderColor = System.Drawing.Color.Transparent;
            this.buttonClose.CheckedState.Parent = this.buttonClose;
            this.buttonClose.CustomImages.Parent = this.buttonClose;
            this.buttonClose.FillColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.Parent = this.buttonClose;
            this.buttonClose.Image = global::ManageRestaurent1._1.Properties.Resources.left_arrow;
            this.buttonClose.Location = new System.Drawing.Point(5, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonClose.ShadowDecoration.Parent = this.buttonClose;
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(306, 363);
            this.guna2Panel1.TabIndex = 26;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // changePasswordForm_1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 363);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.guna2Separator5);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changePasswordForm_1";
            this.Load += new System.EventHandler(this.changePasswordForm_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void changePasswordForm_1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            if (Global.GlobalUserId != 0)
            {
                Account account = new Account();
                string oldPassword = textBoxOldPassword.Text;
                string newPassword = textBoxNewPassword.Text;
                if (verif())
                {
                    if (account.checkPassword(Global.GlobalUserId, oldPassword))
                    {
                        if (PassWordConfirm())
                        {
                            if (account.updateAccount(Global.GlobalUserId, newPassword))
                            {
                                MessageBox.Show("Successful", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mat khau nhap lai khong khop", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                User user = new User();
                string oldPassword = textBoxOldPassword.Text;
                string newPassword = textBoxNewPassword.Text;
                if (verif())
                {
                    if (user.checkPassword(oldPassword))
                    {
                        if (PassWordConfirm())
                        {
                            if (user.updateAccount(newPassword))
                            {
                                MessageBox.Show("Successful", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mat khau nhap lai khong khop", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool verif()
        {
            if (textBoxOldPassword.Text.Trim() == "" || textBoxNewPassword.Text.Trim() == "" || textBoxConfirm.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool PassWordConfirm()
        {
            if (textBoxNewPassword.Text == textBoxConfirm.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // move form when formborderstype is none
        


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        //----------end of move form -------------
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
