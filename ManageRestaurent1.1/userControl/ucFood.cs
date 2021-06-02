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

namespace ManageRestaurent1._1
{
    public partial class ucFood : UserControl
    {
        public ucFood()
        {
            InitializeComponent();
        }
        Food f = new Food();
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void food_Load(object sender, EventArgs e)
        {

        }
        public Guna2GradientTileButton getLabel()
        {
            return guna2GradientTileButton_label;
        }
        public Guna2GradientTileButton getCost()
        {
            return guna2GradientTileButton_cost;
        }
        public Image getPicture()
        {
            return BackgroundImage;
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void guna2GradientTileButton_label_Click(object sender, EventArgs e)
        {
            
            string label = guna2GradientTileButton_label.Text;
            DataTable dt = f.getFoodByLabel(label);
            
            if (Menu.lName.Contains(label))
            {
                foreach(itemMenu t in Menu.menuitem)
                {
                    if(t.label_tenMonAn.Text == label)
                    {
                        int j = int.Parse(t.label_cost.Text) / int.Parse(t.label_amount.Text);
                        int i = int.Parse(t.label_amount.Text);
                        t.label_amount.Text = (i+1).ToString();
                        t.label_cost.Text = (j * int.Parse(t.label_amount.Text)).ToString();
                    }
                }
            }
            else
            {
                itemMenu t = new itemMenu();
                t.Name = dt.Rows[0]["label"].ToString();
                t.label_cost.Text = dt.Rows[0]["cost"].ToString();
                t.label_tenMonAn.Text = dt.Rows[0]["label"].ToString();
                t.label_amount.Text = 1.ToString();
                int locationX = 10;
                Global.location_YmenuItem += 60;
                t.Top = Global.location_YmenuItem;
                t.Left = locationX;
                //t.Left = 20;
                mainForm.temp.Controls.Add(t);
                Menu.menuitem.Add(t);
            }
            Menu.lName.Add(label);
        }
    }
}
