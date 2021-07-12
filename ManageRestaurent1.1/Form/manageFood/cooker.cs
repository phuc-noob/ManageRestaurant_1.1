using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    public partial class cooker : Form
    {
        public cooker()
        {
            InitializeComponent();
        }
        bill b = new bill();
        private void cooker_Load(object sender, EventArgs e)
        {
            DataTable cook = b.getCooker();
            dataGridView_cooker.DataSource = cook;
            dataGridView_cooker.Columns["label"].DisplayIndex = 2;
            dataGridView_cooker.Columns[0].HeaderText = "ID BILL";
            dataGridView_cooker.Columns[1].HeaderText = "ID FOOD";
            dataGridView_cooker.Columns[2].HeaderText = "Price";
            dataGridView_cooker.Columns[3].HeaderText = "Quantity";
            dataGridView_cooker.Columns[4].HeaderText = "LABEL";

            dataGridView_cooker.Columns.Remove("state");
            dataGridView_cooker.Columns.Remove("giamgia");
        }

        private void guna2Button_done_Click(object sender, EventArgs e)
        {
            int bid =int.Parse(dataGridView_cooker.CurrentRow.Cells[0].Value.ToString());
            int fid = int.Parse(dataGridView_cooker.CurrentRow.Cells[1].Value.ToString());
            b.cookdone(bid, fid);
            this.cooker_Load(sender, e);
        }

        private void guna2Button_cancer_Click(object sender, EventArgs e)
        {
            checkCheatedForm check = new checkCheatedForm();
            check.Show();
        }
    }
}
