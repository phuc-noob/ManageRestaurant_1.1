using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class checkInAndOutForm : Form
    {
        private Button buttonCheckIn;
        private Button buttonCheckOut;
        private DataGridView dataGridViewDiemDanh;
        private Label labelHello;
        private string username;

        public checkInAndOutForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.dataGridViewDiemDanh = new System.Windows.Forms.DataGridView();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(104, 347);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(107, 41);
            this.buttonCheckIn.TabIndex = 0;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(296, 347);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(111, 41);
            this.buttonCheckOut.TabIndex = 1;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // dataGridViewDiemDanh
            // 
            this.dataGridViewDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiemDanh.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewDiemDanh.Name = "dataGridViewDiemDanh";
            this.dataGridViewDiemDanh.RowHeadersWidth = 51;
            this.dataGridViewDiemDanh.RowTemplate.Height = 24;
            this.dataGridViewDiemDanh.Size = new System.Drawing.Size(486, 284);
            this.dataGridViewDiemDanh.TabIndex = 2;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(13, 13);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(40, 17);
            this.labelHello.TabIndex = 3;
            this.labelHello.Text = "Hello";
            // 
            // checkInAndOutForm
            // 
            this.ClientSize = new System.Drawing.Size(510, 400);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.dataGridViewDiemDanh);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonCheckIn);
            this.Name = "checkInAndOutForm";
            this.Text = "Check In/Out";
            this.Load += new System.EventHandler(this.checkInAndOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        DiemDanh diemDanh = new DiemDanh();
        Employee employee = new Employee();

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (username == null)
            {
                MessageBox.Show("Chua Login", "Check in/out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (MessageBox.Show("You want to check in?", "Check in", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int msnv = Convert.ToInt32(username);
                if (diemDanh.checkIn(msnv))
                {
                    MessageBox.Show("Da check in", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formLoad();
                }
                else
                {
                    MessageBox.Show("Error", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (username == null)
            {
                MessageBox.Show("Chua Login", "Check in/out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int msnv = Convert.ToInt32(username);
            if (diemDanh.kiemTraCheckIn(msnv))
            {
                if (MessageBox.Show("You want to check out?", "Check out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    if (diemDanh.checkOut(msnv))
                    {
                        MessageBox.Show("Da check out", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formLoad();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chua Check In", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkInAndOutForm_Load(object sender, EventArgs e)
        {
            if (username != null)
            {
                DataTable table = employee.getEmployeeByMsnv(Convert.ToInt32(username));
                labelHello.Text = "Hello " + table.Rows[0]["lname"].ToString();
                formLoad();
            }
            else
            {
                MessageBox.Show("Chua Login", "Check in/out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formLoad()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM diemdanh WHERE msnv = @msnv");
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = this.username;
            DataTable table = diemDanh.getChecInAOut(command);
            dataGridViewDiemDanh.ReadOnly = true;
            dataGridViewDiemDanh.DataSource = table;
            dataGridViewDiemDanh.AllowUserToAddRows = false;
        }

    }
}
