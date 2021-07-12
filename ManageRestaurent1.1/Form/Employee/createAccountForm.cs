using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class createAccountForm : Form
    {
        private Guna.UI2.WinForms.Guna2Button buttonCreateAccount;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxConfirm;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSalary;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonClose;

        public createAccountForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
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
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.CheckedState.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.CustomImages.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonCreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAccount.HoverState.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.Location = new System.Drawing.Point(17, 312);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.ShadowDecoration.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.Size = new System.Drawing.Size(260, 40);
            this.buttonCreateAccount.TabIndex = 36;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator2.Location = new System.Drawing.Point(17, 278);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(260, 10);
            this.guna2Separator2.TabIndex = 35;
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
            this.textBoxConfirm.Location = new System.Drawing.Point(17, 256);
            this.textBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.PasswordChar = '*';
            this.textBoxConfirm.PlaceholderText = "";
            this.textBoxConfirm.SelectedText = "";
            this.textBoxConfirm.ShadowDecoration.Parent = this.textBoxConfirm;
            this.textBoxConfirm.Size = new System.Drawing.Size(260, 28);
            this.textBoxConfirm.TabIndex = 34;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator1.Location = new System.Drawing.Point(17, 210);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(260, 10);
            this.guna2Separator1.TabIndex = 33;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AutoRoundedCorners = true;
            this.textBoxPassword.BorderColor = System.Drawing.Color.Black;
            this.textBoxPassword.BorderRadius = 13;
            this.textBoxPassword.BorderThickness = 0;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.Parent = this.textBoxPassword;
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.FocusedState.Parent = this.textBoxPassword;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.HoverState.Parent = this.textBoxPassword;
            this.textBoxPassword.Location = new System.Drawing.Point(17, 188);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.ShadowDecoration.Parent = this.textBoxPassword;
            this.textBoxPassword.Size = new System.Drawing.Size(260, 28);
            this.textBoxPassword.TabIndex = 32;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator5.Location = new System.Drawing.Point(17, 137);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(260, 21);
            this.guna2Separator5.TabIndex = 31;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AutoRoundedCorners = true;
            this.textBoxUsername.BorderColor = System.Drawing.Color.Black;
            this.textBoxUsername.BorderRadius = 13;
            this.textBoxUsername.BorderThickness = 0;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.Parent = this.textBoxUsername;
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.FocusedState.Parent = this.textBoxUsername;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.HoverState.Parent = this.textBoxUsername;
            this.textBoxUsername.Location = new System.Drawing.Point(17, 115);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.ShadowDecoration.Parent = this.textBoxUsername;
            this.textBoxUsername.Size = new System.Drawing.Size(260, 28);
            this.textBoxUsername.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Confirm password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username";
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(17, 41);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(174, 31);
            this.labelSalary.TabIndex = 26;
            this.labelSalary.Text = "Create Account";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(300, 380);
            this.guna2Panel1.TabIndex = 52;
            // 
            // createAccountForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 380);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.guna2Separator5);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createAccountForm";
            this.Load += new System.EventHandler(this.createAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            try
            {
                if ((textBoxPassword.Text.ToString().Trim() != "") && (textBoxConfirm.Text.ToString().Trim() != ""))
                {
                    int username = Convert.ToInt32(textBoxUsername.Text);
                    if (account.CheckAccountExist(username))
                    {
                        MessageBox.Show("Account existed", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (PassWordConfirm())
                        {
                            string password = textBoxPassword.Text;
                            if (account.insertAccount(username, password))
                            {
                                MessageBox.Show("Account created", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Account not created", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mat khau nhap lai khong khop", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            }
        }

        public bool PassWordConfirm()
        {
            if (textBoxPassword.Text == textBoxConfirm.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void createAccountForm_Load(object sender, EventArgs e)
        {

        }

        public void formFill(int username)
        {
            textBoxUsername.Text = username.ToString();
        }
    }
}
