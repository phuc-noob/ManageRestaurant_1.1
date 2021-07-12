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
    class manageShiftForm : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemStatus;
        private ToolStripMenuItem toolStripMenuItemAll;
        private ToolStripMenuItem toolStripMenuItemWorking;
        private ToolStripMenuItem toolStripMenuItemNotWorking;
        private ToolStripMenuItem toolStripMenuItemShift;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem ca1ToolStripMenuItem;
        private ToolStripMenuItem ca2ToolStripMenuItem;
        private ToolStripMenuItem ca3ToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSearch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSalary;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxPicture;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCa;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSchedule;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDNVLT;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonPhanCa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxID;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private FlowLayoutPanel flowLayoutPanelScheduleList;

        public manageShiftForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanelScheduleList = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWorking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNotWorking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShift = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ca1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ca2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ca3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.comboBoxCa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSchedule = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxIDNVLT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPhanCa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.comboBoxID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBoxPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelScheduleList
            // 
            this.flowLayoutPanelScheduleList.AutoScroll = true;
            this.flowLayoutPanelScheduleList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelScheduleList.Location = new System.Drawing.Point(0, 106);
            this.flowLayoutPanelScheduleList.Name = "flowLayoutPanelScheduleList";
            this.flowLayoutPanelScheduleList.Size = new System.Drawing.Size(445, 377);
            this.flowLayoutPanelScheduleList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStatus,
            this.toolStripMenuItemShift});
            this.menuStrip1.Location = new System.Drawing.Point(0, 75);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(131, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemStatus
            // 
            this.toolStripMenuItemStatus.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAll,
            this.toolStripMenuItemWorking,
            this.toolStripMenuItemNotWorking});
            this.toolStripMenuItemStatus.Name = "toolStripMenuItemStatus";
            this.toolStripMenuItemStatus.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItemStatus.Text = "Status";
            // 
            // toolStripMenuItemAll
            // 
            this.toolStripMenuItemAll.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemAll.Name = "toolStripMenuItemAll";
            this.toolStripMenuItemAll.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemAll.Text = "All";
            this.toolStripMenuItemAll.Click += new System.EventHandler(this.toolStripMenuItemAll_Click);
            // 
            // toolStripMenuItemWorking
            // 
            this.toolStripMenuItemWorking.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemWorking.Name = "toolStripMenuItemWorking";
            this.toolStripMenuItemWorking.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemWorking.Text = "Working";
            this.toolStripMenuItemWorking.Click += new System.EventHandler(this.toolStripMenuItemWorking_Click);
            // 
            // toolStripMenuItemNotWorking
            // 
            this.toolStripMenuItemNotWorking.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemNotWorking.Name = "toolStripMenuItemNotWorking";
            this.toolStripMenuItemNotWorking.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemNotWorking.Text = "Not Working";
            this.toolStripMenuItemNotWorking.Click += new System.EventHandler(this.toolStripMenuItemNotWorking_Click);
            // 
            // toolStripMenuItemShift
            // 
            this.toolStripMenuItemShift.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.ca1ToolStripMenuItem,
            this.ca2ToolStripMenuItem,
            this.ca3ToolStripMenuItem});
            this.toolStripMenuItemShift.Name = "toolStripMenuItemShift";
            this.toolStripMenuItemShift.Size = new System.Drawing.Size(54, 24);
            this.toolStripMenuItemShift.Text = "Shift";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // ca1ToolStripMenuItem
            // 
            this.ca1ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ca1ToolStripMenuItem.Name = "ca1ToolStripMenuItem";
            this.ca1ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ca1ToolStripMenuItem.Text = "Ca 1";
            this.ca1ToolStripMenuItem.Click += new System.EventHandler(this.ca1ToolStripMenuItem_Click);
            // 
            // ca2ToolStripMenuItem
            // 
            this.ca2ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ca2ToolStripMenuItem.Name = "ca2ToolStripMenuItem";
            this.ca2ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ca2ToolStripMenuItem.Text = "Ca 2";
            this.ca2ToolStripMenuItem.Click += new System.EventHandler(this.ca2ToolStripMenuItem_Click);
            // 
            // ca3ToolStripMenuItem
            // 
            this.ca3ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ca3ToolStripMenuItem.Name = "ca3ToolStripMenuItem";
            this.ca3ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ca3ToolStripMenuItem.Text = "Ca 3";
            this.ca3ToolStripMenuItem.Click += new System.EventHandler(this.ca3ToolStripMenuItem_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoRoundedCorners = true;
            this.textBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.BorderRadius = 15;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.Parent = this.textBoxSearch;
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.FocusedState.Parent = this.textBoxSearch;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.HoverState.Parent = this.textBoxSearch;
            this.textBoxSearch.Location = new System.Drawing.Point(189, 71);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Fname,Lname,Address";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.ShadowDecoration.Parent = this.textBoxSearch;
            this.textBoxSearch.Size = new System.Drawing.Size(198, 32);
            this.textBoxSearch.TabIndex = 5;
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(12, 12);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(135, 40);
            this.labelSalary.TabIndex = 7;
            this.labelSalary.Text = "Schedule";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(447, -5);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 545);
            this.guna2VSeparator1.TabIndex = 9;
            // 
            // comboBoxCa
            // 
            this.comboBoxCa.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCa.BorderThickness = 0;
            this.comboBoxCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCa.FocusedState.Parent = this.comboBoxCa;
            this.comboBoxCa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCa.HoverState.Parent = this.comboBoxCa;
            this.comboBoxCa.ItemHeight = 30;
            this.comboBoxCa.ItemsAppearance.Parent = this.comboBoxCa;
            this.comboBoxCa.Location = new System.Drawing.Point(640, 349);
            this.comboBoxCa.Name = "comboBoxCa";
            this.comboBoxCa.ShadowDecoration.Parent = this.comboBoxCa;
            this.comboBoxCa.Size = new System.Drawing.Size(197, 36);
            this.comboBoxCa.TabIndex = 14;
            this.comboBoxCa.SelectedIndexChanged += new System.EventHandler(this.comboBoxCa_SelectedIndexChanged);
            // 
            // labelSchedule
            // 
            this.labelSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSchedule.BackColor = System.Drawing.Color.Transparent;
            this.labelSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(494, 361);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(76, 25);
            this.labelSchedule.TabIndex = 15;
            this.labelSchedule.Text = "Schedule: ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(494, 416);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(132, 25);
            this.guna2HtmlLabel3.TabIndex = 16;
            this.guna2HtmlLabel3.Text = "ID NV Lam Thay: ";
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator5.Location = new System.Drawing.Point(640, 432);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator5.TabIndex = 18;
            // 
            // textBoxIDNVLT
            // 
            this.textBoxIDNVLT.AutoRoundedCorners = true;
            this.textBoxIDNVLT.BorderColor = System.Drawing.Color.Black;
            this.textBoxIDNVLT.BorderRadius = 12;
            this.textBoxIDNVLT.BorderThickness = 0;
            this.textBoxIDNVLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIDNVLT.DefaultText = "";
            this.textBoxIDNVLT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIDNVLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIDNVLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIDNVLT.DisabledState.Parent = this.textBoxIDNVLT;
            this.textBoxIDNVLT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIDNVLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIDNVLT.FocusedState.Parent = this.textBoxIDNVLT;
            this.textBoxIDNVLT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxIDNVLT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIDNVLT.HoverState.Parent = this.textBoxIDNVLT;
            this.textBoxIDNVLT.Location = new System.Drawing.Point(640, 411);
            this.textBoxIDNVLT.Name = "textBoxIDNVLT";
            this.textBoxIDNVLT.PasswordChar = '\0';
            this.textBoxIDNVLT.PlaceholderText = "ID";
            this.textBoxIDNVLT.SelectedText = "";
            this.textBoxIDNVLT.ShadowDecoration.Parent = this.textBoxIDNVLT;
            this.textBoxIDNVLT.Size = new System.Drawing.Size(197, 27);
            this.textBoxIDNVLT.TabIndex = 17;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator1.Location = new System.Drawing.Point(640, 375);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(197, 10);
            this.guna2Separator1.TabIndex = 19;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.AutoRoundedCorners = true;
            this.buttonEdit.BorderRadius = 17;
            this.buttonEdit.BorderThickness = 1;
            this.buttonEdit.CheckedState.Parent = this.buttonEdit;
            this.buttonEdit.CustomImages.Parent = this.buttonEdit;
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.HoverState.Parent = this.buttonEdit;
            this.buttonEdit.Location = new System.Drawing.Point(562, 489);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShadowDecoration.Parent = this.buttonEdit;
            this.buttonEdit.Size = new System.Drawing.Size(233, 36);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit NV Lam Thay";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonPhanCa
            // 
            this.buttonPhanCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPhanCa.AutoRoundedCorners = true;
            this.buttonPhanCa.BorderRadius = 17;
            this.buttonPhanCa.BorderThickness = 1;
            this.buttonPhanCa.CheckedState.Parent = this.buttonPhanCa;
            this.buttonPhanCa.CustomImages.Parent = this.buttonPhanCa;
            this.buttonPhanCa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.buttonPhanCa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhanCa.ForeColor = System.Drawing.Color.Black;
            this.buttonPhanCa.HoverState.Parent = this.buttonPhanCa;
            this.buttonPhanCa.Location = new System.Drawing.Point(324, 489);
            this.buttonPhanCa.Name = "buttonPhanCa";
            this.buttonPhanCa.ShadowDecoration.Parent = this.buttonPhanCa;
            this.buttonPhanCa.Size = new System.Drawing.Size(121, 36);
            this.buttonPhanCa.TabIndex = 21;
            this.buttonPhanCa.Text = "Phan ca";
            this.buttonPhanCa.Click += new System.EventHandler(this.buttonPhanCa_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(494, 261);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(49, 25);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Msnv: ";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator2.Location = new System.Drawing.Point(640, 274);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(197, 11);
            this.guna2Separator2.TabIndex = 24;
            // 
            // comboBoxID
            // 
            this.comboBoxID.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxID.BorderThickness = 0;
            this.comboBoxID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxID.FocusedState.Parent = this.comboBoxID;
            this.comboBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxID.HoverState.Parent = this.comboBoxID;
            this.comboBoxID.ItemHeight = 30;
            this.comboBoxID.ItemsAppearance.Parent = this.comboBoxID;
            this.comboBoxID.Location = new System.Drawing.Point(640, 246);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.ShadowDecoration.Parent = this.comboBoxID;
            this.comboBoxID.Size = new System.Drawing.Size(197, 36);
            this.comboBoxID.TabIndex = 23;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(159)))), ((int)(((byte)(154)))));
            this.guna2Separator3.Location = new System.Drawing.Point(640, 326);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(197, 10);
            this.guna2Separator3.TabIndex = 27;
            // 
            // textBoxName
            // 
            this.textBoxName.AutoRoundedCorners = true;
            this.textBoxName.BorderColor = System.Drawing.Color.Black;
            this.textBoxName.BorderRadius = 12;
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
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.HoverState.Parent = this.textBoxName;
            this.textBoxName.Location = new System.Drawing.Point(640, 305);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(197, 27);
            this.textBoxName.TabIndex = 26;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(494, 310);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(53, 25);
            this.guna2HtmlLabel2.TabIndex = 25;
            this.guna2HtmlLabel2.Text = "Name: ";
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxPicture.Location = new System.Drawing.Point(589, 57);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxPicture.ShadowDecoration.Parent = this.pictureBoxPicture;
            this.pictureBoxPicture.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPicture.TabIndex = 10;
            this.pictureBoxPicture.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.CheckedState.Parent = this.buttonSearch;
            this.buttonSearch.CustomImages.Parent = this.buttonSearch;
            this.buttonSearch.FillColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.HoverState.Parent = this.buttonSearch;
            this.buttonSearch.Image = global::ManageRestaurent1._1.Properties.Resources.search;
            this.buttonSearch.Location = new System.Drawing.Point(393, 71);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSearch.ShadowDecoration.Parent = this.buttonSearch;
            this.buttonSearch.Size = new System.Drawing.Size(32, 32);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // manageShiftForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 537);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.buttonPhanCa);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Separator5);
            this.Controls.Add(this.textBoxIDNVLT);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.comboBoxCa);
            this.Controls.Add(this.pictureBoxPicture);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.flowLayoutPanelScheduleList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "manageShiftForm";
            this.Load += new System.EventHandler(this.manageShiftForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Employee employee = new Employee();
        PhanCa phanCa = new PhanCa();

        private void manageShiftForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Nhanvien");
            comboBoxID.DataSource = employee.getEmployees(command);
            comboBoxID.ValueMember = "msnv";
            comboBoxID.DisplayMember = "msnv";
            fillList();
        }

        public void fillList()
        {
            SqlCommand command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                " WHERE stt = (SELECT MAX(stt) FROM Diemdanh AS D1 WHERE D.msnv = D1.msnv) AND D.checkout IS NULL)");

            SqlCommand command1 = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null)");

            fillListByItemWorking(command);
            fillListByItemNotWorking(command1);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap thong tin nhan vien can tim", "Search Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                /*SqlCommand command = new SqlCommand("SELECT Picture, Msnv, Fname, Lname, Birthdate, Gender, Phone, Address, noidungcv as 'Cong viec'" +
                        " FROM Nhanvien, Congviec WHERE congviec = macv AND CONCAT(fname,lname,address) LIKE '%" + textBoxSearch.Text + "%'");
                fillGrid(command);*/
                flowLayoutPanelScheduleList.Controls.Clear();
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D WHERE stt = (SELECT MAX(stt) FROM Diemdanh AS D1 WHERE D.msnv = D1.msnv)" +
                    " AND D.checkout IS NULL) AND CONCAT(fname,lname,address) LIKE '%" + textBoxSearch.Text + "%'");
                fillListByItemWorking(command);
                command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) AND CONCAT(fname,lname,address) LIKE '%" + textBoxSearch.Text + "%'");
                fillListByItemNotWorking(command);
            }
        }

        public void fillGrid(SqlCommand command)
        {
            /*
            dataGridViewEmployeeList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewEmployeeList.RowTemplate.Height = 80;
            dataGridViewEmployeeList.DataSource = employee.getEmployees(command);
            picCol = (DataGridViewImageColumn)dataGridViewEmployeeList.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewEmployeeList.AllowUserToAddRows = false;
            dataGridViewEmployeeList.Show();
            labelTotalEmployee.Text = ("Total Employee: " + dataGridViewEmployeeList.Rows.Count);
            */
        }

        private void flowLayoutPanelScheduleList_Click(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int msnv = (int)comboBoxID.SelectedValue;
                SqlCommand command = new SqlCommand("SELECT * FROM Nhanvien WHERE msnv = @msnv");
                command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
                DataTable table = employee.getEmployees(command);
                byte[] pic;
                pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxPicture.Image = Image.FromStream(picture);
                textBoxName.Text = table.Rows[0]["FName"].ToString() + " " + table.Rows[0]["LName"].ToString();
                SqlCommand command1 = new SqlCommand("SELECT P.maca, description, nvlamthay FROM Phanca as P, Ca as C WHERE P.maca = C.maca AND msnv = @msnv");
                command1.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
                DataTable table1 = phanCa.getPhanCa(command1);
                comboBoxCa.DataSource = table1;
                comboBoxCa.ValueMember = "maca";
                comboBoxCa.DisplayMember = "description";
                textBoxIDNVLT.Text = table1.Rows[0]["nvlamthay"].ToString();
            }
            catch
            {

            }
        }

        private void buttonPhanCa_Click(object sender, EventArgs e)
        {
            numberOfEmployeeForm numberOfEmployeefrm = new numberOfEmployeeForm();
            numberOfEmployeefrm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCa.SelectedItem != null && comboBoxID.SelectedItem != null)
                {
                    int msnv = (int)comboBoxID.SelectedValue;
                    int maca = (int)comboBoxCa.SelectedValue;
                    string msnvlt = textBoxIDNVLT.Text;
                    
                    if (msnvlt.Trim() == "")
                    {
                        if (MessageBox.Show("Are you sure you want to add NVLT to this employee", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (phanCa.updatePhanCa(msnv, msnvlt, maca))
                            {
                                MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Not edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (Convert.ToInt32(msnvlt) == msnv)
                    {
                        MessageBox.Show("Invalid nvlamthay id", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to add NVLT to this employee", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (employee.checkMsnvlt(msnv, Convert.ToInt32(msnvlt), maca))
                            {
                                if (phanCa.updatePhanCa(msnv, msnvlt, maca))
                                {
                                    MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Not edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhan vien lam thay khong ton tai hoac khong phu hop", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        public void fillListByItemWorking(SqlCommand command)
        {
            DataTable tableWorking = employee.getEmployees(command);
            
            for (int i = 0; i < tableWorking.Rows.Count; i++)
            {
                scheduleListWorkingItem item = new scheduleListWorkingItem();
                item.Id = tableWorking.Rows[i]["msnv"].ToString();
                item.EName = tableWorking.Rows[i]["fname"].ToString() + " " + tableWorking.Rows[i]["lname"].ToString();
                byte[] pic;
                pic = (byte[])tableWorking.Rows[i]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                item.Picture = Image.FromStream(picture);
                flowLayoutPanelScheduleList.Controls.Add(item);
            }
        }

        public void fillListByItemNotWorking(SqlCommand command)
        {
            DataTable tableNotWorking = employee.getEmployees(command);

            for (int i = 0; i < tableNotWorking.Rows.Count; i++)
            {
                scheduleListItem item = new scheduleListItem();
                item.Id = tableNotWorking.Rows[i]["msnv"].ToString();
                item.EName = tableNotWorking.Rows[i]["fname"].ToString() + " " + tableNotWorking.Rows[i]["lname"].ToString();
                byte[] pic;
                pic = (byte[])tableNotWorking.Rows[i]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                item.Picture = Image.FromStream(picture);
                flowLayoutPanelScheduleList.Controls.Add(item);
            }
        }

        public void fillListByFilter(string status, string shift)
        {
            SqlCommand command = new SqlCommand();
            if (status == "All")
            {
                if (shift == "All")
                {
                    command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien WHERE msnv IN (SELECT DISTINCT msnv FROM Phanca)");
                    fillList();
                }
                else if (shift == "Ca 1")
                {
                    command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 1";
                    fillListByItemWorking(command);
                    command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 1";
                    fillListByItemNotWorking(command);
                }
                else if (shift == "Ca 2")
                {
                    command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 2";
                    fillListByItemWorking(command);
                    command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 2";
                    fillListByItemNotWorking(command);
                }
                else if (shift == "Ca 3")
                {
                    command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 3";
                    fillListByItemWorking(command);
                    command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 3";
                    fillListByItemNotWorking(command);
                }
            }
            else
            {
                if (status == "Working")
                {
                    if (shift == "All")
                    {
                        command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D WHERE stt = (SELECT MAX(stt) FROM Diemdanh AS D1 WHERE D.msnv = D1.msnv) AND D.checkout IS NULL)");
                        fillListByItemWorking(command);
                    }
                    else if (shift == "Ca 1")
                    {
                        command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 1";
                        fillListByItemWorking(command);
                    }
                    else if (shift == "Ca 2")
                    {
                        command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 2";
                        fillListByItemWorking(command);
                    }
                    else if (shift == "Ca 3")
                    {
                        command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 3";
                        fillListByItemWorking(command);
                    }
                }
                else
                {
                    if (shift == "All")
                    {
                        command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null)");
                        fillListByItemNotWorking(command);
                    }
                    else if (shift == "Ca 1")
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv IN (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 1";
                        fillListByItemNotWorking(command);
                    }
                    else if (shift == "Ca 2")
                    {
                        command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 2";
                        fillListByItemNotWorking(command);
                    }
                    else if (shift == "Ca 3")
                    {
                        command = new SqlCommand("SELECT msnv, fname, lname, picture FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 3";
                        fillListByItemNotWorking(command);
                    }
                }
            }
            
        }

        private void toolStripMenuItemAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanelScheduleList.Controls.Clear();
            toolStripMenuItemStatus.Text = "All";
            if (toolStripMenuItemShift.Text == "Ca 1")
            {
                fillListByFilter("All", "Ca 1");
            }
            else if (toolStripMenuItemShift.Text == "Ca 2")
            {
                fillListByFilter("All", "Ca 2");
            }
            else if (toolStripMenuItemShift.Text == "Ca 3")
            {
                fillListByFilter("All", "Ca 3");
            }
            else
            {
                fillListByFilter("All", "All");
            }
        }

        private void toolStripMenuItemWorking_Click(object sender, EventArgs e)
        {
            flowLayoutPanelScheduleList.Controls.Clear();
            toolStripMenuItemStatus.Text = "Working";
            if (toolStripMenuItemShift.Text == "Ca 1")
            {
                fillListByFilter("Working", "Ca 1");
            }
            else if (toolStripMenuItemShift.Text == "Ca 2")
            {
                fillListByFilter("Working", "Ca 2");
            }
            else if (toolStripMenuItemShift.Text == "Ca 3")
            {
                fillListByFilter("Working", "Ca 3");
            }
            else
            {
                fillListByFilter("Working", "All");
            }
        }

        private void toolStripMenuItemNotWorking_Click(object sender, EventArgs e)
        {
            flowLayoutPanelScheduleList.Controls.Clear();
            toolStripMenuItemStatus.Text = "Not Working";
            if (toolStripMenuItemShift.Text == "Ca 1")
            {
                fillListByFilter("Not Working", "Ca 1");
            }
            else if (toolStripMenuItemShift.Text == "Ca 2")
            {
                fillListByFilter("Not Working", "Ca 2");
            }
            else if (toolStripMenuItemShift.Text == "Ca 3")
            {
                fillListByFilter("Not Working", "Ca 3");
            }
            else
            {
                fillListByFilter("Not Working", "All");
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelScheduleList.Controls.Clear();
            toolStripMenuItemShift.Text = "All";
            if (toolStripMenuItemStatus.Text == "Working")
            {
                fillListByFilter("Working", "All");
            }
            else if (toolStripMenuItemStatus.Text == "Not Working")
            {
                fillListByFilter("Not Working", "All");
            }
            else 
            {
                fillListByFilter("All", "All");
            }
        }

        private void ca1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelScheduleList.Controls.Clear();
            toolStripMenuItemShift.Text = "Ca 1";
            if (toolStripMenuItemStatus.Text == "Working")
            {
                fillListByFilter("Working", "Ca 1");
            }
            else if (toolStripMenuItemStatus.Text == "Not Working")
            {
                fillListByFilter("Not Working", "Ca 1");
            }
            else
            {
                fillListByFilter("All", "Ca 1");
            }
        }

        private void ca2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelScheduleList.Controls.Clear();
            toolStripMenuItemShift.Text = "Ca 2";
            if (toolStripMenuItemStatus.Text == "Working")
            {
                fillListByFilter("Working", "Ca 2");
            }
            else if (toolStripMenuItemStatus.Text == "Not Working")
            {
                fillListByFilter("Not Working", "Ca 2");
            }
            else
            {
                fillListByFilter("All", "Ca 2");
            }
        }

        private void ca3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelScheduleList.Controls.Clear();
            toolStripMenuItemShift.Text = "Ca 3";
            if (toolStripMenuItemStatus.Text == "Working")
            {
                fillListByFilter("Working", "Ca 3");
            }
            else if (toolStripMenuItemStatus.Text == "Not Working")
            {
                fillListByFilter("Not Working", "Ca 3");
            }
            else
            {
                fillListByFilter("All", "Ca 3");
            }
        }

        private void comboBoxCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int msnv = (int)comboBoxID.SelectedValue;
                int maca = (int)comboBoxCa.SelectedValue;
                SqlCommand command1 = new SqlCommand("SELECT nvlamthay FROM Phanca as P, Ca as C WHERE P.maca = C.maca AND msnv = @msnv AND P.maca = @maca");
                command1.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
                command1.Parameters.Add("@maca", SqlDbType.Int).Value = maca;
                DataTable table1 = phanCa.getPhanCa(command1);
                textBoxIDNVLT.Text = table1.Rows[0]["nvlamthay"].ToString();
            }
            catch
            {

            }
        }
    }
}
