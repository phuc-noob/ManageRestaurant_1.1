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
    public partial class scheduleListWorkingItem : UserControl
    {
        public scheduleListWorkingItem()
        {
            InitializeComponent();
        }

        private Image picture;
        private string id;
        private string name;

        public Image Picture
        {
            get { return picture; }
            set { picture = value; pictureBoxPicture.Image = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; labelID.Text = value; }
        }

        public string EName
        {
            get { return name; }
            set { name = value; labelName.Text = value; }
        }

        private void scheduleListWorkingItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleListWorkingItem_Load(object sender, EventArgs e)
        {

        }
    }
}
