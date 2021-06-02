using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        Guna2GradientPanel GpanelOpen;
        Guna2GradientPanel GpanelClose;
        Food food = new Food();
        List<ucFood> menu = new List<ucFood>();
        manageTable tb = new manageTable();
        //Guna2GradientPanel temp = new Guna2GradientPanel();
        public static Guna2GradientPanel temp
        {
            get;
            set;
        }
        public static Guna2GradientPanel panelMain
        {
            get;
            set;
        }
        public static List<ucFood> ListMenu
        {
            get;
            set;
        }
       
        // tạo danh dách món ăn global
        List<typeFood> listFood = new List<typeFood>();
        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        static Menu menuFood;
        private void Button_Foods_Click(object sender, EventArgs e)
        {
            // tạo danh sách hóa đơn món ăn
            menuFood = new Menu();

            //----------------------------------
            Button_Table.Checked = false;
            Button_Foods.Checked = true;
            GpanelClose.Visible = false;
            GpanelOpen = Panel_Foods;
            GpanelOpen.Visible = true;
            GpanelClose = Panel_Foods;
        }

        private void Button_Table_Click(object sender, EventArgs e)
        {

            Button_Foods.Checked = false;
            Button_Table.Checked = true;
            GpanelClose.Visible = false;
            GpanelOpen = Panel_Table;
            GpanelOpen.Visible = true;
            GpanelClose = Panel_Table;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Global.location_YmenuItem = 110;
            panelMain = new Guna2GradientPanel();
            panelMain.Dock = DockStyle.Fill ;

            temp = new Guna2GradientPanel();
            temp.Dock = DockStyle.Right;
            this.Button_Table.Checked = true;

            emptyTable tfood = new emptyTable();
            
           
            tfood.Top = 110;
            tfood.Left = 120;
            panelMain.Controls.Add(tfood);


            int x = 450;
            int y = 110;

            DataTable dt_table = tb.getAllTable();
            //Button_Table.Checked = true;
            TableInfo tbinfo = new TableInfo();
            tbinfo.Top = y;
            tbinfo.Left = x;
            for (int i = 0; i < dt_table.Rows.Count; i++)
            {
                TableInfo user_tb = new TableInfo();
                user_tb.label_tbName.Text = dt_table.Rows[i]["label"].ToString();
                user_tb.Top = y;
                user_tb.Left = x;
                if (x < 1000)
                {
                    x += 327;
                }
                else
                {
                    y += 235;
                    x = 120;
                }

                panelMain.Controls.Add(user_tb);
            }
            panelMain.Left = 50;
            //panelMain.Controls.Add(tbinfo);
            this.Controls.Add(panelMain);
            //this.FillTablePanel();
            GpanelOpen = Panel_Table;
            GpanelOpen.Visible = true;
            GpanelClose = Panel_Table;
            
        }

        public void FillTablePanel()
        {
            int x = 28;
            int y = 140;
            for(int i =0;i <= 30; i++)
            {
                TableInfo table = new TableInfo();
                
                

                if(x < 500)
                {
                    x = x + 422;
                    table.Left = x;
                    table.Top = y;
                }
                else
                {
                    x = 28;
                    y += 240;
                    table.Left = x;
                    table.Top = y;
                }
                
                
                this.Controls.Add(table);
            }
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            addFood aFood = new addFood();
            aFood.Show();
        }


        public void guna2GradientTileButton_ListFood_Click(object sender, EventArgs e)
        {
            Global.location_YmenuItem = 30;
            // tạo danh sách món ăn tạm thời
            temp = new Guna2GradientPanel();
            Label textMenu = new Label();
            textMenu.Text = "MENU";
            textMenu.Top = 30;
            textMenu.Left = 230;
            textMenu.ForeColor = Color.Blue;
            textMenu.Font = new Font("Arial", 25);
            textMenu.AutoSize = false;
            textMenu.Height = 40;
            textMenu.Width = 300;
            // ------------------------------------
            temp.Controls.Add(textMenu);
            temp.BackColor = Color.White;
            //temp.Left = 100;
            //temp.Dock = DockStyle.Right;
            temp.Top = 80;
            temp.Left = 1000;
            mainForm.temp.Width = 650;
            temp.Height = 800;
            
            
            int locationX = 130;
            int locationY = 100;
            mainForm.panelMain.Controls.Clear();
            mainForm.panelMain.Dock = DockStyle.Fill;
            mainForm.panelMain.Controls.Add(temp);
            mainForm.panelMain.BackColor = Color.Blue;
            DataTable tbFood = food.getFood();
            for (int i = 0; i < tbFood.Rows.Count; i++)
            {
                ucFood fItem = new ucFood();
                
                if (locationX >= mainForm.panelMain.Width - temp.Width-100)
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
                //locationY += 100;
            }
            ucMenuBar menu = new ucMenuBar();
            menu.Top = 583;
            menu.Left = 2;
            mainForm.temp.Controls.Add(menu);


        }

        private void guna2GradientTileButton_edit_Click(object sender, EventArgs e)
        {
            int locationX = 150;
            int locationY = 131;
            panelMain.Controls.Clear();
            DataTable tbFood = food.getFood();
            for (int i = 0; i < tbFood.Rows.Count; i++)
            {
                ucEditFood fItem = new ucEditFood();
                if (locationX >= panelMain.Width - fItem.Width)
                {
                    locationY += 210;
                    locationX = 40;
                }

                byte[] pic = (byte[])tbFood.Rows[i]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                fItem.getPanel().BackgroundImage = Image.FromStream(picture);

                fItem.getCost().Text = tbFood.Rows[i]["cost"].ToString();
                fItem.getLabel().Text = tbFood.Rows[i]["label"].ToString();
                panelMain.Controls.Add(fItem);
                fItem.Top = locationY;
                fItem.Left = locationX;
                locationX += 210;
                //locationY += 100;
            }
        }
        public Guna2GradientTileButton getEditFood()
        {
            return guna2GradientTileButton_edit;
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            //int x = 28;
            //int y = 10;
            //for (int i = 0; i <5; i++)
            //{
            //    TableInfo table = new TableInfo();



            //    if (x < 500)
            //    {
            //        x = x + 200;
            //        table.Left = x;
            //        table.Top = y;
            //    }
            //    else
            //    {
            //        x = 28;
            //        y += 10;
            //        table.Left = x;
            //        table.Top = y;
            //    }


            //    this.Controls.Add(table);
            //}
        }

        private void guna2GradientTileButton_addTable_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            Global.location_YmenuItem = 110;
            panelMain.Controls.Clear();
            this.Controls.Remove(panelMain);
            this.mainForm_Load(sender,e);
        }
    }
}
