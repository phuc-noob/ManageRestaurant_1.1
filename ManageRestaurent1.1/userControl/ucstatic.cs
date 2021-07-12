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
    public partial class @ucstatic : UserControl
    {
        public @ucstatic()
        {
            InitializeComponent();
        }

        private void static_Load(object sender, EventArgs e)
        {
            bill b = new bill();
            Food f = new Food();
            DataTable dt = b.getbillbynow();
            chart_day.Titles.Add("Static Per Day");
            int moneyDay = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                moneyDay += int.Parse(dt.Rows[i]["soluong"].ToString()) * int.Parse(f.getFoodByLabel(dt.Rows[i]["label"].ToString()).Rows[0]["cost"].ToString());
                chart_day.Series["money"].Points.AddXY(dt.Rows[i]["label"].ToString(), int.Parse(dt.Rows[i]["soluong"].ToString()) * int.Parse(f.getFoodByLabel(dt.Rows[i]["label"].ToString()).Rows[0]["cost"].ToString()));
                
            }
            this.label_money.Text = moneyDay.ToString();
        }

        private void guna2Button_month_Click(object sender, EventArgs e)
        {
            mainForm.panelMain.Controls.Clear();
            mainForm.panelMain.BackColor = Color.White;
            bill b = new bill();
            staticMonth sta = new staticMonth();
            sta.Top = 85;
            sta.Left = 150;
            mainForm.panelMain.Controls.Add(sta);
        }

        private void guna2Button_day_Click(object sender, EventArgs e)
        {
            bill b = new bill();
            Food f = new Food();
            DataTable dt = b.getbillbynow();
            chart_day.Titles.Add("Static Per Day");
            int moneyDay = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                moneyDay += int.Parse(dt.Rows[i]["soluong"].ToString()) * int.Parse(f.getFoodByLabel(dt.Rows[i]["label"].ToString()).Rows[0]["cost"].ToString());
                chart_day.Series["money"].Points.AddXY(dt.Rows[i]["label"].ToString(), int.Parse(dt.Rows[i]["soluong"].ToString()) * int.Parse(f.getFoodByLabel(dt.Rows[i]["label"].ToString()).Rows[0]["cost"].ToString()));

            }
            this.label_money.Text = moneyDay.ToString();
        }
    }
}
