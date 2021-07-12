using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class Account
    {
        myDB dB = new myDB();

        public bool insertAccount(int username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Account (username, password) VALUES (@username, @password)");
            command.Connection = dB.GetConnection;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
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

        public bool updateAccount(int username, string password)
        {
            SqlCommand command = new SqlCommand("UPDATE Account SET password = @password WHERE username = @username");
            command.Connection = dB.GetConnection;
            command.Parameters.Add("@username", SqlDbType.Int).Value = username;
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

        public bool deleteAccount(int msnv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Account WHERE username = @msnv");
            command.Connection = dB.GetConnection;
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
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

        public bool CheckAccountExist(int username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Account WHERE username = @username", dB.GetConnection);
            command.Parameters.Add("@username", SqlDbType.Int).Value = username;
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

        public bool checkPassword(int username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Account WHERE username = @uname AND password = @pwd", dB.GetConnection);
            command.Parameters.Add("@uname", SqlDbType.Int).Value = username;
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
