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
    public partial class itemEmployee : UserControl
    {
        public itemEmployee()
        {
            InitializeComponent();
        }

        private void guna2Button_Click(object sender, EventArgs e)
        {
            if(this.guna2Button.Text == "CheckIn / Out")
            {
                checkInAndOutForm_1 checkin = new checkInAndOutForm_1();
                checkin.Show();
            }
            else if(this.guna2Button.Text == "Change Password")
            {
                changePasswordForm_1 changePw = new changePasswordForm_1();
                changePw.Show();
            }else if(this.guna2Button.Text == "Manage Employee")
            {
                formManageEmployee_1 employee = new formManageEmployee_1();
                employee.Show();
            }
            else if (this.guna2Button.Text == "Manage Salary")
            {

                manageSalaryForm salary = new manageSalaryForm();
                salary.Show();
            }
            else if (this.guna2Button.Text == "Manage Shift")
            {
                manageShiftForm shift = new manageShiftForm();
                shift.Show();
            }
            else if (this.guna2Button.Text == "Login")
            {

                loginForm_1 login = new loginForm_1();
                login.Show();
            }
        }
    }
}
