using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    public partial class itemMenu : UserControl
    {
        public itemMenu()
        {
            InitializeComponent();
        }

        private void itemMenu_Load(object sender, EventArgs e)
        {
            
        }
        public Label label()
        {
            return this.label_tenMonAn;
        }

        private void label_tenMonAn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button_minus_Click(object sender, EventArgs e)
        {
            if(this.label_amount.Text == "1")
            {

            }
            else
            {
                int i = int.Parse(this.label_cost.Text) / int.Parse(this.label_amount.Text);
                this.label_amount.Text = (int.Parse(this.label_amount.Text) - 1).ToString();
                this.label_cost.Text = (i * int.Parse(this.label_amount.Text)).ToString();  
            }
            

        }

        private void guna2Button_plus_Click(object sender, EventArgs e)
        {
            int i = int.Parse(this.label_cost.Text) / int.Parse(this.label_amount.Text);
            this.label_amount.Text = (int.Parse(this.label_amount.Text) + 1).ToString();
            this.label_cost.Text = (i * int.Parse(this.label_amount.Text)).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox_remove.BackColor = Color.DarkRed;
        }

        private void pictureBox_remove_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox_remove.BackColor = Color.Gray;
        }

        private void pictureBox_remove_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox_remove.BackColor = Color.Transparent;
        }
    }
}
