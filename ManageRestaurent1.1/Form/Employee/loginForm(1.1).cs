using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class loginForm_1 : Form
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSalary;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxJob;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;

        public loginForm_1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxJob = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(28, 33);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(130, 62);
            this.labelSalary.TabIndex = 8;
            this.labelSalary.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AutoRoundedCorners = true;
            this.textBoxPassword.BorderRadius = 19;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.Parent = this.textBoxPassword;
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.FocusedState.Parent = this.textBoxPassword;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.HoverState.Parent = this.textBoxPassword;
            this.textBoxPassword.Location = new System.Drawing.Point(25, 256);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.ShadowDecoration.Parent = this.textBoxPassword;
            this.textBoxPassword.Size = new System.Drawing.Size(298, 40);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AutoRoundedCorners = true;
            this.textBoxUsername.BorderRadius = 19;
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
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.HoverState.Parent = this.textBoxUsername;
            this.textBoxUsername.Location = new System.Drawing.Point(25, 193);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.PlaceholderText = "Username";
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.ShadowDecoration.Parent = this.textBoxUsername;
            this.textBoxUsername.Size = new System.Drawing.Size(298, 40);
            this.textBoxUsername.TabIndex = 12;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.AutoRoundedCorners = true;
            this.comboBoxJob.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxJob.BorderRadius = 17;
            this.comboBoxJob.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxJob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxJob.FocusedState.Parent = this.comboBoxJob;
            this.comboBoxJob.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxJob.ForeColor = System.Drawing.Color.Black;
            this.comboBoxJob.HoverState.Parent = this.comboBoxJob;
            this.comboBoxJob.ItemHeight = 30;
            this.comboBoxJob.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Owner"});
            this.comboBoxJob.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.comboBoxJob.ItemsAppearance.Parent = this.comboBoxJob;
            this.comboBoxJob.Location = new System.Drawing.Point(25, 134);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.ShadowDecoration.Parent = this.comboBoxJob;
            this.comboBoxJob.Size = new System.Drawing.Size(298, 36);
            this.comboBoxJob.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.comboBoxJob);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Location = new System.Drawing.Point(498, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 399);
            this.panel1.TabIndex = 17;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(25, 102);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(298, 22);
            this.guna2Separator1.TabIndex = 16;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::ManageRestaurent1._1.Properties.Resources.foodtest41;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(463, 537);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoRoundedCorners = true;
            this.buttonLogin.BorderRadius = 19;
            this.buttonLogin.CheckedState.Parent = this.buttonLogin;
            this.buttonLogin.CustomImages.Parent = this.buttonLogin;
            this.buttonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.HoverState.Parent = this.buttonLogin;
            this.buttonLogin.Image = global::ManageRestaurent1._1.Properties.Resources.right_arrow__2_;
            this.buttonLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonLogin.Location = new System.Drawing.Point(25, 319);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.ShadowDecoration.Parent = this.buttonLogin;
            this.buttonLogin.Size = new System.Drawing.Size(298, 40);
            this.buttonLogin.TabIndex = 14;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // loginForm_1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 537);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "loginForm_1";
            this.Load += new System.EventHandler(this.loginForm_1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void loginForm_1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxJob.SelectedItem != null)
                {
                    string job = comboBoxJob.SelectedItem.ToString();
                    if (job == "Employee")
                    {
                        try
                        {
                            Global.isMangage = false;
                            myDB db = new myDB();
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            DataTable table = new DataTable();
                            SqlCommand command = new SqlCommand("SELECT * FROM Account, Nhanvien, Congviec WHERE username = msnv AND" +
                                " congviec = macv AND username = @User AND password = @Pass AND noidungcv = 'Nhan vien'", db.GetConnection);

                            command.Parameters.Add("@User", SqlDbType.VarChar).Value = Convert.ToInt32(textBoxUsername.Text);
                            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

                            adapter.SelectCommand = command;

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                mainForm frmMain = new mainForm();
                                Global.SetGlobalUserId(Convert.ToInt32(textBoxUsername.Text));
                                frmMain.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (job == "Manager")
                    {
                        try
                        {
                            Global.isMangage = true;
                            myDB db = new myDB();
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            DataTable table = new DataTable();
                            SqlCommand command = new SqlCommand("SELECT * FROM Account, Nhanvien, Congviec WHERE username = msnv AND" +
                                " congviec = macv AND username = @User AND password = @Pass AND noidungcv = 'Quan ly'", db.GetConnection);

                            command.Parameters.Add("@User", SqlDbType.VarChar).Value = Convert.ToInt32(textBoxUsername.Text);
                            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

                            adapter.SelectCommand = command;

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                mainForm frmMain = new mainForm();
                                Global.SetGlobalUserId(Convert.ToInt32(textBoxUsername.Text));
                                frmMain.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (job == "Owner")
                    {
                        try
                        {
                            myDB db = new myDB();
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            DataTable table = new DataTable();
                            SqlCommand command = new SqlCommand("SELECT * FROM hr " +
                                "WHERE username = @User AND password = @Pass ", db.GetConnection);

                            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

                            adapter.SelectCommand = command;

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                mainForm frmMain = new mainForm();
                                Global.SetGlobalUserId(0);
                                frmMain.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select your role", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }
    }
}
