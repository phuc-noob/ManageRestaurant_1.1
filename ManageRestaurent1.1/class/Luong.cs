using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class Luong
    {
        myDB dB = new myDB();

        public bool insertSalary(int msnv, DateTime date, double salary, string state)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Luong (msnv, date, salary, tinhtrang)" +
                " VALUES (@msnv, @date, @salary, @state)", dB.GetConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@salary", SqlDbType.Money).Value = salary;
            command.Parameters.Add("@state", SqlDbType.VarChar).Value = state;
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

        public DataTable getAllLuong()
        {
            SqlCommand command = new SqlCommand("SELECT msnv, date, CAST(Salary AS DECIMAL) AS Salary, tinhtrang FROM Luong");
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getLuong(SqlCommand command)
        {
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateLuong(int msnv, string state)
        {
            SqlCommand command = new SqlCommand("UPDATE Luong SET tinhtrang = @state WHERE msnv = @msnv", dB.GetConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@state", SqlDbType.VarChar).Value = state;
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

        public bool deleteLuong(int msnv, DateTime date)
        {
            SqlCommand command = new SqlCommand("DELETE Luong WHERE date >= @date AND date < dateadd(day, 1, @date) AND msnv = @msnv", dB.GetConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date.Date;
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
    }
}
