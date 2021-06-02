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
    public partial class addFood : Form
    {
        public addFood()
        {
            InitializeComponent();
        }
        Food food = new Food();
        List<typeFood> list_tFood = new List<typeFood>();
        public List<typeFood> list_tF()
        {
            return this.list_tFood;
        }
        private void Button_Cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_picture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nice");
        }

        private void Button_typeFood_Click(object sender, EventArgs e)
        {
            addTypeFood fType = new addTypeFood();
            fType.Show();
            this.Close();
        }

        private void addFood_Load(object sender, EventArgs e)
        {
            int locationX = 40;
            int locationY = guna2TextBox_cost.Location.Y+60;
            DataTable tFood = food.getTFood();
            for(int r=0; r <tFood.Rows.Count; r++)
            {
                if(locationX > 647)
                {
                    locationX = 40;
                    locationY += 80;
                }
                typeFood tf = new typeFood();
                tf.name().Text = tFood.Rows[r]["label"].ToString();
                tf.Top = locationY;
                tf.Left = locationX;
                locationX += 100;
                locationY += 0;
                this.Controls.Add(tf);
                list_tFood.Add(tf);
            }
            Button_typeFood.Top = locationY;
            Button_typeFood.Left = locationX ;
        }
        public void Button_Table_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wait");
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = food.getFood().Rows.Count+1;

                string label = guna2TextBox_label.Text;
                float cost = float.Parse(guna2TextBox_cost.Text);
                string type = "food";
                foreach (typeFood t in list_tFood)
                {
                    if (t.stateCheck() == true)
                    {
                        type = t.name().Text;
                        break;
                    }
                    else
                    {
                        type = " ";
                    }
                }

                MemoryStream pic = new MemoryStream();
                guna2PictureBox_food.Image.Save(pic, guna2PictureBox_food.Image.RawFormat);

                if (food.insertFood(id,label, cost, type, pic) == true)
                {
                    MessageBox.Show("Add new student success", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error To Add Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                guna2PictureBox_food.Image = Image.FromFile(opf.FileName);
            }
        }

        public Guna2TextBox label()
        {
            return this.guna2TextBox_label;
        }
        public Guna2TextBox cost()
        {
            return this.guna2TextBox_cost;
        }
        public Guna2PictureBox getPictureBox()
        {
            return this.guna2PictureBox_food;
        }
    }
}
