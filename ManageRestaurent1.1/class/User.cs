using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class User
    {
        myDB dB = new myDB(); 

        public bool updateAccount(string password)
        {
            SqlCommand command = new SqlCommand("UPDATE hr SET password = @password");
            command.Connection = dB.GetConnection;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dB.closeConnection();
                return true;
            }
            else
            {
                dB.closeConnection();
                return false;
            }
        }

        public bool checkPassword(string password)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE password = @pwd", dB.GetConnection);
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = password;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
