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
    public partial class TableList : Form
    {
        public TableList()
        {
            InitializeComponent();
        }
        manageTable mtb = new manageTable();
        manageTable tb = new manageTable();
        bill b = new bill();
        int locationx = 20;
        int locationy = 20;
        private void TableList_Load(object sender, EventArgs e)
        {
            DataTable tb = mtb.getAllTable();
            for(int i =0;i <tb.Rows.Count; i++)
            {
                tableState newtb = new tableState();
                newtb.guna2Button_label.Text = tb.Rows[i]["label"].ToString();
                newtb.Top = locationy;
                newtb.Left = locationx;
                if (tb.Rows[i]["status"].ToString() == "1")
                {
                    newtb.guna2Button_label.Checked = true;
                }
                this.Controls.Add(newtb);
                if (locationx >= 800)
                {
                    locationy += 130;
                    locationx = 20;
                }
                else
                {
                    locationx += 210;
                }
            }
        }

        private void guna2Button_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button_save_Click(object sender, EventArgs e)
        {
            try {  
                int tb_id = tb.getIdByLabel(Global.tableNumber);
                int b_id = Global.bill_id;
                int status = 1;
                int amount = int.Parse(this.guna2NumericUpDown_amount.Value.ToString());
                float total = 10;
                DateTime checkin = DateTime.Now;

                for(int index=0;index <Global.billFood.Rows.Count; index++)
                {
                    int id =int.Parse(Global.billFood.Rows[index]["id"].ToString());
                    int fid =int.Parse(Global.billFood.Rows[index]["f_id"].ToString());
                    int price =int.Parse(Global.billFood.Rows[index]["price"].ToString());
                    string label =Global.billFood.Rows[index]["label"].ToString();
                    int sl =int.Parse(Global.billFood.Rows[index]["sl"].ToString());
                    int giamgia =int.Parse(Global.billFood.Rows[index]["giamgia"].ToString());
                    b.insertFoodToBill(id,fid,price,sl,label,giamgia,0);
                }
                tb.updateBillTable(tb_id, b_id, Global.total, amount, status, checkin);
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choice Table To Change","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
