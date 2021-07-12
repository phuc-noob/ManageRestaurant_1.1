using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class checkInAndOutForm_1 : Form
    {
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxPicture;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelJob;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelBirthdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelName;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSchedule;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewCheckInOutList;
        private Guna.UI2.WinForms.Guna2Button buttonCheckIn;
        private Guna.UI2.WinForms.Guna2Button buttonCheckOut;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerBDate;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2TextBox textBoxJob;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAddress;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private FlowLayoutPanel flowLayoutPanelScheduleList;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private LinkLabel linkLabelChangePassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;

        public checkInAndOutForm_1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxJob = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelBirthdate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.dateTimePickerBDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelSchedule = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewCheckInOutList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.flowLayoutPanelScheduleList = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.linkLabelChangePassword = new System.Windows.Forms.LinkLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckInOutList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.guna2Separator5);
            this.guna2Panel1.Controls.Add(this.guna2Separator4);
            this.guna2Panel1.Controls.Add(this.textBoxJob);
            this.guna2Panel1.Controls.Add(this.guna2Separator3);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.textBoxAddress);
            this.guna2Panel1.Controls.Add(this.textBoxPhone);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.textBoxName);
            this.guna2Panel1.Controls.Add(this.labelJob);
            this.guna2Panel1.Controls.Add(this.labelAddress);
            this.guna2Panel1.Controls.Add(this.labelPhone);
            this.guna2Panel1.Controls.Add(this.labelGender);
            this.guna2Panel1.Controls.Add(this.labelBirthdate);
            this.guna2Panel1.Controls.Add(this.labelName);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Controls.Add(this.guna2Separator6);
            this.guna2Panel1.Controls.Add(this.dateTimePickerBDate);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 211);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(355, 294);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator5.Location = new System.Drawing.Point(114, 252);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator5.TabIndex = 15;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator4.Location = new System.Drawing.Point(114, 210);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator4.TabIndex = 17;
            // 
            // textBoxJob
            // 
            this.textBoxJob.AutoRoundedCorners = true;
            this.textBoxJob.BorderColor = System.Drawing.Color.Black;
            this.textBoxJob.BorderRadius = 13;
            this.textBoxJob.BorderThickness = 0;
            this.textBoxJob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxJob.DefaultText = "";
            this.textBoxJob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxJob.DisabledState.Parent = this.textBoxJob;
            this.textBoxJob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxJob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxJob.FocusedState.Parent = this.textBoxJob;
            this.textBoxJob.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJob.ForeColor = System.Drawing.Color.Black;
            this.textBoxJob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxJob.HoverState.Parent = this.textBoxJob;
            this.textBoxJob.Location = new System.Drawing.Point(114, 230);
            this.textBoxJob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.PasswordChar = '\0';
            this.textBoxJob.PlaceholderText = "Job";
            this.textBoxJob.ReadOnly = true;
            this.textBoxJob.SelectedText = "";
            this.textBoxJob.ShadowDecoration.Parent = this.textBoxJob;
            this.textBoxJob.Size = new System.Drawing.Size(200, 28);
            this.textBoxJob.TabIndex = 14;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator3.Location = new System.Drawing.Point(114, 166);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator3.TabIndex = 15;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator2.Location = new System.Drawing.Point(114, 80);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator2.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AutoRoundedCorners = true;
            this.textBoxAddress.BorderColor = System.Drawing.Color.Black;
            this.textBoxAddress.BorderRadius = 13;
            this.textBoxAddress.BorderThickness = 0;
            this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress.DefaultText = "";
            this.textBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.DisabledState.Parent = this.textBoxAddress;
            this.textBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.FocusedState.Parent = this.textBoxAddress;
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.HoverState.Parent = this.textBoxAddress;
            this.textBoxAddress.Location = new System.Drawing.Point(114, 144);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.PlaceholderText = "Address";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.ShadowDecoration.Parent = this.textBoxAddress;
            this.textBoxAddress.Size = new System.Drawing.Size(200, 28);
            this.textBoxAddress.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AutoRoundedCorners = true;
            this.textBoxPhone.BorderColor = System.Drawing.Color.Black;
            this.textBoxPhone.BorderRadius = 13;
            this.textBoxPhone.BorderThickness = 0;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.DefaultText = "";
            this.textBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.DisabledState.Parent = this.textBoxPhone;
            this.textBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.FocusedState.Parent = this.textBoxPhone;
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.Color.Black;
            this.textBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.HoverState.Parent = this.textBoxPhone;
            this.textBoxPhone.Location = new System.Drawing.Point(114, 58);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderText = "Phone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.ShadowDecoration.Parent = this.textBoxPhone;
            this.textBoxPhone.Size = new System.Drawing.Size(200, 28);
            this.textBoxPhone.TabIndex = 14;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator1.Location = new System.Drawing.Point(114, 35);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.AutoRoundedCorners = true;
            this.textBoxName.BorderColor = System.Drawing.Color.Black;
            this.textBoxName.BorderRadius = 13;
            this.textBoxName.BorderThickness = 0;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.Parent = this.textBoxName;
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.FocusedState.Parent = this.textBoxName;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.HoverState.Parent = this.textBoxName;
            this.textBoxName.Location = new System.Drawing.Point(114, 12);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(200, 28);
            this.textBoxName.TabIndex = 6;
            // 
            // labelJob
            // 
            this.labelJob.BackColor = System.Drawing.Color.Transparent;
            this.labelJob.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJob.ForeColor = System.Drawing.Color.Gray;
            this.labelJob.Location = new System.Drawing.Point(27, 236);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(34, 25);
            this.labelJob.TabIndex = 5;
            this.labelJob.Text = "Job:";
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Gray;
            this.labelAddress.Location = new System.Drawing.Point(27, 148);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(67, 25);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address:";
            // 
            // labelPhone
            // 
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.Gray;
            this.labelPhone.Location = new System.Drawing.Point(27, 63);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(56, 25);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone:";
            // 
            // labelGender
            // 
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Gray;
            this.labelGender.Location = new System.Drawing.Point(27, 191);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 25);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Gender:";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdate.ForeColor = System.Drawing.Color.Gray;
            this.labelBirthdate.Location = new System.Drawing.Point(27, 103);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(77, 25);
            this.labelBirthdate.TabIndex = 1;
            this.labelBirthdate.Text = "Birthdate:";
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Gray;
            this.labelName.Location = new System.Drawing.Point(27, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.radioButtonFemale);
            this.guna2GroupBox1.Controls.Add(this.radioButtonMale);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(97, 184);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(220, 34);
            this.guna2GroupBox1.TabIndex = 19;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(118, 5);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(86, 27);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(26, 5);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(69, 27);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator6.Location = new System.Drawing.Point(114, 128);
            this.guna2Separator6.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator6.TabIndex = 18;
            // 
            // dateTimePickerBDate
            // 
            this.dateTimePickerBDate.AutoRoundedCorners = true;
            this.dateTimePickerBDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerBDate.BorderRadius = 13;
            this.dateTimePickerBDate.CheckedState.Parent = this.dateTimePickerBDate;
            this.dateTimePickerBDate.CustomFormat = "";
            this.dateTimePickerBDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickerBDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBDate.HoverState.Parent = this.dateTimePickerBDate;
            this.dateTimePickerBDate.Location = new System.Drawing.Point(114, 99);
            this.dateTimePickerBDate.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBDate.Name = "dateTimePickerBDate";
            this.dateTimePickerBDate.ShadowDecoration.Parent = this.dateTimePickerBDate;
            this.dateTimePickerBDate.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerBDate.TabIndex = 12;
            this.dateTimePickerBDate.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // labelSchedule
            // 
            this.labelSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSchedule.BackColor = System.Drawing.Color.Transparent;
            this.labelSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(415, 39);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(82, 27);
            this.labelSchedule.TabIndex = 4;
            this.labelSchedule.Text = "Schedule: ";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(415, 148);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(226, 27);
            this.guna2HtmlLabel8.TabIndex = 5;
            this.guna2HtmlLabel8.Text = "Today check in/out history: ";
            // 
            // dataGridViewCheckInOutList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckInOutList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCheckInOutList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCheckInOutList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCheckInOutList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCheckInOutList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCheckInOutList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCheckInOutList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckInOutList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCheckInOutList.ColumnHeadersHeight = 30;
            this.dataGridViewCheckInOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckInOutList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCheckInOutList.EnableHeadersVisualStyles = false;
            this.dataGridViewCheckInOutList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewCheckInOutList.Location = new System.Drawing.Point(415, 187);
            this.dataGridViewCheckInOutList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCheckInOutList.Name = "dataGridViewCheckInOutList";
            this.dataGridViewCheckInOutList.ReadOnly = true;
            this.dataGridViewCheckInOutList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckInOutList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCheckInOutList.RowHeadersVisible = false;
            this.dataGridViewCheckInOutList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckInOutList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCheckInOutList.RowTemplate.DividerHeight = 1;
            this.dataGridViewCheckInOutList.RowTemplate.Height = 35;
            this.dataGridViewCheckInOutList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCheckInOutList.Size = new System.Drawing.Size(432, 282);
            this.dataGridViewCheckInOutList.TabIndex = 6;
            this.dataGridViewCheckInOutList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewCheckInOutList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCheckInOutList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewCheckInOutList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewCheckInOutList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewCheckInOutList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewCheckInOutList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCheckInOutList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewCheckInOutList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewCheckInOutList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCheckInOutList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCheckInOutList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCheckInOutList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCheckInOutList.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewCheckInOutList.ThemeStyle.ReadOnly = true;
            this.dataGridViewCheckInOutList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCheckInOutList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCheckInOutList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCheckInOutList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewCheckInOutList.ThemeStyle.RowsStyle.Height = 35;
            this.dataGridViewCheckInOutList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.dataGridViewCheckInOutList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckIn.AutoRoundedCorners = true;
            this.buttonCheckIn.BorderRadius = 15;
            this.buttonCheckIn.BorderThickness = 1;
            this.buttonCheckIn.CheckedState.Parent = this.buttonCheckIn;
            this.buttonCheckIn.CustomImages.Parent = this.buttonCheckIn;
            this.buttonCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.buttonCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.Black;
            this.buttonCheckIn.HoverState.Parent = this.buttonCheckIn;
            this.buttonCheckIn.Location = new System.Drawing.Point(468, 482);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.ShadowDecoration.Parent = this.buttonCheckIn;
            this.buttonCheckIn.Size = new System.Drawing.Size(159, 33);
            this.buttonCheckIn.TabIndex = 8;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckOut.AutoRoundedCorners = true;
            this.buttonCheckOut.BorderRadius = 15;
            this.buttonCheckOut.BorderThickness = 1;
            this.buttonCheckOut.CheckedState.Parent = this.buttonCheckOut;
            this.buttonCheckOut.CustomImages.Parent = this.buttonCheckOut;
            this.buttonCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.buttonCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.ForeColor = System.Drawing.Color.White;
            this.buttonCheckOut.HoverState.Parent = this.buttonCheckOut;
            this.buttonCheckOut.Location = new System.Drawing.Point(646, 482);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.ShadowDecoration.Parent = this.buttonCheckOut;
            this.buttonCheckOut.Size = new System.Drawing.Size(159, 33);
            this.buttonCheckOut.TabIndex = 9;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(381, -4);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 548);
            this.guna2VSeparator1.TabIndex = 10;
            // 
            // flowLayoutPanelScheduleList
            // 
            this.flowLayoutPanelScheduleList.CausesValidation = false;
            this.flowLayoutPanelScheduleList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelScheduleList.Location = new System.Drawing.Point(415, 70);
            this.flowLayoutPanelScheduleList.Name = "flowLayoutPanelScheduleList";
            this.flowLayoutPanelScheduleList.Size = new System.Drawing.Size(432, 73);
            this.flowLayoutPanelScheduleList.TabIndex = 11;
            this.flowLayoutPanelScheduleList.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelScheduleList_Paint);
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxPicture.Location = new System.Drawing.Point(5, 4);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxPicture.ShadowDecoration.Parent = this.pictureBoxPicture;
            this.pictureBoxPicture.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPicture.TabIndex = 0;
            this.pictureBoxPicture.TabStop = false;
            // 
            // linkLabelChangePassword
            // 
            this.linkLabelChangePassword.AutoSize = true;
            this.linkLabelChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelChangePassword.LinkColor = System.Drawing.Color.Black;
            this.linkLabelChangePassword.Location = new System.Drawing.Point(101, 509);
            this.linkLabelChangePassword.Name = "linkLabelChangePassword";
            this.linkLabelChangePassword.Size = new System.Drawing.Size(209, 19);
            this.linkLabelChangePassword.TabIndex = 12;
            this.linkLabelChangePassword.TabStop = true;
            this.linkLabelChangePassword.Text = "Want to change your password?";
            this.linkLabelChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePassword_LinkClicked);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoRoundedCorners = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderRadius = 78;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.pictureBoxPicture);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel2.Location = new System.Drawing.Point(110, 37);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(158, 158);
            this.guna2Panel2.TabIndex = 13;
            // 
            // checkInAndOutForm_1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 537);
            this.Controls.Add(this.linkLabelChangePassword);
            this.Controls.Add(this.flowLayoutPanelScheduleList);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.dataGridViewCheckInOutList);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "checkInAndOutForm_1";
            this.Load += new System.EventHandler(this.checkInAndOutForm_1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckInOutList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Employee employee = new Employee();
        PhanCa phanCa = new PhanCa();
        DiemDanh diemDanh = new DiemDanh();

        private void checkInAndOutForm_1_Load(object sender, EventArgs e)
        {
            if (Global.GlobalUserId != 0)
            {
                SqlCommand command = new SqlCommand("SELECT Picture, Fname, Lname, phone, birthdate, address, gender, noidungcv  FROM Nhanvien as N, congviec" +
                    " WHERE congviec = macv AND msnv = @msnv");
                command.Parameters.Add("@msnv", SqlDbType.Int).Value = Global.GlobalUserId;
                DataTable table = employee.getEmployees(command);
                textBoxName.Text = table.Rows[0]["fname"].ToString() + " " + table.Rows[0]["lname"].ToString();
                dateTimePickerBDate.Value = (DateTime)table.Rows[0]["birthdate"];
                radioButtonMale.Checked = true;
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                textBoxJob.Text = table.Rows[0]["noidungcv"].ToString();
                byte[] pic;
                pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxPicture.Image = Image.FromStream(picture);

                SqlCommand command1 = new SqlCommand("SELECT * FROM phanca as p, ca as c WHERE p.maca = c.maca AND p.msnv = @msnv");
                command1.Parameters.Add("@msnv", SqlDbType.Int).Value = Global.GlobalUserId;
                DataTable table1 = phanCa.getPhanCa(command1);
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    scheduleItem item = new scheduleItem();
                    item.Shift = table1.Rows[i]["description"].ToString() + ": " + table1.Rows[i]["thoigianbatdau"].ToString()
                        + " - " + table1.Rows[i]["thoigianketthuc"].ToString();
                    flowLayoutPanelScheduleList.Controls.Add(item);
                }
                scheduleListLoad();
            }
        }

        public void scheduleListLoad()
        {
            SqlCommand command2 = new SqlCommand("SELECT checkin as 'Check in time', checkout as 'Check out time' FROM DiemDanh WHERE msnv = @msnv");
            command2.Parameters.Add("@msnv", SqlDbType.Int).Value = Global.GlobalUserId;
            DataTable table2 = diemDanh.getDiemDanh(command2);
            dataGridViewCheckInOutList.ReadOnly = true;
            dataGridViewCheckInOutList.DataSource = table2;
            dataGridViewCheckInOutList.AllowUserToAddRows = false;
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to check in?", "Check in", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int msnv = Global.GlobalUserId;
                if (diemDanh.checkIn(msnv))
                {
                    MessageBox.Show("Da check in", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    scheduleListLoad();
                }
                else
                {
                    MessageBox.Show("Error", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            int msnv = Global.GlobalUserId;
            if (diemDanh.kiemTraCheckIn(msnv))
            {
                if (MessageBox.Show("You want to check out?", "Check out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (diemDanh.checkOut(msnv))
                    {
                        MessageBox.Show("Da check out", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        scheduleListLoad();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chua Check In", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePasswordForm_1 changeForm = new changePasswordForm_1();
            changeForm.Show();
        }

        private void flowLayoutPanelScheduleList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
