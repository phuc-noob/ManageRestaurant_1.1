using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;

namespace ManageRestaurent1._1
{
    public partial class TableInfo : UserControl
    {
        public TableInfo()
        {
            InitializeComponent();
        }
        Food food = new Food();

        private void bt_thanhtoan_edit_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button_editTable_Click(object sender, EventArgs e)
        {
            // tạo danh sách món ăn tạm thời
            //mainForm.temp = new Guna2GradientPanel();
            Label textMenu = new Label();
            textMenu.Text = "MENU";
            textMenu.Top = 100;
            textMenu.Left = 230;
            textMenu.ForeColor = Color.Blue;
            textMenu.Font = new Font("Arial", 25);
            textMenu.AutoSize = false;
            textMenu.Height = 40;
            textMenu.Width = 300;
            // ------------------------------------
            mainForm.temp.Controls.Add(textMenu);
            mainForm.temp.BackColor = Color.White;
            //temp.Left = 100;
            //temp.Dock = DockStyle.Right;
            mainForm.temp.Top = 80;
            mainForm.temp.Left = 1050;
            mainForm.temp.Width = 550;
            mainForm.temp.Height = 800;


            int locationX = 130;
            int locationY = 100;
            mainForm.panelMain.Controls.Clear();
            mainForm.panelMain.Dock = DockStyle.Fill;
            mainForm.panelMain.Controls.Add(mainForm.temp);
            mainForm.panelMain.BackColor = Color.Blue;
            DataTable tbFood = food.getFood();
            for (int i = 0; i < tbFood.Rows.Count; i++)
            {
                ucFood fItem = new ucFood();

                if (locationX >= mainForm.panelMain.Width - mainForm.temp.Width-100)
                {
                    locationY += 230;
                    locationX = 130;
                }
                byte[] pic = (byte[])tbFood.Rows[i]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                fItem.BackgroundImage = Image.FromStream(picture);

                fItem.getCost().Text = tbFood.Rows[i]["cost"].ToString();
                fItem.getLabel().Text = tbFood.Rows[i]["label"].ToString();
                
                fItem.Top = locationY;
                fItem.Left = locationX;
                locationX += 210;
                mainForm.panelMain.Controls.Add(fItem);
            }
        }
    }
}
