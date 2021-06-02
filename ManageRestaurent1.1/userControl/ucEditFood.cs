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
    public partial class ucEditFood : UserControl
    {
        public ucEditFood()
        {
            InitializeComponent();
        }
        Food f = new Food();
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

        public Guna2Panel getPanel()
        {
            return this.guna2Panel_editFood;
        }
        private void guna2GradientTileButton_delete_Click(object sender, EventArgs e)
        {
            string label = guna2GradientTileButton_label.Text;
            if (f.deleteFoodByLabel(label))
            {
                MessageBox.Show("goog chop");
                this.Parent.Controls.Remove(this);
                

            }
        }

        private void guna2GradientTileButton_label_Click(object sender, EventArgs e)
        {
            editFood edit = new editFood();
            edit.Show();
            
            DataTable food = f.getFoodByLabel(this.guna2GradientTileButton_label.Text);
            edit.label().Text = food.Rows[0]["label"].ToString();
            edit.cost().Text = food.Rows[0]["cost"].ToString();

            // fill image
            byte[] pic = (byte[])food.Rows[0]["picture"];
            MemoryStream picture = new MemoryStream(pic);
            edit.getPictureBox().Image = Image.FromStream(picture);

            foreach (typeFood tf in edit.list_tF())
            {
                if (tf.getLabel().ToString() == food.Rows[0]["type"].ToString())
                {
                    tf.Checked(true);
                }
            }
        }
    }
}
