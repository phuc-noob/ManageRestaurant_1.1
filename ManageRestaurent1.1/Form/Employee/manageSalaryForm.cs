using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class manageSalaryForm : Form
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSalary;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSearch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonCalculateSalary;
        private Guna.UI2.WinForms.Guna2Button buttonPay;
        private Guna.UI2.WinForms.Guna2CircleButton buttonPrint;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSave;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRemove;
        private Guna.UI2.WinForms.Guna2CircleButton buttonFilter;
        private Guna.UI2.WinForms.Guna2CircleButton buttonLoad;
        private MenuStrip menuStripFilter;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem todayToolStripMenuItem;
        private ToolStripMenuItem oneDayToolStripMenuItem1;
        private ToolStripMenuItem threeDayAgoToolStripMenuItem;
        private ToolStripMenuItem sevenDayAgoToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSalaryList;

        public manageSalaryForm()
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
            this.dataGridViewSalaryList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonCalculateSalary = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPay = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPrint = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonSave = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonFilter = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonLoad = new Guna.UI2.WinForms.Guna2CircleButton();
            this.menuStripFilter = new System.Windows.Forms.MenuStrip();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneDayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.threeDayAgoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevenDayAgoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryList)).BeginInit();
            this.menuStripFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSalaryList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSalaryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalaryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalaryList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalaryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSalaryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSalaryList.ColumnHeadersHeight = 40;
            this.dataGridViewSalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSalaryList.EnableHeadersVisualStyles = false;
            this.dataGridViewSalaryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewSalaryList.Location = new System.Drawing.Point(9, 90);
            this.dataGridViewSalaryList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSalaryList.Name = "dataGridViewSalaryList";
            this.dataGridViewSalaryList.ReadOnly = true;
            this.dataGridViewSalaryList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSalaryList.RowHeadersVisible = false;
            this.dataGridViewSalaryList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSalaryList.RowTemplate.DividerHeight = 1;
            this.dataGridViewSalaryList.RowTemplate.Height = 40;
            this.dataGridViewSalaryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalaryList.Size = new System.Drawing.Size(863, 388);
            this.dataGridViewSalaryList.TabIndex = 1;
            this.dataGridViewSalaryList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSalaryList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewSalaryList.ThemeStyle.ReadOnly = true;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(12, 12);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(84, 37);
            this.labelSalary.TabIndex = 3;
            this.labelSalary.Text = "Payroll";
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
            this.buttonSearch.Location = new System.Drawing.Point(213, 55);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSearch.ShadowDecoration.Parent = this.buttonSearch;
            this.buttonSearch.Size = new System.Drawing.Size(32, 32);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.textBoxSearch.Location = new System.Drawing.Point(9, 55);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Fname,Lname";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.ShadowDecoration.Parent = this.textBoxSearch;
            this.textBoxSearch.Size = new System.Drawing.Size(198, 32);
            this.textBoxSearch.TabIndex = 5;
            // 
            // buttonCalculateSalary
            // 
            this.buttonCalculateSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculateSalary.AutoRoundedCorners = true;
            this.buttonCalculateSalary.BorderRadius = 15;
            this.buttonCalculateSalary.BorderThickness = 1;
            this.buttonCalculateSalary.CheckedState.Parent = this.buttonCalculateSalary;
            this.buttonCalculateSalary.CustomImages.Parent = this.buttonCalculateSalary;
            this.buttonCalculateSalary.FillColor = System.Drawing.Color.White;
            this.buttonCalculateSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateSalary.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculateSalary.HoverState.Parent = this.buttonCalculateSalary;
            this.buttonCalculateSalary.Location = new System.Drawing.Point(713, 492);
            this.buttonCalculateSalary.Name = "buttonCalculateSalary";
            this.buttonCalculateSalary.ShadowDecoration.Parent = this.buttonCalculateSalary;
            this.buttonCalculateSalary.Size = new System.Drawing.Size(159, 33);
            this.buttonCalculateSalary.TabIndex = 7;
            this.buttonCalculateSalary.Text = "Calculate salary";
            this.buttonCalculateSalary.Click += new System.EventHandler(this.buttonCalculateSalary_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPay.AutoRoundedCorners = true;
            this.buttonPay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPay.BorderRadius = 15;
            this.buttonPay.BorderThickness = 1;
            this.buttonPay.CheckedState.Parent = this.buttonPay;
            this.buttonPay.CustomImages.Parent = this.buttonPay;
            this.buttonPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.HoverState.Parent = this.buttonPay;
            this.buttonPay.Location = new System.Drawing.Point(633, 492);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.ShadowDecoration.Parent = this.buttonPay;
            this.buttonPay.Size = new System.Drawing.Size(74, 33);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "Pay";
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrint.BorderColor = System.Drawing.Color.Transparent;
            this.buttonPrint.CheckedState.Parent = this.buttonPrint;
            this.buttonPrint.CustomImages.Parent = this.buttonPrint;
            this.buttonPrint.FillColor = System.Drawing.Color.Transparent;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.HoverState.Parent = this.buttonPrint;
            this.buttonPrint.Image = global::ManageRestaurent1._1.Properties.Resources.printer;
            this.buttonPrint.ImageSize = new System.Drawing.Size(16, 16);
            this.buttonPrint.Location = new System.Drawing.Point(840, 55);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonPrint.ShadowDecoration.Parent = this.buttonPrint;
            this.buttonPrint.Size = new System.Drawing.Size(32, 32);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSave.CheckedState.Parent = this.buttonSave;
            this.buttonSave.CustomImages.Parent = this.buttonSave;
            this.buttonSave.FillColor = System.Drawing.Color.Transparent;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.HoverState.Parent = this.buttonSave;
            this.buttonSave.Image = global::ManageRestaurent1._1.Properties.Resources.floppy_disk;
            this.buttonSave.ImageSize = new System.Drawing.Size(16, 16);
            this.buttonSave.Location = new System.Drawing.Point(802, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSave.ShadowDecoration.Parent = this.buttonSave;
            this.buttonSave.Size = new System.Drawing.Size(32, 32);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.BorderColor = System.Drawing.Color.Transparent;
            this.buttonRemove.CheckedState.Parent = this.buttonRemove;
            this.buttonRemove.CustomImages.Parent = this.buttonRemove;
            this.buttonRemove.FillColor = System.Drawing.Color.Transparent;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.HoverState.Parent = this.buttonRemove;
            this.buttonRemove.Image = global::ManageRestaurent1._1.Properties.Resources.rubbish;
            this.buttonRemove.ImageSize = new System.Drawing.Size(16, 16);
            this.buttonRemove.Location = new System.Drawing.Point(764, 55);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRemove.ShadowDecoration.Parent = this.buttonRemove;
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilter.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFilter.CheckedState.Parent = this.buttonFilter;
            this.buttonFilter.CustomImages.Parent = this.buttonFilter;
            this.buttonFilter.FillColor = System.Drawing.Color.Transparent;
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonFilter.ForeColor = System.Drawing.Color.White;
            this.buttonFilter.HoverState.Parent = this.buttonFilter;
            this.buttonFilter.Image = global::ManageRestaurent1._1.Properties.Resources.funnel;
            this.buttonFilter.ImageSize = new System.Drawing.Size(16, 16);
            this.buttonFilter.Location = new System.Drawing.Point(726, 55);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonFilter.ShadowDecoration.Parent = this.buttonFilter;
            this.buttonFilter.Size = new System.Drawing.Size(32, 32);
            this.buttonFilter.TabIndex = 13;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoad.BorderColor = System.Drawing.Color.Transparent;
            this.buttonLoad.CheckedState.Parent = this.buttonLoad;
            this.buttonLoad.CustomImages.Parent = this.buttonLoad;
            this.buttonLoad.FillColor = System.Drawing.Color.Transparent;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.HoverState.Parent = this.buttonLoad;
            this.buttonLoad.Image = global::ManageRestaurent1._1.Properties.Resources.rotateleft;
            this.buttonLoad.ImageSize = new System.Drawing.Size(16, 16);
            this.buttonLoad.Location = new System.Drawing.Point(688, 55);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonLoad.ShadowDecoration.Parent = this.buttonLoad;
            this.buttonLoad.Size = new System.Drawing.Size(32, 32);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // menuStripFilter
            // 
            this.menuStripFilter.BackColor = System.Drawing.Color.White;
            this.menuStripFilter.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripFilter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToolStripMenuItem});
            this.menuStripFilter.Location = new System.Drawing.Point(713, 90);
            this.menuStripFilter.Name = "menuStripFilter";
            this.menuStripFilter.Size = new System.Drawing.Size(64, 28);
            this.menuStripFilter.TabIndex = 15;
            this.menuStripFilter.Text = "menuStrip1";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.timeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.todayToolStripMenuItem,
            this.oneDayToolStripMenuItem1,
            this.threeDayAgoToolStripMenuItem,
            this.sevenDayAgoToolStripMenuItem1});
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.todayToolStripMenuItem_Click);
            // 
            // oneDayToolStripMenuItem1
            // 
            this.oneDayToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.oneDayToolStripMenuItem1.Name = "oneDayToolStripMenuItem1";
            this.oneDayToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.oneDayToolStripMenuItem1.Text = "1 days ago";
            this.oneDayToolStripMenuItem1.Click += new System.EventHandler(this.oneDayToolStripMenuItem1_Click);
            // 
            // threeDayAgoToolStripMenuItem
            // 
            this.threeDayAgoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.threeDayAgoToolStripMenuItem.Name = "threeDayAgoToolStripMenuItem";
            this.threeDayAgoToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.threeDayAgoToolStripMenuItem.Text = "3 days ago";
            this.threeDayAgoToolStripMenuItem.Click += new System.EventHandler(this.threeDayAgoToolStripMenuItem_Click);
            // 
            // sevenDayAgoToolStripMenuItem1
            // 
            this.sevenDayAgoToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.sevenDayAgoToolStripMenuItem1.Name = "sevenDayAgoToolStripMenuItem1";
            this.sevenDayAgoToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.sevenDayAgoToolStripMenuItem1.Text = "7 days ago";
            this.sevenDayAgoToolStripMenuItem1.Click += new System.EventHandler(this.sevenDayAgoToolStripMenuItem1_Click);
            // 
            // manageSalaryForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 537);
            this.Controls.Add(this.menuStripFilter);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonCalculateSalary);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.dataGridViewSalaryList);
            this.Name = "manageSalaryForm";
            this.Load += new System.EventHandler(this.manageSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryList)).EndInit();
            this.menuStripFilter.ResumeLayout(false);
            this.menuStripFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        Luong luong = new Luong();
        DiemDanh diemDanh = new DiemDanh();
        Employee employee = new Employee();
        PhanCa phanCa = new PhanCa();

        private void manageSalaryForm_Load(object sender, EventArgs e)
        {
            formLoad();
            menuStripFilter.Visible = false;
        }

        public void formLoad()
        {
            SqlCommand command = new SqlCommand("SELECT Picture, N.Msnv, Fname, Lname, Cast(Date as Date) As Date, Cast(Salary AS Decimal(10,0)) AS Salary, tinhtrang as 'Status' FROM Nhanvien as N, Luong as L" +
                " WHERE N.msnv = L.msnv");
            fillGrid(command);
        }

        public void fillGrid(SqlCommand command)
        {
            DataTable table = employee.getEmployees(command);
            dataGridViewSalaryList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewSalaryList.DataSource = table;
            picCol = (DataGridViewImageColumn)dataGridViewSalaryList.Columns[0];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewSalaryList.AllowUserToAddRows = false;
            dataGridViewSalaryList.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap thong tin nhan vien can tim", "Search Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT Picture, N.Msnv, Fname, Lname, Date, Salary, tinhtrang as 'Status' FROM Nhanvien as N, Luong as L" +
                " WHERE N.Msnv = L.msnv AND CONCAT(fname,lname) LIKE '%" + textBoxSearch.Text + "%'");
                fillGrid(command);
            }
        }

        /*public void tinhLuong()
        {
            SqlCommand command = new SqlCommand("SELECT D.msnv, D.checkin, D.checkout, C.thoigianbatdau, C.thoigianketthuc " +
                "FROM Diemdanh AS D, Phanca AS P, Ca AS C WHERE D.msnv = P.msnv AND P.maca = C.maca AND D.checkout IS NOT NULL ");
            DataTable table = diemDanh.getDiemDanh(command);
            SqlCommand command1 = new SqlCommand("SELECT msnv, noidungcv, luongcoso, hesoluong FROM Nhanvien, Congviec WHERE congviec = macv");
            DataTable table1 = employee.getEmployees(command1);
            table1.Columns.Add("tongtg", typeof(TimeSpan));
            table1.Columns.Add("luong", typeof(float));
            TimeSpan t = new TimeSpan(0, 0, 0);
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                table1.Rows[i]["tongtg"] = t;
                table1.Rows[i]["luong"] = 0;
            }
            if (table.Rows.Count > 0)
            {
                TimeSpan tStart, tEnd;
                DateTime checkIn, checkOut, startTime, endTime;
                int msnv;
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    msnv = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        if (msnv == Convert.ToInt32(table.Rows[j]["msnv"].ToString()))
                        {
                            checkIn = Convert.ToDateTime(table.Rows[j]["checkin"].ToString());
                            checkOut = Convert.ToDateTime(table.Rows[j]["checkout"].ToString());
                            startTime = Convert.ToDateTime(table.Rows[j]["thoigianbatdau"].ToString());
                            endTime = Convert.ToDateTime(table.Rows[j]["thoigianketthuc"].ToString());
                            if ((DateTime.Compare(checkIn, endTime) < 0) && (DateTime.Compare(checkOut, startTime) > 0))
                            {
                                if (DateTime.Compare(checkIn, startTime) <= 0)
                                {
                                    tStart = new TimeSpan(startTime.Hour, startTime.Minute, startTime.Second);
                                }
                                else
                                {
                                    tStart = new TimeSpan(checkIn.Hour, checkIn.Minute, checkIn.Second);
                                }

                                if (DateTime.Compare(checkOut, endTime) <= 0)
                                {
                                    tEnd = new TimeSpan(checkOut.Hour, checkOut.Minute, checkOut.Second);
                                }
                                else
                                {
                                    tEnd = new TimeSpan(endTime.Hour, endTime.Minute, checkOut.Second);
                                }
                                table1.Rows[i]["tongtg"] = Convert.ToDateTime(table1.Rows[i]["tongtg"].ToString()).Add(tEnd.Subtract(tStart)).TimeOfDay;
                            }
                        }
                    }

                }
                DateTime d;
                double hesoluong;
                double luongcoso;
                double x;
                SqlCommand command2 = new SqlCommand("SELECT * FROM Phanca WHERE nvlamthay is not null");
                DataTable table2 = phanCa.getPhanCa(command2);
                SqlCommand command3 = new SqlCommand("SELECT P.msnv, Count(P.maca) AS tongca FROM Phanca AS P, Nhanvien AS N, Congviec AS C WHERE P.msnv = N.msnv AND N.congviec = C.macv " +
                    " AND noidungcv = 'Quan ly' GROUP BY P.msnv");
                DataTable table3 = phanCa.getPhanCa(command3);


                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    d = Convert.ToDateTime(table1.Rows[i]["tongtg"].ToString());
                    hesoluong = Convert.ToDouble(table1.Rows[i]["hesoluong"].ToString());
                    luongcoso = Convert.ToDouble(table1.Rows[i]["luongcoso"].ToString());

                    if (table1.Rows[i]["Noidungcv"].ToString().Contains("Nhan vien"))
                    {
                        if (d.Hour >= 8)
                        {
                            table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;
                        }
                        else
                        {
                            x = (8 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong;
                            table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso - x;

                            for (int j = 0; j < table2.Rows.Count; j++)
                            {
                                if (Convert.ToInt32(table1.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table2.Rows[j]["msnv"]))
                                {
                                    for (int k = 0; k < table1.Rows.Count; k++)
                                    {
                                        if (Convert.ToInt32(table1.Rows[k]["msnv"]) == Convert.ToInt32(table2.Rows[j]["nvlamthay"].ToString()))
                                        {
                                            table1.Rows[k]["luong"] = Convert.ToDouble(table1.Rows[k]["luong"]) + x;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < table3.Rows.Count; j++)
                        {
                            if (Convert.ToInt32(table1.Rows[i]["msnv"]) == Convert.ToInt32(table1.Rows[j]["msnv"]))
                            {
                                if (Convert.ToInt32(table3.Rows[j]["tongca"].ToString()) == 2)
                                {
                                    if (d.Hour >= 8)
                                    {
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;
                                    }
                                    else
                                    {
                                        x = (8 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong;
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso - x;

                                        for (int m = 0; m < table2.Rows.Count; m++)
                                        {
                                            if (Convert.ToInt32(table1.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table2.Rows[m]["msnv"]))
                                            {
                                                for (int k = 0; k < table1.Rows.Count; k++)
                                                {
                                                    if (Convert.ToInt32(table1.Rows[k]["msnv"]) == Convert.ToInt32(table2.Rows[m]["nvlamthay"].ToString()))
                                                    {
                                                        table1.Rows[k]["luong"] = Convert.ToDouble(table1.Rows[k]["luong"]) + x;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (d.Hour >= 4)
                                    {
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"]) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;

                                    }
                                    else
                                    {
                                        x = (4 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong;
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"]) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso - x;

                                        for (int m = 0; m < table2.Rows.Count; m++)
                                        {
                                            if (Convert.ToInt32(table1.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table2.Rows[m]["msnv"]))
                                            {
                                                for (int k = 0; k < table1.Rows.Count; k++)
                                                {
                                                    if (Convert.ToInt32(table1.Rows[k]["msnv"]) == Convert.ToInt32(table2.Rows[m]["nvlamthay"].ToString()))
                                                    {
                                                        table1.Rows[k]["luong"] = Convert.ToDouble(table1.Rows[k]["luong"]) + x;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }

            int msnv1;
            double tluong;
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                msnv1 = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                tluong = Convert.ToDouble(table1.Rows[i]["luong"].ToString());
                luong.insertSalary(msnv1, DateTime.Now, tluong, "Chua Nhan");
            }
        }*/

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                int msnv = Convert.ToInt32(dataGridViewSalaryList.CurrentRow.Cells["Msnv"].Value);
                if (dataGridViewSalaryList.CurrentRow.Cells["Status"].Value.ToString() == "Chua Nhan")
                {
                    if (luong.updateLuong(msnv, "Da Nhan"))
                    {
                        MessageBox.Show("Da thanh toan", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formLoad();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nhan vien da nhan luong", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui long chon nhan vien", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void newTinhLuong()
        {
            SqlCommand command1 = new SqlCommand("SELECT NHANVIEN.msnv, noidungcv, luongcoso, hesoluong, maca, nvlamthay FROM Nhanvien, Congviec, PhanCa WHERE congviec = macv AND NHANVIEN.msnv = PhanCa.msnv");
            DataTable table1 = employee.getEmployees(command1);
            table1.Columns.Add("tongtg", typeof(TimeSpan));
            table1.Columns.Add("luong", typeof(float));
            TimeSpan t = new TimeSpan(0, 0, 0);
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                table1.Rows[i]["tongtg"] = t;
                table1.Rows[i]["luong"] = 0;
            }

            tinhLuongTheoCa(table1, 1);
            tinhLuongTheoCa(table1, 2);
            tinhLuongTheoCa(table1, 3);

            SqlCommand command = new SqlCommand("SELECT msnv FROM Nhanvien");
            DataTable table = employee.getEmployees(command);
            table.Columns.Add("luong", typeof(float));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["luong"] = 0;
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table1.Rows.Count; j++)
                {
                    if (Convert.ToInt32(table.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table1.Rows[j]["msnv"].ToString()))
                    {
                        table.Rows[i]["luong"] = Convert.ToDouble(table.Rows[i]["luong"]) + Convert.ToDouble(table1.Rows[j]["luong"]);
                    }
                }    
            }   

            saveLuong(table);
        }

        public void saveLuong(DataTable table)
        {
            int msnv1;
            double tluong;

            DateTime time = DateTime.Now;
            SqlCommand command2 = new SqlCommand("SELECT * FROM luong WHERE date >= @timeNow");
            command2.Parameters.Add("@timeNow", SqlDbType.Date).Value = time.Date;
            DataTable table2 = luong.getLuong(command2);

            for (int i = 0; i < table2.Rows.Count; i++)
            {
                msnv1 = Convert.ToInt32(table2.Rows[i]["msnv"].ToString());
                time = Convert.ToDateTime(table2.Rows[i]["date"].ToString());
                luong.deleteLuong(msnv1, time);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                msnv1 = Convert.ToInt32(table.Rows[i]["msnv"].ToString());
                tluong = Convert.ToDouble(table.Rows[i]["luong"].ToString());
                if (tluong < 0)
                {
                    luong.insertSalary(msnv1, DateTime.Now, 0, "Chua Nhan");
                }
                else
                {
                    luong.insertSalary(msnv1, DateTime.Now, tluong, "Chua Nhan");
                }
            }
        }

        public void tinhLuongTheoCa(DataTable table1, int ca)
        {
            DateTime d;
            double hesoluong;
            double luongcoso;
            double x;

            SqlCommand command = new SqlCommand("SELECT D.msnv, D.checkin, D.checkout, C.thoigianbatdau, C.thoigianketthuc " +
                "FROM Diemdanh AS D, Phanca AS P, Ca AS C WHERE D.msnv = P.msnv AND P.maca = C.maca AND D.checkout IS NOT NULL AND C.maca = @Ca");
            command.Parameters.Add("@Ca", SqlDbType.Int).Value = ca;
            DataTable table = diemDanh.getDiemDanh(command);

            TimeSpan tStart, tEnd;
            DateTime checkIn, checkOut, startTime, endTime;
            int msnv;
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if (Convert.ToInt32(table1.Rows[i]["maca"].ToString()) == ca)
                {
                    msnv = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        if (msnv == Convert.ToInt32(table.Rows[j]["msnv"].ToString()))
                        {
                            checkIn = Convert.ToDateTime(table.Rows[j]["checkin"].ToString());
                            checkOut = Convert.ToDateTime(table.Rows[j]["checkout"].ToString());
                            startTime = Convert.ToDateTime(table.Rows[j]["thoigianbatdau"].ToString());
                            endTime = Convert.ToDateTime(table.Rows[j]["thoigianketthuc"].ToString());
                            if ((DateTime.Compare(checkIn, endTime) < 0) && (DateTime.Compare(checkOut, startTime) > 0))
                            {
                                if (DateTime.Compare(checkIn, startTime) <= 0)
                                {
                                    tStart = new TimeSpan(startTime.Hour, startTime.Minute, startTime.Second);
                                }
                                else
                                {
                                    tStart = new TimeSpan(checkIn.Hour, checkIn.Minute, checkIn.Second);
                                }

                                if (DateTime.Compare(checkOut, endTime) <= 0)
                                {
                                    tEnd = new TimeSpan(checkOut.Hour, checkOut.Minute, checkOut.Second);
                                }
                                else
                                {
                                    tEnd = new TimeSpan(endTime.Hour, endTime.Minute, checkOut.Second);
                                }
                                table1.Rows[i]["tongtg"] = Convert.ToDateTime(table1.Rows[i]["tongtg"].ToString()).Add(tEnd.Subtract(tStart)).TimeOfDay;
                            }
                        }
                    }
                    d = Convert.ToDateTime(table1.Rows[i]["tongtg"].ToString());
                    hesoluong = Convert.ToDouble(table1.Rows[i]["hesoluong"].ToString());
                    luongcoso = Convert.ToDouble(table1.Rows[i]["luongcoso"].ToString());

                    if (d.Hour >= 4)
                    {
                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;
                    }
                    else
                    {
                        x = (4 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong;
                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso - x;
                        if (table1.Rows[i]["nvlamthay"].ToString().Trim() != "")
                        {
                            for (int j = 0; j < table1.Rows.Count; j++)
                            {
                                if (Convert.ToInt32(table1.Rows[i]["nvlamthay"].ToString()) == Convert.ToInt32(table1.Rows[j]["msnv"].ToString()))
                                {
                                    table1.Rows[j]["luong"] = Convert.ToDouble(table1.Rows[j]["luong"]) + x;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonCalculateSalary_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to calculate salary?", "Calculate salary", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                newTinhLuong();
                formLoad();
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (menuStripFilter.Visible == true)
            {
                menuStripFilter.Visible = false;
            }
            else
            {
                menuStripFilter.Visible = true;
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLoad();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                int msnv = (int)dataGridViewSalaryList.CurrentRow.Cells["msnv"].Value;
                DateTime d = Convert.ToDateTime(dataGridViewSalaryList.CurrentRow.Cells["Date"].Value.ToString());
                luong.deleteLuong(msnv, d);
                formLoad();
            /*}
            catch
            {

            }*/
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            formLoad();
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now.Date;
            DateTime endTime = nowTime.AddDays(1);
            DateTime startTime = nowTime;
            SqlCommand command = new SqlCommand("SELECT Picture, N.Msnv, Fname, Lname, Cast(Date as Date) AS Date, Cast(Salary AS Decimal(10,0)) AS Salary, tinhtrang as 'Status' FROM Nhanvien as N, Luong as L" +
                " WHERE N.msnv = L.msnv AND Date >= @startTime AND Date <= @endTime");
            command.Parameters.Add("@startTime", SqlDbType.Date).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Date).Value = endTime;
            fillGrid(command);
        }

        private void oneDayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now.Date;
            DateTime endTime = nowTime.AddDays(1);
            DateTime startTime = nowTime.AddDays(-1);
            SqlCommand command = new SqlCommand("SELECT Picture, N.Msnv, Fname, Lname, Cast(Date as Date) AS Date, Cast(Salary AS Decimal(10,0)) AS Salary, tinhtrang as 'Status' FROM Nhanvien as N, Luong as L" +
                " WHERE N.msnv = L.msnv AND Date >= @startTime AND Date <= @endTime");
            command.Parameters.Add("@startTime", SqlDbType.Date).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Date).Value = endTime;
            fillGrid(command);
        }

        private void threeDayAgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now.Date;
            DateTime endTime = nowTime.AddDays(1);
            DateTime startTime = nowTime.AddDays(-3);
            SqlCommand command = new SqlCommand("SELECT Picture, N.Msnv, Fname, Lname, Cast(Date as Date) AS Date, Cast(Salary AS Decimal(10,0)) AS Salary, tinhtrang as 'Status' FROM Nhanvien as N, Luong as L" +
                " WHERE N.msnv = L.msnv AND Date >= @startTime AND Date <= @endTime");
            command.Parameters.Add("@startTime", SqlDbType.Date).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Date).Value = endTime;
            fillGrid(command);
        }

        private void sevenDayAgoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now.Date;
            DateTime endTime = nowTime.AddDays(1);
            DateTime startTime = nowTime.AddDays(-7);
            SqlCommand command = new SqlCommand("SELECT Picture, N.Msnv, Fname, Lname, Cast(Date as Date) AS Date, Cast(Salary AS Decimal(10,0)) AS Salary, tinhtrang as 'Status' FROM Nhanvien as N, Luong as L" +
                " WHERE N.msnv = L.msnv AND Date >= @startTime AND Date <= @endTime");
            command.Parameters.Add("@startTime", SqlDbType.Date).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Date).Value = endTime;
            fillGrid(command);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            string tdate = "Ngày " + nowTime.Day + " tháng " + nowTime.Month + " năm " + nowTime.Year + "";
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridViewSalaryList.Rows.Count + 1 > 0)
            {
                Spire.Doc.Document doc = new Spire.Doc.Document();

                Paragraph paragraphTitle = doc.AddSection().AddParagraph();
                TextRange textTitle1 = paragraphTitle.AppendText("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM \n");
                TextRange textTitle2 = paragraphTitle.AppendText("Độc lập - Tự do - Hạnh phúc");
                textTitle1.CharacterFormat.FontName = "Times New Roman";
                textTitle1.CharacterFormat.FontSize = 14;
                textTitle1.CharacterFormat.Bold = true;
                textTitle2.CharacterFormat.FontName = "Times New Roman";
                textTitle2.CharacterFormat.FontSize = 13;
                textTitle2.CharacterFormat.Bold = true;
                textTitle2.CharacterFormat.Bold = true;
                paragraphTitle.Format.LineSpacing = 15;
                paragraphTitle.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                Spire.Doc.Documents.Paragraph paragraphLine = doc.Sections[0].AddParagraph();
                TextRange textTitle3 = paragraphLine.AppendText("----------------");
                textTitle3.CharacterFormat.FontName = "Times New Roman";
                textTitle3.CharacterFormat.FontSize = 14;
                paragraphLine.Format.LineSpacing = 20;
                paragraphLine.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                Spire.Doc.Documents.Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                TextRange text1 = paragraph1.AppendText("\nBẢNG LƯƠNG NHÂN VIÊN NHÀ HÀNG Q&P");
                text1.CharacterFormat.FontName = "Times New Roman";
                text1.CharacterFormat.FontSize = 16;
                paragraph1.Format.LineSpacing = 17;
                //paragraph1.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;  // đoạn canh giữa

                Spire.Doc.Documents.Paragraph paragraphDate = doc.Sections[0].AddParagraph();
                TextRange textDate = paragraphDate.AppendText(tdate);
                textDate.CharacterFormat.FontName = "Times New Roman";
                textDate.CharacterFormat.FontSize = 12;
                paragraphDate.Format.LineSpacing = 28;
                paragraphDate.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                Spire.Doc.Documents.Paragraph paragraphNote = doc.Sections[0].AddParagraph();
                TextRange textNote = paragraphNote.AppendText("Đơn vị salary: VNĐ");
                textNote.CharacterFormat.FontName = "Times New Roman";
                textNote.CharacterFormat.FontSize = 11;
                paragraphNote.Format.LineSpacing = 15;
                paragraphNote.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;

                Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                // Số dòng và số cột cho bảng
                table.ResetCells(dataGridViewSalaryList.Rows.Count + 1, dataGridViewSalaryList.Columns.Count - 1);
                for (int i = 0; i < dataGridViewSalaryList.Columns.Count - 1; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 200;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow Frow = table.Rows[0];
                Frow.IsHeader = true;
                Frow.Height = 23;

                for (int i = 0; i < dataGridViewSalaryList.Columns.Count - 1; i++)
                {
                    Spire.Doc.Documents.Paragraph p = Frow.Cells[i].AddParagraph();
                    Frow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Fields.TextRange tr = p.AppendText(dataGridViewSalaryList.Columns[i + 1].HeaderText);
                    tr.CharacterFormat.FontName = "Times New Roman";
                    tr.CharacterFormat.FontSize = 13;
                    tr.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < dataGridViewSalaryList.Rows.Count; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridViewSalaryList.Columns.Count - 1; j++)
                    {
                        DataRow.Height = 50;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridViewSalaryList.Rows[i].Cells[j + 1].Value.ToString());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 13;
                    }

                    DataRow.Cells[3].Paragraphs[0].Text = "";
                    DateTime date = (DateTime)dataGridViewSalaryList.Rows[i].Cells[4].Value;
                    string strDate = "" + date.Day + "/" + date.Month + "/" + date.Year;
                    DataRow.Cells[3].Paragraphs[0].Text = strDate;

                }

                Spire.Doc.Documents.Paragraph paragraphSign = doc.Sections[0].AddParagraph();
                TextRange textTitleSign1 = paragraphSign.AppendText("\nKý tên\t\t\n");
                TextRange textTitleSign2 = paragraphSign.AppendText("(Ghi rõ họ và tên)\n");
                textTitleSign1.CharacterFormat.FontName = "Times New Roman";
                textTitleSign1.CharacterFormat.FontSize = 13;
                textTitleSign2.CharacterFormat.FontName = "Times New Roman";
                textTitleSign2.CharacterFormat.FontSize = 12;
                paragraphSign.Format.LineSpacing = 15;
                paragraph1.Format.TextAlignment = TextAlignment.Center;
                paragraphSign.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;

                doc.SaveToFile(save.FileName);
                doc.Close();
            }
        }
    }
}
