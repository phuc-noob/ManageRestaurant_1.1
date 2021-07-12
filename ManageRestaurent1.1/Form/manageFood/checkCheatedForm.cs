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
    class checkCheatedForm : Form
    {
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxIngredient;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxDish;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAmount;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonCheck;
        private Guna.UI2.WinForms.Guna2CircleButton buttonCancel;

        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonCheck = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxIngredient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxDish = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.buttonCheck);
            this.guna2Panel1.Controls.Add(this.buttonAdd);
            this.guna2Panel1.Controls.Add(this.textBoxAmount);
            this.guna2Panel1.Controls.Add(this.comboBoxIngredient);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.comboBoxDish);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.buttonCancel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(357, 368);
            this.guna2Panel1.TabIndex = 51;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // buttonCheck
            // 
            this.buttonCheck.CheckedState.Parent = this.buttonCheck;
            this.buttonCheck.CustomImages.Parent = this.buttonCheck;
            this.buttonCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.HoverState.Parent = this.buttonCheck;
            this.buttonCheck.Location = new System.Drawing.Point(32, 299);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.ShadowDecoration.Parent = this.buttonCheck;
            this.buttonCheck.Size = new System.Drawing.Size(295, 36);
            this.buttonCheck.TabIndex = 59;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.CheckedState.Parent = this.buttonAdd;
            this.buttonAdd.CustomImages.Parent = this.buttonAdd;
            this.buttonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.HoverState.Parent = this.buttonAdd;
            this.buttonAdd.Location = new System.Drawing.Point(249, 244);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.ShadowDecoration.Parent = this.buttonAdd;
            this.buttonAdd.Size = new System.Drawing.Size(78, 34);
            this.buttonAdd.TabIndex = 58;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAmount.DefaultText = "";
            this.textBoxAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAmount.DisabledState.Parent = this.textBoxAmount;
            this.textBoxAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAmount.FocusedState.Parent = this.textBoxAmount;
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.ForeColor = System.Drawing.Color.Black;
            this.textBoxAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAmount.HoverState.Parent = this.textBoxAmount;
            this.textBoxAmount.Location = new System.Drawing.Point(32, 244);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.PasswordChar = '\0';
            this.textBoxAmount.PlaceholderText = "Amount";
            this.textBoxAmount.SelectedText = "";
            this.textBoxAmount.ShadowDecoration.Parent = this.textBoxAmount;
            this.textBoxAmount.Size = new System.Drawing.Size(210, 34);
            this.textBoxAmount.TabIndex = 57;
            // 
            // comboBoxIngredient
            // 
            this.comboBoxIngredient.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxIngredient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIngredient.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxIngredient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxIngredient.FocusedState.Parent = this.comboBoxIngredient;
            this.comboBoxIngredient.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIngredient.ForeColor = System.Drawing.Color.Black;
            this.comboBoxIngredient.HoverState.Parent = this.comboBoxIngredient;
            this.comboBoxIngredient.ItemHeight = 30;
            this.comboBoxIngredient.ItemsAppearance.Parent = this.comboBoxIngredient;
            this.comboBoxIngredient.Location = new System.Drawing.Point(32, 201);
            this.comboBoxIngredient.Name = "comboBoxIngredient";
            this.comboBoxIngredient.ShadowDecoration.Parent = this.comboBoxIngredient;
            this.comboBoxIngredient.Size = new System.Drawing.Size(295, 36);
            this.comboBoxIngredient.TabIndex = 56;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(32, 173);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 22);
            this.guna2HtmlLabel1.TabIndex = 55;
            this.guna2HtmlLabel1.Text = "Used ingredient";
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxDish.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDish.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDish.FocusedState.Parent = this.comboBoxDish;
            this.comboBoxDish.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDish.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDish.HoverState.Parent = this.comboBoxDish;
            this.comboBoxDish.ItemHeight = 30;
            this.comboBoxDish.ItemsAppearance.Parent = this.comboBoxDish;
            this.comboBoxDish.Location = new System.Drawing.Point(32, 126);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.ShadowDecoration.Parent = this.comboBoxDish;
            this.comboBoxDish.Size = new System.Drawing.Size(295, 36);
            this.comboBoxDish.TabIndex = 54;
            this.comboBoxDish.SelectedIndexChanged += new System.EventHandler(this.comboBoxDish_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(32, 98);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 22);
            this.guna2HtmlLabel3.TabIndex = 53;
            this.guna2HtmlLabel3.Text = "Select a dish";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(32, 38);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(185, 39);
            this.guna2HtmlLabel2.TabIndex = 40;
            this.guna2HtmlLabel2.Text = "Check Cheated";
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
            // checkCheatedForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 368);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkCheatedForm";
            this.Load += new System.EventHandler(this.checkCheatedForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        // so luong mon an co the nau
        private int numOfDish = 0;

        private void checkCheatedForm_Load(object sender, EventArgs e)
        {
            // lay danh sach mon an
            /*
            SqlCommand command = new SqlCommand("SELECT * FROM Dish");
            comboBoxDish.DataSource = Dish.getDish(command);
            comboBoxDish.DisplayMember = "Dish_Name";
            comboBoxDish.ValueMember = "Dish-Id";
            */
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // lay danh sach nguyen lieu cua mon an duoc chon
                int id = (int)comboBoxDish.SelectedValue;
                /*
                SqlCommand command = new SqlCommand("SELECT * FROM recipe");
                comboBoxIngredient.DataSource = recipe.getRecipe(command);
                comboBoxIngredient.ValueMember = "Id";
                comboBoxIngredient.DisplayMember = "Name";
                 */

            }
            catch
            {

            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (numOfDish != 0)
                {
                    int id = (int)comboBoxDish.SelectedValue;
                    // lấy số lượng món ăn được chọn đã bán trong ngày
                    SqlCommand command = new SqlCommand("SELECT Sum(name) FROM Bill WHERE id = @id");
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    /*
                    DataTable table = bill.getBill(command);
                    int total = Convert.ToInt32(table.Rows[0][0]);
                    int sub = numOfDish - total;
                    if ((double) sub / total > 0.05)
                    {
                        MessageBox.Show("Cheated", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not Cheated", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    */
                }
            }
            catch
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBoxIngredient.SelectedIndex;
                double a = Convert.ToDouble(textBoxAmount.Text);
                SqlCommand command = new SqlCommand("SELECT soluong FROM recipe WHERE id = @id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                // lay so luong nguyen lieu duoc chon can de nau 1 mon an duoc chon
                /*
                DataTable table = recipe.getRecipe(command);
                numOfDish = a / Conver.toDouble(table.Rows[0][0].ToString());
                */
            }
            catch
            {
                MessageBox.Show("Empty Fields", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
