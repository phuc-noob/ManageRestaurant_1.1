using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class DiemDanh
    {
        myDB dB = new myDB();

        public DataTable getChecInAOut(SqlCommand command)
        {
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool checkIn(int msnv)
        {
            TimeSpan t = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            SqlCommand command = new SqlCommand("INSERT INTO diemdanh (msnv, checkin) VALUES (@msnv, @cin)", dB.GetConnection);

            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@cin", SqlDbType.Time).Value = t;
            
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

        public bool kiemTraCheckIn(int msnv)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM diemdanh WHERE stt = (SELECT MAX(stt) FROM diemdanh WHERE msnv = @msnv) AND checkout IS NULL", dB.GetConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
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

        public bool checkOut(int msnv)
        {
            TimeSpan t = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            SqlCommand command = new SqlCommand("UPDATE diemdanh SET checkout = @cout WHERE msnv = @msnv " +
                "AND stt = (SELECT MAX(stt) FROM diemdanh WHERE msnv = @msnv)", dB.GetConnection);

            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@cout", SqlDbType.Time).Value = t;

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

        public DataTable getDiemDanh(SqlCommand command)
        {
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteAllDiemDanh()
        {
            SqlCommand command = new SqlCommand("DELETE FROM Diemdanh", dB.GetConnection);

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
