using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class PhanCa
    {
        myDB dB = new myDB();

        public DataTable getPhanCa(SqlCommand command)
        {
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllPhanCa()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Phanca", dB.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deletePhanCa(int msnv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Phanca WHERE msnv = @msnv", dB.GetConnection);
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

        public bool deleteAllPhanCa()
        {
            SqlCommand command = new SqlCommand("DELETE FROM Phanca", dB.GetConnection);
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

        public bool insertPhanCa(int msnv, int ca, int uutien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Phanca (msnv, maca, uutien) VALUES (@msnv, @maca, @uutien)", dB.GetConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@maca", SqlDbType.Int).Value = ca;
            command.Parameters.Add("@uutien", SqlDbType.Int).Value = uutien;

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

        public bool updatePhanCa(int msnv, string msnvlt, int maca)
        {
            SqlCommand command = new SqlCommand();
            if (msnvlt.Trim() == "")
            {
                command = new SqlCommand("UPDATE Phanca SET nvlamthay = null WHERE msnv = @msnv AND maca = @maca", dB.GetConnection);
            }
            else
            {
                command = new SqlCommand("UPDATE Phanca SET nvlamthay = @msnvlt WHERE msnv = @msnv AND maca = @maca", dB.GetConnection);
                command.Parameters.Add("@msnvlt", SqlDbType.Int).Value = Convert.ToInt32(msnvlt);
            }

            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@maca", SqlDbType.Int).Value = maca;

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
