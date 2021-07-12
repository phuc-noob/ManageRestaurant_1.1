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
    class numberOfEmployeeForm : Form
    {
        private Guna.UI2.WinForms.Guna2TextBox textBoxSoNVCa1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSoNVCa2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSoNVCa3;
        private Guna.UI2.WinForms.Guna2CircleButton buttonClose;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button buttonOK;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTotal;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRole;
        private Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSalary;

        public numberOfEmployeeForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxSoNVCa1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoNVCa2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoNVCa3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.buttonOK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboBoxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSoNVCa1
            // 
            this.textBoxSoNVCa1.AutoRoundedCorners = true;
            this.textBoxSoNVCa1.BorderColor = System.Drawing.Color.Black;
            this.textBoxSoNVCa1.BorderRadius = 13;
            this.textBoxSoNVCa1.BorderThickness = 0;
            this.textBoxSoNVCa1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSoNVCa1.DefaultText = "";
            this.textBoxSoNVCa1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSoNVCa1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSoNVCa1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSoNVCa1.DisabledState.Parent = this.textBoxSoNVCa1;
            this.textBoxSoNVCa1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSoNVCa1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSoNVCa1.FocusedState.Parent = this.textBoxSoNVCa1;
            this.textBoxSoNVCa1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoNVCa1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSoNVCa1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSoNVCa1.HoverState.Parent = this.textBoxSoNVCa1;
            this.textBoxSoNVCa1.Location = new System.Drawing.Point(21, 174);
            this.textBoxSoNVCa1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSoNVCa1.Name = "textBoxSoNVCa1";
            this.textBoxSoNVCa1.PasswordChar = '\0';
            this.textBoxSoNVCa1.PlaceholderText = "";
            this.textBoxSoNVCa1.SelectedText = "";
            this.textBoxSoNVCa1.ShadowDecoration.Parent = this.textBoxSoNVCa1;
            this.textBoxSoNVCa1.Size = new System.Drawing.Size(260, 28);
            this.textBoxSoNVCa1.TabIndex = 57;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator5.Location = new System.Drawing.Point(21, 196);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(260, 21);
            this.guna2Separator5.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "So luong nhan vien ca 3";
            // 
            // textBoxSoNVCa2
            // 
            this.textBoxSoNVCa2.AutoRoundedCorners = true;
            this.textBoxSoNVCa2.BorderColor = System.Drawing.Color.Black;
            this.textBoxSoNVCa2.BorderRadius = 13;
            this.textBoxSoNVCa2.BorderThickness = 0;
            this.textBoxSoNVCa2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSoNVCa2.DefaultText = "";
            this.textBoxSoNVCa2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSoNVCa2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSoNVCa2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSoNVCa2.DisabledState.Parent = this.textBoxSoNVCa2;
            this.textBoxSoNVCa2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSoNVCa2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSoNVCa2.FocusedState.Parent = this.textBoxSoNVCa2;
            this.textBoxSoNVCa2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoNVCa2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSoNVCa2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSoNVCa2.HoverState.Parent = this.textBoxSoNVCa2;
            this.textBoxSoNVCa2.Location = new System.Drawing.Point(21, 241);
            this.textBoxSoNVCa2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSoNVCa2.Name = "textBoxSoNVCa2";
            this.textBoxSoNVCa2.PasswordChar = '\0';
            this.textBoxSoNVCa2.PlaceholderText = "";
            this.textBoxSoNVCa2.SelectedText = "";
            this.textBoxSoNVCa2.ShadowDecoration.Parent = this.textBoxSoNVCa2;
            this.textBoxSoNVCa2.Size = new System.Drawing.Size(260, 28);
            this.textBoxSoNVCa2.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "So luong nhan vien ca 2";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator1.Location = new System.Drawing.Point(21, 263);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(260, 10);
            this.guna2Separator1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "So luong nhan vien ca 1";
            // 
            // textBoxSoNVCa3
            // 
            this.textBoxSoNVCa3.AutoRoundedCorners = true;
            this.textBoxSoNVCa3.BorderColor = System.Drawing.Color.Black;
            this.textBoxSoNVCa3.BorderRadius = 13;
            this.textBoxSoNVCa3.BorderThickness = 0;
            this.textBoxSoNVCa3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSoNVCa3.DefaultText = "";
            this.textBoxSoNVCa3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSoNVCa3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSoNVCa3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSoNVCa3.DisabledState.Parent = this.textBoxSoNVCa3;
            this.textBoxSoNVCa3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSoNVCa3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSoNVCa3.FocusedState.Parent = this.textBoxSoNVCa3;
            this.textBoxSoNVCa3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoNVCa3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSoNVCa3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSoNVCa3.HoverState.Parent = this.textBoxSoNVCa3;
            this.textBoxSoNVCa3.Location = new System.Drawing.Point(21, 309);
            this.textBoxSoNVCa3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSoNVCa3.Name = "textBoxSoNVCa3";
            this.textBoxSoNVCa3.PasswordChar = '\0';
            this.textBoxSoNVCa3.PlaceholderText = "";
            this.textBoxSoNVCa3.SelectedText = "";
            this.textBoxSoNVCa3.ShadowDecoration.Parent = this.textBoxSoNVCa3;
            this.textBoxSoNVCa3.Size = new System.Drawing.Size(260, 28);
            this.textBoxSoNVCa3.TabIndex = 61;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator2.Location = new System.Drawing.Point(21, 331);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(260, 10);
            this.guna2Separator2.TabIndex = 62;
            // 
            // buttonOK
            // 
            this.buttonOK.CheckedState.Parent = this.buttonOK;
            this.buttonOK.CustomImages.Parent = this.buttonOK;
            this.buttonOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.HoverState.Parent = this.buttonOK;
            this.buttonOK.Location = new System.Drawing.Point(87, 350);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.ShadowDecoration.Parent = this.buttonOK;
            this.buttonOK.Size = new System.Drawing.Size(121, 40);
            this.buttonOK.TabIndex = 63;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.comboBoxRole);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.labelTotal);
            this.guna2Panel1.Controls.Add(this.buttonOK);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.buttonClose);
            this.guna2Panel1.Controls.Add(this.textBoxSoNVCa3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.textBoxSoNVCa2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.guna2Separator5);
            this.guna2Panel1.Controls.Add(this.textBoxSoNVCa1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(302, 413);
            this.guna2Panel1.TabIndex = 64;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRole.FocusedState.Parent = this.comboBoxRole;
            this.comboBoxRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxRole.HoverState.Parent = this.comboBoxRole;
            this.comboBoxRole.ItemHeight = 30;
            this.comboBoxRole.Items.AddRange(new object[] {
            "All",
            "Manager",
            "Employee"});
            this.comboBoxRole.ItemsAppearance.Parent = this.comboBoxRole;
            this.comboBoxRole.Location = new System.Drawing.Point(21, 113);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.ShadowDecoration.Parent = this.comboBoxRole;
            this.comboBoxRole.Size = new System.Drawing.Size(260, 36);
            this.comboBoxRole.TabIndex = 66;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Role";
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(21, 44);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(181, 31);
            this.labelTotal.TabIndex = 64;
            this.labelTotal.Text = "Total Employee:";
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
            this.buttonClose.Location = new System.Drawing.Point(9, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonClose.ShadowDecoration.Parent = this.buttonClose;
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 52;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(21, 44);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(181, 31);
            this.labelSalary.TabIndex = 53;
            this.labelSalary.Text = "Total Employee:";
            // 
            // numberOfEmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(302, 413);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "numberOfEmployeeForm";
            this.Load += new System.EventHandler(this.numberOfEmployeeForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        Employee employee = new Employee();
        PhanCa phanCa = new PhanCa();
        Job job = new Job();

        private void numberOfEmployeeForm_Load(object sender, EventArgs e)
        {
            labelTotal.Text = ("Total Employee: " + employee.getTotalNV());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                if (comboBoxRole.SelectedItem != null)
                {
                    string cv = comboBoxRole.SelectedItem.ToString();
                    if (cv == "Manager")
                    {
                        phanCaQuanLy();
                    }
                    else if (cv == "Employee")
                    {
                        phanCaNhanVien();
                    }
                    else if (cv == "All")
                    {
                        phanCaQuanLy();
                        phanCaNhanVien();
                    }
                }
            /*}
            catch
            {

            }*/

            /*try
            {
                int totalEmployee = employee.getTotalNV();
                int count1 = Convert.ToInt32(textBoxSoNVCa1.Text);
                int count2 = Convert.ToInt32(textBoxSoNVCa2.Text);
                int count3 = Convert.ToInt32(textBoxSoNVCa3.Text);
                if (totalEmployee == (count1 + count2 + count3) / 2)
                {
                    if ((count3 > count1 + count2 + 1) || (count2 > count1 + count3 + 1) || (count1 > count2 + count3 + 1))
                    {
                        MessageBox.Show("So ca khong dung", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int slnvc12 = count1 + count2 - totalEmployee;
                        int slnvc13 = count1 + count3 - totalEmployee;
                        int slnvc23 = count2 + count3 - totalEmployee;
                        SqlCommand command = new SqlCommand("SELECT * FROM Phanca AS P, Nhanvien AS N, Congviec WHERE P.msnv = N.msnv AND congviec = macv AND noidungcv = 'Nhan vien'");
                        DataTable table = phanCa.getPhanCa(command);

                        List<int> Listc12 = new List<int>();
                        List<int> Listc13 = new List<int>();
                        List<int> Listc23 = new List<int>();

                        if (table.Rows.Count == 0)
                        {
                            SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien'");
                            DataTable table1 = employee.getEmployees(command1);

                            for (int i = 0; i < totalEmployee; i++)
                            {
                                if (i < slnvc12)
                                {
                                    Listc12.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }
                                else if (i < slnvc12 + slnvc13)
                                {
                                    Listc13.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }
                                else
                                {
                                    Listc23.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }
                            }
                        }
                        else
                        {
                            SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien WHERE msnv not in (SELECT DISTINCT msnv FROM Phanca)" +
                                " AND msnv in (SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien')");

                            DataTable dsnvm = employee.getEmployees(command1);

                            DataTable dsnvCa12 = employee.getEmployeeByPhancong(1, 2);
                            Listc12 = convertDataTableToList(dsnvCa12);
                            DataTable dsnvCa13 = employee.getEmployeeByPhancong(1, 3);
                            Listc13 = convertDataTableToList(dsnvCa13);
                            DataTable dsnvCa23 = employee.getEmployeeByPhancong(2, 3);
                            Listc23 = convertDataTableToList(dsnvCa23);

                            int length12 = Listc12.Count;
                            int length13 = Listc13.Count;
                            int length23 = Listc23.Count;
                            if (length13 > slnvc13)
                            {
                                if (length23 < slnvc23)
                                {
                                    chuanHoaPhai(ref length13, slnvc13, ref length23, slnvc23, Listc13, Listc23);
                                }
                                if (length12 < slnvc12)
                                {
                                    chuanHoaTrai(ref length13, slnvc13, ref length12, slnvc12, Listc13, Listc12);
                                }
                            }

                            if (length12 > slnvc12)
                            {
                                if (length13 < slnvc13)
                                {
                                    chuanHoaPhai(ref length12, slnvc12, ref length13, slnvc13, Listc12, Listc13);
                                }
                                if (length23 < slnvc23)
                                {
                                    chuanHoaTrai(ref length12, slnvc12, ref length23, slnvc23, Listc12, Listc23);
                                }
                            }

                            if (length23 > slnvc23)
                            {
                                if (length12 < slnvc12)
                                {
                                    chuanHoaPhai(ref length23, slnvc23, ref length12, slnvc12, Listc23, Listc12);
                                }
                                if (length13 < slnvc13)
                                {
                                    chuanHoaTrai(ref length23, slnvc23, ref length13, slnvc13, Listc23, Listc13);
                                }
                            }

                            int heSoSwap = Min(length12, length13, length23);

                            if (heSoSwap != 0)
                            {
                                if (check0(slnvc12))
                                {
                                    if (check0(slnvc13))
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc13.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc23.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                                Listc12.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc13.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc12.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc23.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc12.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (check0(slnvc13))
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc23.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                                Listc13.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                    }
                                }
                            }

                            for (int i = 0; i < dsnvm.Rows.Count; i++)
                            {
                                if (length12 < slnvc12)
                                {
                                    Listc12.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                    length12++;
                                }
                                else
                                {
                                    if (length13 < slnvc13)
                                    {
                                        Listc13.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                        length13++;
                                    }
                                    else if (length23 < slnvc23)
                                    {
                                        Listc23.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                        length23++;
                                    }
                                }
                            }
                        }

                        int[] A = this.phanCaQuanLy();

                        phanCa.deleteAllPhanCa();

                        if (A != null)
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                phanCa.insertPhanCa(A[i], i, i);
                            }
                        }

                        for (int i = 0; i < slnvc12; i++)
                        {
                            phanCa.insertPhanCa(Listc12[i], 1, slnvc12 - i);
                            phanCa.insertPhanCa(Listc12[i], 2, slnvc12 - i);
                        }

                        for (int i = 0; i < slnvc13; i++)
                        {
                            phanCa.insertPhanCa(Listc13[i], 1, slnvc13 - i);
                            phanCa.insertPhanCa(Listc13[i], 3, slnvc13 - i);
                        }

                        for (int i = 0; i < slnvc23; i++)
                        {
                            phanCa.insertPhanCa(Listc23[i], 2, slnvc23 - i);
                            phanCa.insertPhanCa(Listc23[i], 3, slnvc23 - i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("So ca khong dung", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui long nhap chinh xac", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        public void phanCaNhanVien()
        {
            try
            {
                int totalEmployee = employee.getTotalNV();
                int count1 = Convert.ToInt32(textBoxSoNVCa1.Text);
                int count2 = Convert.ToInt32(textBoxSoNVCa2.Text);
                int count3 = Convert.ToInt32(textBoxSoNVCa3.Text);
                if (totalEmployee == (count1 + count2 + count3) / 2)
                {
                    if ((count3 > count1 + count2 + 1) || (count2 > count1 + count3 + 1) || (count1 > count2 + count3 + 1))
                    {
                        MessageBox.Show("So ca khong dung", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int slnvc12 = count1 + count2 - totalEmployee;
                        int slnvc13 = count1 + count3 - totalEmployee;
                        int slnvc23 = count2 + count3 - totalEmployee;
                        SqlCommand command = new SqlCommand("SELECT * FROM Phanca AS P, Nhanvien AS N, Congviec WHERE P.msnv = N.msnv AND congviec = macv AND noidungcv = 'Nhan vien'");
                        DataTable table = phanCa.getPhanCa(command);

                        List<int> Listc12 = new List<int>();
                        List<int> Listc13 = new List<int>();
                        List<int> Listc23 = new List<int>();

                        if (table.Rows.Count == 0)
                        {
                            SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien'");
                            DataTable table1 = employee.getEmployees(command1);

                            for (int i = 0; i < totalEmployee; i++)
                            {
                                if (i < slnvc12)
                                {
                                    Listc12.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }
                                else if (i < slnvc12 + slnvc13)
                                {
                                    Listc13.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }
                                else
                                {
                                    Listc23.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }
                            }
                        }
                        else
                        {
                            SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien WHERE msnv not in (SELECT DISTINCT msnv FROM Phanca)" +
                                " AND msnv in (SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien')");

                            DataTable dsnvm = employee.getEmployees(command1);

                            DataTable dsnvCa12 = employee.getEmployeeByPhancong(1, 2);
                            Listc12 = convertDataTableToList(dsnvCa12);
                            DataTable dsnvCa13 = employee.getEmployeeByPhancong(1, 3);
                            Listc13 = convertDataTableToList(dsnvCa13);
                            DataTable dsnvCa23 = employee.getEmployeeByPhancong(2, 3);
                            Listc23 = convertDataTableToList(dsnvCa23);

                            int length12 = Listc12.Count;
                            int length13 = Listc13.Count;
                            int length23 = Listc23.Count;
                            if (length13 > slnvc13)
                            {
                                if (length23 < slnvc23)
                                {
                                    chuanHoaPhai(ref length13, slnvc13, ref length23, slnvc23, Listc13, Listc23);
                                }
                                if (length12 < slnvc12)
                                {
                                    chuanHoaTrai(ref length13, slnvc13, ref length12, slnvc12, Listc13, Listc12);
                                }
                            }

                            if (length12 > slnvc12)
                            {
                                if (length13 < slnvc13)
                                {
                                    chuanHoaPhai(ref length12, slnvc12, ref length13, slnvc13, Listc12, Listc13);
                                }
                                if (length23 < slnvc23)
                                {
                                    chuanHoaTrai(ref length12, slnvc12, ref length23, slnvc23, Listc12, Listc23);
                                }
                            }

                            if (length23 > slnvc23)
                            {
                                if (length12 < slnvc12)
                                {
                                    chuanHoaPhai(ref length23, slnvc23, ref length12, slnvc12, Listc23, Listc12);
                                }
                                if (length13 < slnvc13)
                                {
                                    chuanHoaTrai(ref length23, slnvc23, ref length13, slnvc13, Listc23, Listc13);
                                }
                            }

                            int heSoSwap = Min(length12, length13, length23);

                            if (heSoSwap != 0)
                            {
                                if (check0(slnvc12))
                                {
                                    if (check0(slnvc13))
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc13.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc23.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                                Listc12.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc13.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc12.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc23.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc12.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (check0(slnvc13))
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc23.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                                Listc13.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                    }
                                }
                            }

                            for (int i = 0; i < dsnvm.Rows.Count; i++)
                            {
                                if (length12 < slnvc12)
                                {
                                    Listc12.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                    length12++;
                                }
                                else
                                {
                                    if (length13 < slnvc13)
                                    {
                                        Listc13.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                        length13++;
                                    }
                                    else if (length23 < slnvc23)
                                    {
                                        Listc23.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                        length23++;
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < slnvc12; i++)
                        {
                            phanCa.deletePhanCa(Listc12[i]);
                            phanCa.insertPhanCa(Listc12[i], 1, slnvc12 - i);
                            phanCa.insertPhanCa(Listc12[i], 2, slnvc12 - i);
                        }

                        for (int i = 0; i < slnvc13; i++)
                        {
                            phanCa.deletePhanCa(Listc13[i]);
                            phanCa.insertPhanCa(Listc13[i], 1, slnvc13 - i);
                            phanCa.insertPhanCa(Listc13[i], 3, slnvc13 - i);
                        }

                        for (int i = 0; i < slnvc23; i++)
                        {
                            phanCa.deletePhanCa(Listc23[i]);
                            phanCa.insertPhanCa(Listc23[i], 2, slnvc23 - i);
                            phanCa.insertPhanCa(Listc23[i], 3, slnvc23 - i);
                        }

                        MessageBox.Show("Da Phan Ca Nhan vien", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("So ca khong dung", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui long nhap chinh xac", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<int> convertDataTableToList(DataTable table)
        {
            List<int> l = new List<int>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                l.Add(Convert.ToInt32(table.Rows[i]["msnv"].ToString()));
            }
            return l;
        }

        public void chuanHoaTrai(ref int length1, int slnv1, ref int length2, int slnv2, List<int> l1, List<int> l2)
        {
            while (length1 > slnv1)
            {
                if (length2 < slnv2)
                {
                    l2.Insert(0, (l1[length1 - 1]));
                    l1.RemoveAt(length1 - 1);
                    length1--;
                    length2++;
                }
                else
                {
                    break;
                }
            }
        }

        public void chuanHoaPhai(ref int length1, int slnv1, ref int length2, int slnv2, List<int> l1, List<int> l2)
        {
            while (length1 > slnv1)
            {
                if (length2 < slnv2)
                {
                    l2.Add(l1[0]);
                    l1.RemoveAt(0);
                    length1--;
                    length2++;
                }
                else
                {
                    break;
                }
            }
        }

        public bool check0(int a)
        {
            if (a != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Min(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return c;
                }
                else
                {
                    if (b > c && c != 0)
                    {
                        b = c;
                    }
                    return b;
                }
            }
            else
            {
                if (a > b && b != 0)
                {
                    a = b;
                }
                if (a > c && c != 0)
                {
                    a = c;
                }
            }
            return a;
        }

        public void phanCaQuanLy()
        {
            int[] A = new int[4];

            SqlCommand com = new SqlCommand("SELECT * FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Quan ly'");
            DataTable tab = employee.getEmployees(com);
            if (tab.Rows.Count == 0)
            {
                MessageBox.Show("Da Phan Ca Quan li", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tab.Rows.Count == 1)
            {
                int msnv = Convert.ToInt32(tab.Rows[0]["msnv"].ToString());
                for (int i = 1; i < 4; i++)
                {
                    A[i] = msnv;
                }
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Quan ly' " +
                    " AND msnv in (SELECT msnv FROM Phanca)");
                DataTable table = employee.getEmployees(command);

                if (table.Rows.Count == 0)
                {
                    SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Quan ly'");
                    DataTable table1 = employee.getEmployees(command1);
                    A[1] = Convert.ToInt32(table1.Rows[0]["msnv"].ToString());
                    A[2] = Convert.ToInt32(table1.Rows[0]["msnv"].ToString());
                    A[3] = Convert.ToInt32(table1.Rows[1]["msnv"].ToString());
                }
                else if (table.Rows.Count == 2)
                {
                    SqlCommand command1 = new SqlCommand("SELECT N.msnv, P.maca FROM Nhanvien AS N, Phanca AS P, Congviec AS C " +
                        "WHERE N.msnv = P.msnv AND congviec = C.macv AND noidungcv = 'Quan ly'");
                    DataTable table1 = employee.getEmployees(command1);

                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        A[Convert.ToInt32(table1.Rows[i]["maca"].ToString())] = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                    }
                }
                else
                {
                    SqlCommand command1 = new SqlCommand("SELECT N.msnv, P.maca FROM Nhanvien AS N, Phanca AS P, Congviec AS C " +
                        "WHERE N.msnv = P.msnv AND congviec = C.macv AND noidungcv = 'Quan ly'");
                    DataTable table1 = employee.getEmployees(command1);
                    SqlCommand command2 = new SqlCommand("SELECT N.msnv, P.maca FROM Nhanvien AS N, Congviec AS C " +
                        "WHERE congviec = C.macv AND noidungcv = 'Quan ly' AND N.msnv not in (SELECT msnv FROM Phanca)");
                    DataTable table2 = employee.getEmployees(command2);
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        A[Convert.ToInt32(table1.Rows[i]["maca"].ToString())] = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                    }
                    for (int i = 1; i < 4; i++)
                    {
                        if (A[i] == 0)
                        {
                            A[i] = Convert.ToInt32(table2.Rows[0]["msnv"].ToString());
                        }
                    }
                }

                int temp = A[1];
                for (int i = 1; i < 3; i++)
                {
                    A[i] = A[i + 1];
                }
                A[3] = temp;

                if (A[1] == A[2])
                {
                    temp = A[1];
                    A[1] = A[3];
                    A[2] = A[3];
                    A[3] = temp;
                }
                else if (A[1] == A[3])
                {
                    temp = A[1];
                    A[1] = A[2];
                    A[3] = A[2];
                    A[2] = temp;
                }
                else if (A[2] == A[3])
                {
                    temp = A[2];
                    A[2] = A[1];
                    A[3] = A[1];
                    A[1] = temp;
                }
            }

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                phanCa.deletePhanCa(Convert.ToInt32(tab.Rows[i]["msnv"].ToString()));
            }

            for (int j = 1; j < 4; j++)
            {
                phanCa.insertPhanCa(A[j], j, j);
            }

            MessageBox.Show("Da Phan Ca Quan li", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cv = comboBoxRole.SelectedItem.ToString();
                if (cv == "Manager")
                {
                    textBoxSoNVCa1.Text = "1";
                    textBoxSoNVCa1.ReadOnly = true;
                    textBoxSoNVCa2.Text = "1";
                    textBoxSoNVCa2.ReadOnly = true;
                    textBoxSoNVCa3.Text = "1";
                    textBoxSoNVCa3.ReadOnly = true;
                }    
                else
                {
                    textBoxSoNVCa1.Text = "";
                    textBoxSoNVCa2.Text = "";
                    textBoxSoNVCa3.Text = "";
                    textBoxSoNVCa1.ReadOnly = false;
                    textBoxSoNVCa2.ReadOnly = false;
                    textBoxSoNVCa3.ReadOnly = false;
                }    
            }
            catch
            {

            }
        }
    }
}
