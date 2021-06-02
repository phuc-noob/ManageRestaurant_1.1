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
                
                int tb_id = tb.getIdByLabel(Global.tableNumber);
                int b_id = 0;
                int status = 1;
                int amount = int.Parse(this.guna2NumericUpDown_amount.Value.ToString());
                float total = 10;
                DateTime checkin = DateTime.Now;
                tb.updateBillTable(tb_id, b_id, total, amount, status, checkin);
            //} catch (Exception ex)
            //{
            //    MessageBox.Show("nothing");
            //}
        }
    }
}
