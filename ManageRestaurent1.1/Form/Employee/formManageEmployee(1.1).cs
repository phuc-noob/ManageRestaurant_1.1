using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class formManageEmployee_1 : Form
    {
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewEmployeeList;

        public formManageEmployee_1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTotalEmployee = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuStripFilter = new System.Windows.Forms.MenuStrip();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rmaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.buttonCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLoad = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonPrint = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonSave = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonFilter = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).BeginInit();
            this.menuStripFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployeeList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployeeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmployeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployeeList.ColumnHeadersHeight = 40;
            this.dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployeeList.EnableHeadersVisualStyles = false;
            this.dataGridViewEmployeeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewEmployeeList.Location = new System.Drawing.Point(9, 96);
            this.dataGridViewEmployeeList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            this.dataGridViewEmployeeList.ReadOnly = true;
            this.dataGridViewEmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployeeList.RowHeadersVisible = false;
            this.dataGridViewEmployeeList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployeeList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEmployeeList.RowTemplate.DividerHeight = 1;
            this.dataGridViewEmployeeList.RowTemplate.Height = 40;
            this.dataGridViewEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployeeList.Size = new System.Drawing.Size(863, 432);
            this.dataGridViewEmployeeList.TabIndex = 0;
            this.dataGridViewEmployeeList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployeeList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployeeList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewEmployeeList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewEmployeeList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEmployeeList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEmployeeList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEmployeeList.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewEmployeeList.ThemeStyle.ReadOnly = true;
            this.dataGridViewEmployeeList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployeeList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmployeeList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEmployeeList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewEmployeeList.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridViewEmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.dataGridViewEmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoRoundedCorners = true;
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
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.HoverState.Parent = this.textBoxSearch;
            this.textBoxSearch.Location = new System.Drawing.Point(9, 60);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Fname,Lname,Address";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.ShadowDecoration.Parent = this.textBoxSearch;
            this.textBoxSearch.Size = new System.Drawing.Size(198, 32);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelTotalEmployee
            // 
            this.labelTotalEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalEmployee.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmployee.Location = new System.Drawing.Point(12, 12);
            this.labelTotalEmployee.Name = "labelTotalEmployee";
            this.labelTotalEmployee.Size = new System.Drawing.Size(131, 37);
            this.labelTotalEmployee.TabIndex = 2;
            this.labelTotalEmployee.Text = "Employees";
            // 
            // menuStripFilter
            // 
            this.menuStripFilter.BackColor = System.Drawing.Color.White;
            this.menuStripFilter.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripFilter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem});
            this.menuStripFilter.Location = new System.Drawing.Point(685, 96);
            this.menuStripFilter.Name = "menuStripFilter";
            this.menuStripFilter.Size = new System.Drawing.Size(81, 30);
            this.menuStripFilter.TabIndex = 10;
            this.menuStripFilter.Text = "menuStrip1";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.allToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem,
            this.rmaleToolStripMenuItem,
            this.femaleToolStripMenuItem1});
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.allToolStripMenuItem.Text = "Gender";
            // 
            // maleToolStripMenuItem
            // 
            this.maleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.maleToolStripMenuItem.Name = "maleToolStripMenuItem";
            this.maleToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.maleToolStripMenuItem.Text = "All";
            this.maleToolStripMenuItem.Click += new System.EventHandler(this.maleToolStripMenuItem_Click);
            // 
            // rmaleToolStripMenuItem
            // 
            this.rmaleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.rmaleToolStripMenuItem.Name = "rmaleToolStripMenuItem";
            this.rmaleToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.rmaleToolStripMenuItem.Text = "Male";
            this.rmaleToolStripMenuItem.Click += new System.EventHandler(this.rmaleToolStripMenuItem_Click);
            // 
            // femaleToolStripMenuItem1
            // 
            this.femaleToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.femaleToolStripMenuItem1.Name = "femaleToolStripMenuItem1";
            this.femaleToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.femaleToolStripMenuItem1.Text = "Female";
            this.femaleToolStripMenuItem1.Click += new System.EventHandler(this.femaleToolStripMenuItem1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.BorderColor = System.Drawing.Color.Transparent;
            this.buttonAdd.CheckedState.Parent = this.buttonAdd;
            this.buttonAdd.CustomImages.Parent = this.buttonAdd;
            this.buttonAdd.FillColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.HoverState.Parent = this.buttonAdd;
            this.buttonAdd.Image = global::ManageRestaurent1._1.Properties.Resources.plus__2_;
            this.buttonAdd.ImageSize = new System.Drawing.Size(44, 44);
            this.buttonAdd.Location = new System.Drawing.Point(823, 457);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonAdd.ShadowDecoration.Parent = this.buttonAdd;
            this.buttonAdd.Size = new System.Drawing.Size(46, 46);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.buttonCreateAccount.BorderThickness = 1;
            this.buttonCreateAccount.CheckedState.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.CustomImages.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.FillColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateAccount.HoverState.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.Location = new System.Drawing.Point(510, 63);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.ShadowDecoration.Parent = this.buttonCreateAccount;
            this.buttonCreateAccount.Size = new System.Drawing.Size(131, 30);
            this.buttonCreateAccount.TabIndex = 12;
            this.buttonCreateAccount.Text = "Create account";
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
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
            this.buttonLoad.Location = new System.Drawing.Point(647, 61);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonLoad.ShadowDecoration.Parent = this.buttonLoad;
            this.buttonLoad.Size = new System.Drawing.Size(32, 32);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
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
            this.buttonPrint.Location = new System.Drawing.Point(837, 61);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonPrint.ShadowDecoration.Parent = this.buttonPrint;
            this.buttonPrint.Size = new System.Drawing.Size(32, 32);
            this.buttonPrint.TabIndex = 9;
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
            this.buttonSave.Location = new System.Drawing.Point(799, 60);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSave.ShadowDecoration.Parent = this.buttonSave;
            this.buttonSave.Size = new System.Drawing.Size(32, 32);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.buttonFilter.Location = new System.Drawing.Point(685, 61);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonFilter.ShadowDecoration.Parent = this.buttonFilter;
            this.buttonFilter.Size = new System.Drawing.Size(32, 32);
            this.buttonFilter.TabIndex = 7;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BorderColor = System.Drawing.Color.Transparent;
            this.buttonEdit.CheckedState.Parent = this.buttonEdit;
            this.buttonEdit.CustomImages.Parent = this.buttonEdit;
            this.buttonEdit.FillColor = System.Drawing.Color.Transparent;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.HoverState.Parent = this.buttonEdit;
            this.buttonEdit.Image = global::ManageRestaurent1._1.Properties.Resources.edit;
            this.buttonEdit.ImageSize = new System.Drawing.Size(16, 16);
            this.buttonEdit.Location = new System.Drawing.Point(723, 60);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonEdit.ShadowDecoration.Parent = this.buttonEdit;
            this.buttonEdit.Size = new System.Drawing.Size(32, 32);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            this.buttonRemove.Location = new System.Drawing.Point(761, 60);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRemove.ShadowDecoration.Parent = this.buttonRemove;
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
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
            this.buttonSearch.Location = new System.Drawing.Point(213, 60);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSearch.ShadowDecoration.Parent = this.buttonSearch;
            this.buttonSearch.Size = new System.Drawing.Size(32, 32);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // formManageEmployee_1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 537);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.menuStripFilter);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTotalEmployee);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewEmployeeList);
            this.Name = "formManageEmployee_1";
            this.Load += new System.EventHandler(this.formManageEmployee_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).EndInit();
            this.menuStripFilter.ResumeLayout(false);
            this.menuStripFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTotalEmployee;
        private Guna.UI2.WinForms.Guna2CircleButton buttonAdd;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSearch;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRemove;
        private Guna.UI2.WinForms.Guna2CircleButton buttonEdit;
        private Guna.UI2.WinForms.Guna2CircleButton buttonFilter;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSave;
        private Guna.UI2.WinForms.Guna2CircleButton buttonPrint;
        private MenuStrip menuStripFilter;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem maleToolStripMenuItem;
        private ToolStripMenuItem rmaleToolStripMenuItem;
        private ToolStripMenuItem femaleToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonLoad;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.ComponentModel.IContainer components;
        Employee employee = new Employee();
        private Guna.UI2.WinForms.Guna2Button buttonCreateAccount;
        Account account = new Account();

        private void formManageEmployee_1_Load(object sender, EventArgs e)
        {
            formLoad();
            menuStripFilter.Visible = false;
        }

        public void formLoad()
        {
            SqlCommand command = new SqlCommand("SELECT Picture, Msnv, Fname, Lname, Cast(Birthdate AS Date) AS Birthdate, Gender, Phone, Address, noidungcv as 'Cong viec' FROM Nhanvien, congviec WHERE congviec = macv");
            DataTable table = employee.getEmployees(command);
            dataGridViewEmployeeList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewEmployeeList.DataSource = table;
            picCol = (DataGridViewImageColumn)dataGridViewEmployeeList.Columns[0];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewEmployeeList.Columns[8].Width = 115;
            dataGridViewEmployeeList.AllowUserToAddRows = false;
            dataGridViewEmployeeList.Show();
            labelTotalEmployee.Text = "Employees (" + table.Rows.Count + ")";
        }

        public void fillGrid(SqlCommand command)
        {
            DataTable table = employee.getEmployees(command);
            dataGridViewEmployeeList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewEmployeeList.DataSource = table;
            picCol = (DataGridViewImageColumn)dataGridViewEmployeeList.Columns[0];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewEmployeeList.Columns[8].Width = 115;
            dataGridViewEmployeeList.AllowUserToAddRows = false;
            dataGridViewEmployeeList.Show();
            labelTotalEmployee.Text = "Employees (" + table.Rows.Count + ")";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            formLoad();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editEmployeeForm editForm = new editEmployeeForm();
            editForm.Show();
            editForm.fillForm(Convert.ToInt32(dataGridViewEmployeeList.CurrentRow.Cells["Msnv"].Value.ToString()));
            formLoad();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            string tdate = "Ngày " + nowTime.Day + " tháng " + nowTime.Month + " năm " + nowTime.Year + "";
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridViewEmployeeList.Rows.Count + 1 > 0)
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
                TextRange text1 = paragraph1.AppendText("\nBẢNG DANH SÁCH NHÂN VIÊN NHÀ HÀNG Q&P");
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

                Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                // Số dòng và số cột cho bảng
                table.ResetCells(dataGridViewEmployeeList.Rows.Count + 1, dataGridViewEmployeeList.Columns.Count - 1);
                for (int i = 0; i < dataGridViewEmployeeList.Columns.Count - 1; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 200;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow Frow = table.Rows[0];
                Frow.IsHeader = true;
                Frow.Height = 23;

                for (int i = 0; i < dataGridViewEmployeeList.Columns.Count - 1; i++)
                {
                    Spire.Doc.Documents.Paragraph p = Frow.Cells[i].AddParagraph();
                    Frow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Fields.TextRange tr = p.AppendText(dataGridViewEmployeeList.Columns[i + 1].HeaderText);
                    tr.CharacterFormat.FontName = "Times New Roman";
                    tr.CharacterFormat.FontSize = 13;
                    tr.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < dataGridViewEmployeeList.Rows.Count; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridViewEmployeeList.Columns.Count - 1; j++)
                    {
                        DataRow.Height = 50;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridViewEmployeeList.Rows[i].Cells[j + 1].Value.ToString());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 13;
                    }

                    DataRow.Cells[3].Paragraphs[0].Text = "";
                    DateTime date = (DateTime)dataGridViewEmployeeList.Rows[i].Cells[4].Value;
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap thong tin nhan vien can tim", "Search Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
            else
            {
                SqlCommand command = new SqlCommand("SELECT Picture, Msnv, Fname, Lname, Birthdate, Gender, Phone, Address, noidungcv as 'Cong viec'" +
                        " FROM Nhanvien, Congviec WHERE congviec = macv AND CONCAT(fname,lname,address) LIKE '%" + textBoxSearch.Text + "%'");
                fillGrid(command);
            }    
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addEmployeeForm_1 addEmployee = new addEmployeeForm_1();
            addEmployee.Show();
            formLoad();
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

        private void maleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLoad();
            menuStripFilter.Visible = false;
        }

        private void rmaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Picture, Msnv, Fname, Lname, Birthdate, Gender, Phone, Address, noidungcv as 'Cong viec'" +
                        " FROM Nhanvien, Congviec WHERE congviec = macv AND Gender = @gender");
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = "Male";
            fillGrid(command);
            menuStripFilter.Visible = false;
        }

        private void femaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Picture, Msnv, Fname, Lname, Birthdate, Gender, Phone, Address, noidungcv as 'Cong viec'" +
                        " FROM Nhanvien, Congviec WHERE congviec = macv AND Gender = @gender");
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = "Female";
            fillGrid(command);
            menuStripFilter.Visible = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            int msnv = (int)dataGridViewEmployeeList.CurrentRow.Cells["Msnv"].Value;
            if (MessageBox.Show("Are you sure you want to delete this employee", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (employee.deleteEmployee(msnv))
                {
                    MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (account.deleteAccount(msnv))
                    {
                        MessageBox.Show("Account deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Account not deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    formLoad();
                }
                else
                {
                    MessageBox.Show("Employee not deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            createAccountForm createfrm = new createAccountForm();
            createfrm.Show();
            createfrm.formFill(Convert.ToInt32(dataGridViewEmployeeList.CurrentRow.Cells["Msnv"].Value.ToString()));
        }
    }
}
