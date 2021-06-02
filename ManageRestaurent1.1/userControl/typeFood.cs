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
    public partial class typeFood : UserControl
    {
        public typeFood()
        {
            InitializeComponent();
        }
        string tfood;
        public Guna2GradientButton name()
        {
            return Button_Table;
        }
        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public string getLabel()
        {
            return Button_Table.Text;
        }
        
        private void Button_Table_Click(object sender, EventArgs e)
        {
            tfood = Button_Table.Text;
            if (Button_Table.Checked == true)
            {
                Button_Table.Checked = false;
            }
            else
            {
                Button_Table.Checked = true;
            }
            
        }
        public bool stateCheck()
        {
            return Button_Table.Checked;
        }
        public void Checked(bool value)
        {
            Button_Table.Checked = value;
        }

    }
}
