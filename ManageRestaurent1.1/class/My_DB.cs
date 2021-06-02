using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class My_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RtR;Integrated Security=True");

        // get connecction
        public SqlConnection getConnection
        {
            get { return con; }
        }

        // open connection
        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        // close connection
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
