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
    public partial class addTypeFood : Form
    {
        public addTypeFood()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Cancer_Click(object sender, EventArgs e)
        {
            this.Close();
            addFood af = new addFood();
            af.Show();
        }

        private void Button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_food.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            MemoryStream pic = new MemoryStream();



            try
            {
                string name = tb_name.Text;
                pictureBox_food.Image.Save(pic, pictureBox_food.Image.RawFormat);
                food.insertTFoot(name, pic);


                    if (food.insertTFoot(name, pic))
                    {
                        MessageBox.Show("Add new student success", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error To Add Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
            //tf.name().Text = "drink";
            //tf.Top = 10;
            //tf.Left = 10;
            addFood af = new addFood();
            af.Show();
            this.Close();
        }

        private void addTypeFood_Load(object sender, EventArgs e)
        {

        }
    }
}
