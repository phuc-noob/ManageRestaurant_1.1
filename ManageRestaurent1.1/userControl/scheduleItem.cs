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
    public partial class scheduleItem : UserControl
    {
        public scheduleItem()
        {
            InitializeComponent();
        }

        private string shift;

        public string Shift
        {
            get { return shift; }
            set { shift = value; labelShift.Text = shift; }
        }
    }
}
