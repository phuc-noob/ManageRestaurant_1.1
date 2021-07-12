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
    class editEmployeeForm : Form
    {
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerBDate;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxJob;
        private Guna.UI2.WinForms.Guna2Button buttonUploadImage;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAddress;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFname;
        private Guna.UI2.WinForms.Guna2CircleButton buttonCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelJob;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelName;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelGender;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Guna.UI2.WinForms.Guna2TextBox textBoxID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxPicture;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelBirthdate;

        public editEmployeeForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dateTimePickerBDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBoxPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.comboBoxJob = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonUploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxLName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelBirthdate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerBDate
            // 
            this.dateTimePickerBDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dateTimePickerBDate.BorderThickness = 1;
            this.dateTimePickerBDate.CheckedState.Parent = this.dateTimePickerBDate;
            this.dateTimePickerBDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickerBDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerBDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerBDate.HoverState.Parent = this.dateTimePickerBDate;
            this.dateTimePickerBDate.Location = new System.Drawing.Point(212, 337);
            this.dateTimePickerBDate.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBDate.Name = "dateTimePickerBDate";
            this.dateTimePickerBDate.ShadowDecoration.Parent = this.dateTimePickerBDate;
            this.dateTimePickerBDate.Size = new System.Drawing.Size(220, 34);
            this.dateTimePickerBDate.TabIndex = 49;
            this.dateTimePickerBDate.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPicture.Location = new System.Drawing.Point(38, 124);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.ShadowDecoration.Parent = this.pictureBoxPicture;
            this.pictureBoxPicture.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPicture.TabIndex = 48;
            this.pictureBoxPicture.TabStop = false;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxJob.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxJob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxJob.FocusedState.Parent = this.comboBoxJob;
            this.comboBoxJob.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJob.ForeColor = System.Drawing.Color.Black;
            this.comboBoxJob.HoverState.Parent = this.comboBoxJob;
            this.comboBoxJob.ItemHeight = 30;
            this.comboBoxJob.ItemsAppearance.Parent = this.comboBoxJob;
            this.comboBoxJob.Location = new System.Drawing.Point(212, 267);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.ShadowDecoration.Parent = this.comboBoxJob;
            this.comboBoxJob.Size = new System.Drawing.Size(453, 36);
            this.comboBoxJob.TabIndex = 47;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.CheckedState.Parent = this.buttonUploadImage;
            this.buttonUploadImage.CustomImages.Parent = this.buttonUploadImage;
            this.buttonUploadImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonUploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadImage.ForeColor = System.Drawing.Color.White;
            this.buttonUploadImage.HoverState.Parent = this.buttonUploadImage;
            this.buttonUploadImage.Location = new System.Drawing.Point(38, 270);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.ShadowDecoration.Parent = this.buttonUploadImage;
            this.buttonUploadImage.Size = new System.Drawing.Size(140, 32);
            this.buttonUploadImage.TabIndex = 46;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoRoundedCorners = true;
            this.buttonEdit.BorderRadius = 19;
            this.buttonEdit.CheckedState.Parent = this.buttonEdit;
            this.buttonEdit.CustomImages.Parent = this.buttonEdit;
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.HoverState.Parent = this.buttonEdit;
            this.buttonEdit.Location = new System.Drawing.Point(551, 460);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShadowDecoration.Parent = this.buttonEdit;
            this.buttonEdit.Size = new System.Drawing.Size(115, 40);
            this.buttonEdit.TabIndex = 45;
            this.buttonEdit.Text = "SAVE";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.DefaultText = "";
            this.textBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.DisabledState.Parent = this.textBoxPhone;
            this.textBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.FocusedState.Parent = this.textBoxPhone;
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.Color.Black;
            this.textBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.HoverState.Parent = this.textBoxPhone;
            this.textBoxPhone.Location = new System.Drawing.Point(445, 405);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderText = "";
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.ShadowDecoration.Parent = this.textBoxPhone;
            this.textBoxPhone.Size = new System.Drawing.Size(220, 34);
            this.textBoxPhone.TabIndex = 44;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress.DefaultText = "";
            this.textBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.DisabledState.Parent = this.textBoxAddress;
            this.textBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.FocusedState.Parent = this.textBoxAddress;
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.HoverState.Parent = this.textBoxAddress;
            this.textBoxAddress.Location = new System.Drawing.Point(212, 405);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.PlaceholderText = "";
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.ShadowDecoration.Parent = this.textBoxAddress;
            this.textBoxAddress.Size = new System.Drawing.Size(220, 34);
            this.textBoxAddress.TabIndex = 43;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLName.DefaultText = "";
            this.textBoxLName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLName.DisabledState.Parent = this.textBoxLName;
            this.textBoxLName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLName.FocusedState.Parent = this.textBoxLName;
            this.textBoxLName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.ForeColor = System.Drawing.Color.Black;
            this.textBoxLName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLName.HoverState.Parent = this.textBoxLName;
            this.textBoxLName.Location = new System.Drawing.Point(445, 199);
            this.textBoxLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.PasswordChar = '\0';
            this.textBoxLName.PlaceholderText = "";
            this.textBoxLName.SelectedText = "";
            this.textBoxLName.ShadowDecoration.Parent = this.textBoxLName;
            this.textBoxLName.Size = new System.Drawing.Size(220, 34);
            this.textBoxLName.TabIndex = 41;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFname.DefaultText = "";
            this.textBoxFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFname.DisabledState.Parent = this.textBoxFname;
            this.textBoxFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFname.FocusedState.Parent = this.textBoxFname;
            this.textBoxFname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.ForeColor = System.Drawing.Color.Black;
            this.textBoxFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFname.HoverState.Parent = this.textBoxFname;
            this.textBoxFname.Location = new System.Drawing.Point(212, 199);
            this.textBoxFname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.PasswordChar = '\0';
            this.textBoxFname.PlaceholderText = "";
            this.textBoxFname.SelectedText = "";
            this.textBoxFname.ShadowDecoration.Parent = this.textBoxFname;
            this.textBoxFname.Size = new System.Drawing.Size(220, 34);
            this.textBoxFname.TabIndex = 40;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCancel.CheckedState.Parent = this.buttonCancel;
            this.buttonCancel.CustomImages.Parent = this.buttonCancel;
            this.buttonCancel.FillColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.HoverState.Parent = this.buttonCancel;
            this.buttonCancel.Image = global::ManageRestaurent1._1.Properties.Resources.left_arrow;
            this.buttonCancel.Location = new System.Drawing.Point(0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonCancel.ShadowDecoration.Parent = this.buttonCancel;
            this.buttonCancel.Size = new System.Drawing.Size(32, 32);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(29, 37);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(176, 39);
            this.guna2HtmlLabel2.TabIndex = 38;
            this.guna2HtmlLabel2.Text = "Edit Employee";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(445, 171);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(74, 22);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "Last Name";
            // 
            // labelJob
            // 
            this.labelJob.BackColor = System.Drawing.Color.Transparent;
            this.labelJob.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelJob.Location = new System.Drawing.Point(212, 239);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(86, 22);
            this.labelJob.TabIndex = 36;
            this.labelJob.Text = "Job Position";
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelAddress.Location = new System.Drawing.Point(212, 377);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(57, 22);
            this.labelAddress.TabIndex = 35;
            this.labelAddress.Text = "Address";
            // 
            // labelPhone
            // 
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelPhone.Location = new System.Drawing.Point(445, 377);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 22);
            this.labelPhone.TabIndex = 34;
            this.labelPhone.Text = "Phone";
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelName.Location = new System.Drawing.Point(212, 171);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 22);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "First Name";
            // 
            // labelGender
            // 
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelGender.Location = new System.Drawing.Point(445, 309);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(53, 22);
            this.labelGender.TabIndex = 33;
            this.labelGender.Text = "Gender";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelBirthdate.Location = new System.Drawing.Point(212, 309);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(66, 22);
            this.labelBirthdate.TabIndex = 32;
            this.labelBirthdate.Text = "Birthdate";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.buttonCancel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(683, 515);
            this.guna2Panel1.TabIndex = 50;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Controls.Add(this.radioButtonFemale);
            this.guna2GroupBox1.Controls.Add(this.radioButtonMale);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(445, 337);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(220, 34);
            this.guna2GroupBox1.TabIndex = 1;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(112, 6);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(78, 24);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(23, 6);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(63, 24);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxID.DefaultText = "";
            this.textBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.DisabledState.Parent = this.textBoxID;
            this.textBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.FocusedState.Parent = this.textBoxID;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.Black;
            this.textBoxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.HoverState.Parent = this.textBoxID;
            this.textBoxID.Location = new System.Drawing.Point(211, 130);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '\0';
            this.textBoxID.PlaceholderText = "";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.SelectedText = "";
            this.textBoxID.ShadowDecoration.Parent = this.textBoxID;
            this.textBoxID.Size = new System.Drawing.Size(103, 34);
            this.textBoxID.TabIndex = 52;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(211, 102);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(18, 22);
            this.guna2HtmlLabel3.TabIndex = 51;
            this.guna2HtmlLabel3.Text = "ID";
            // 
            // editEmployeeForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 515);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dateTimePickerBDate);
            this.Controls.Add(this.pictureBoxPicture);
            this.Controls.Add(this.comboBoxJob);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editEmployeeForm";
            this.Load += new System.EventHandler(this.editEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Employee employee = new Employee();
        Job job = new Job();

        private void editEmployeeForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        public void formLoad()
        {
            SqlCommand command2 = new SqlCommand("SELECT * FROM Congviec");
            comboBoxJob.DataSource = job.getJobs(command2);
            comboBoxJob.ValueMember = "Macv";
            comboBoxJob.DisplayMember = "noidungcv";
        }

        public void fillForm(int msnv)
        {
            try
            {
                textBoxID.Text = msnv.ToString();
                DataTable table = employee.getEmployeeByMsnv(msnv);
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLName.Text = table.Rows[0]["lname"].ToString();
                dateTimePickerBDate.Value = (DateTime)table.Rows[0]["birthdate"];
                radioButtonMale.Checked = true;
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                comboBoxJob.SelectedIndex = Convert.ToInt32(table.Rows[0]["congviec"].ToString()) - 1;
                byte[] pic;
                pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxPicture.Image = Image.FromStream(picture);
            }
            catch
            {

            }
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPicture.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((int)comboBoxJob.SelectedValue == 1)
            {
                if (employee.checkNoOfManager())
                {
                    editEmployee();
                }
                else
                {
                    MessageBox.Show("Da du quan ly", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                editEmployee();
            }
        }

        public void editEmployee()
        {
            int msnv = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLName.Text;
            DateTime bdate = dateTimePickerBDate.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            int macv = (int)comboBoxJob.SelectedValue;
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePickerBDate.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 18) || ((this_year - born_year) > 30))
            {
                MessageBox.Show("The employee age must be between 18 and 30 year", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (comboBoxJob.SelectedValue.ToString() == "Quan ly")
                {
                    if (employee.checkNoOfManager())
                    {
                        pictureBoxPicture.Image.Save(pic, pictureBoxPicture.Image.RawFormat);
                        if (employee.updateEmployee(msnv, fname, lname, bdate, gender, phone, adrs, pic, macv))
                        {
                            MessageBox.Show("Employee Edited", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Da du quan ly", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    pictureBoxPicture.Image.Save(pic, pictureBoxPicture.Image.RawFormat);
                    if (employee.updateEmployee(msnv, fname, lname, bdate, gender, phone, adrs, pic, macv))
                    {
                        MessageBox.Show("Employee Edited", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((textBoxID.Text.Trim() == "")
                || (textBoxFname.Text.Trim() == "")
                || (textBoxLName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (pictureBoxPicture.Image == null)
                || (comboBoxJob.SelectedValue.ToString().Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
