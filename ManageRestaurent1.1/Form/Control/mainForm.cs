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
        Guna2GradientTileButton GpanelOpenFood;
        Guna2GradientPanel GpanelOpen;
        Guna2GradientPanel GpanelClose;
        Guna2GradientButton Gclose;
        Food food = new Food();
        List<ucFood> menu = new List<ucFood>();
        manageTable tb = new manageTable();
        bill Bill = new bill();
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

            try
            {
                if (GpanelOpenFood != null)
                {
                    GpanelOpenFood.Checked = false;
                }
               
            }catch(Exception ex)
            {

            }
            finally
            {
                GpanelOpenFood = listF;
                GpanelOpenFood.Checked = true;
            }
            
            
            // tạo danh sách hóa đơn món ăn
            menuFood = new Menu();
            Gclose.Checked = false;
            Gclose = Button_Foods;
            Gclose.Checked = true;
            Button_Table.Checked = false;
            Button_Foods.Checked = true;
            GpanelClose.Visible = false;
            GpanelOpen = Panel_Foods;
            GpanelOpen.Visible = true;
            //----------------------------------
            if (!Global.isMangage)
            {
                addF.Visible = false;
                listF.Visible = false;
                EditF.Visible = false;

            }
            
            GpanelClose = Panel_Foods;

            guna2GradientTileButton_ListFood_Click(sender, e);
        }

        private void Button_Table_Click(object sender, EventArgs e)
        {
            Gclose.Checked = false;
            Gclose = Button_Table;
            Gclose.Checked = true;
            Button_Foods.Checked = false;
            Button_Table.Checked = true;
            GpanelClose.Visible = false;
            GpanelOpen = Panel_Table;
            GpanelOpen.Visible = true;
            GpanelClose = Panel_Table;

            Global.location_YmenuItem = 110;
            panelMain.Controls.Clear();
            this.Controls.Remove(panelMain);
            this.mainForm_Load(sender, e);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if(!Global.isMangage)
            {
                staticBt.Visible = false;
            }    
            Gclose = Button_Table;
            Global.bill_id = Bill.getb_bill().Rows.Count;
            Global.location_YmenuItem = 110;
            panelMain = new Guna2GradientPanel();
            panelMain.Dock = DockStyle.Fill ;
            panelMain.BackColor = Color.White;
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
                user_tb.label_total.Text = dt_table.Rows[i]["total"].ToString();
                if (dt_table.Rows[i]["status"].ToString() == "1")
                {
                    DateTime time = DateTime.Parse(dt_table.Rows[i]["checkin"].ToString());
                    user_tb.label_checkin.Text = time.ToString("HH:mm");
                }
                
                
                user_tb.label_amount.Text = dt_table.Rows[i]["amount"].ToString();
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
            GpanelOpen.Visible =false;
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
            GpanelOpenFood.Checked = false;
            GpanelOpenFood = addF;
            GpanelOpenFood.Checked = true;
            addFood aFood = new addFood();
            aFood.Show();
        }
        public static ucMenuBar menuBar = new ucMenuBar();

        public void guna2GradientTileButton_ListFood_Click(object sender, EventArgs e)
        {
            GpanelOpenFood.Checked = false;
            GpanelOpenFood = listF;
            GpanelOpenFood.Checked = true;
            Global.billFood = new DataTable();
            Global.billFood.Columns.Add("id", typeof(System.Int32));
            Global.billFood.Columns.Add("f_id", typeof(System.Int32));
            Global.billFood.Columns.Add("price", typeof(System.Int32));
            Global.billFood.Columns.Add("label", typeof(System.String));
            Global.billFood.Columns.Add("sl", typeof(System.Int32));
            Global.billFood.Columns.Add("giamGia", typeof(System.Int32));
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
            temp.BackColor = Color.DarkKhaki;
            mainForm.temp.Width = 650;
            temp.Height = 800;
            
            
            int locationX = 130;
            int locationY = 100;
            mainForm.panelMain.Controls.Clear();
            mainForm.panelMain.Dock = DockStyle.Fill;
            mainForm.panelMain.Controls.Add(temp);
            mainForm.panelMain.BackColor = Color.White;
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
            
            menuBar.Top = 583;
            menuBar.Left = 2;
            menuBar.label_total.Text = "00000";
            mainForm.temp.Controls.Add(menuBar);
        }
        
        private void guna2GradientTileButton_edit_Click(object sender, EventArgs e)
        {
            GpanelOpenFood.Checked = false;
            GpanelOpenFood = EditF;
            GpanelOpenFood.Checked = true;
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
                    locationX = 150;
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
            return EditF;
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Gclose.Checked = false;
            Gclose = guna2GradientTileButton_NhanVien;
            Gclose.Checked = true;
            cooker cook = new cooker();
            mainForm.panelMain.Controls.Clear();
            cook.Show();

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
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

        private void guna2GradientTileButton_employee_Click(object sender, EventArgs e)
        {
            // Button_Table.Checked = false;
            //Button_Foods.Checked = true;
            Gclose.Checked = false;
            Gclose = guna2GradientTileButton_employee;
            Gclose.Checked = true;
            guna2GradientTileButton_employee.Checked =true;
            GpanelClose.Visible = false;
            GpanelOpen = Panel_Foods;
            GpanelOpen.Visible = true;
            GpanelClose = Panel_Foods;

            int locationX = 200;
            int locationY = 200;
            mainForm.panelMain.BackColor = Color.White;
            mainForm.panelMain.Controls.Clear();
            if (Global.isMangage)
            {
                List<string> lfunction = new List<string>() {
                "CheckIn / Out",
                "Change Password",
                "Manage Employee",
                "Manage Salary",
                "Manage Shift",
                "Login",
                };
                for (int i = 0; i < 6; i++)
                {
                    //locationY += 100;
                    itemEmployee employee = new itemEmployee();
                    employee.guna2Button.Text = lfunction[i];
                    employee.Top = locationY;
                    employee.Left = locationX;
                    mainForm.panelMain.Controls.Add(employee);
                    locationX += 200;
                }
            }
            else
            {
                List<string> lfunction = new List<string>() {
                "CheckIn / Out",
                "Change Password",
                //"Manage Employee",
                //"Manage Salary",
                //"Manage Shift",
                "Login",
                };

                for (int i = 0; i < 3; i++)
                {
                    //locationY += 100;
                    itemEmployee employee = new itemEmployee();
                    employee.guna2Button.Text = lfunction[i];
                    employee.Top = locationY;
                    employee.Left = locationX;
                    mainForm.panelMain.Controls.Add(employee);
                    locationX += 200;
                }
            }
            
            
           
        }

        private void guna2GradientTileButton_static_Click(object sender, EventArgs e)
        {
            mainForm.panelMain.Controls.Clear();
            mainForm.panelMain.BackColor = Color.White;
            bill b = new bill();
            Gclose.Checked = false;
            Gclose = staticBt;
            Gclose.Checked = true;
            ucstatic sta = new ucstatic();
            sta.Top = 85;
            sta.Left = 150;
            mainForm.panelMain.Controls.Add(sta);
        }
    }
}
