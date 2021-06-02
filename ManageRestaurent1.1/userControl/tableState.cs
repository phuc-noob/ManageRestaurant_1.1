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
    public partial class tableState : UserControl
    {
        public tableState()
        {
            InitializeComponent();
        }
       
        private void guna2Button_label_Click(object sender, EventArgs e)
        {
            this.guna2Button_label.Checked = true;
            Global.tableNumber = this.guna2Button_label.Text;
        }
    }
}
