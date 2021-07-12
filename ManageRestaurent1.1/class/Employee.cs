using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class Employee
    {
        myDB dB = new myDB();

        public DataTable getEmployees(SqlCommand command)
        {
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getEmployeeByMsnv(int msnv)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Nhanvien WHERE msnv = @msnv");
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getEmployeeByPhoneNo(string phone)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Nhanvien WHERE phone = @phone");
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Connection = dB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertEmployee(string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture, int macv)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Nhanvien (fname, lname, birthdate, gender, phone, address, picture, congviec)" +
                " VALUES (@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic, @macv)", dB.GetConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@macv", SqlDbType.Int).Value = macv;

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

        public bool checkNoOfManager()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Nhanvien, Congviec WHERE " +
                "congviec = macv AND noidungcv = 'Quan ly'", dB.GetConnection);

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count >= 2 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool updateEmployee(int msnv, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture, int macv)
        {
            SqlCommand command = new SqlCommand("UPDATE Nhanvien SET fname = @fn, lname = @ln, birthdate = @bdt, " +
                "gender = @gdr, phone = @phn, address = @adrs, picture = @pic, congviec = @macv WHERE msnv = @msnv", dB.GetConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@macv", SqlDbType.Int).Value = macv;

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

        public bool deleteEmployee(int msnv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Nhanvien WHERE msnv = @msnv");
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Connection = dB.GetConnection;
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

        public int getTotalEmployees()
        {
            SqlCommand command = new SqlCommand("SELECT Count(msnv) FROM Nhanvien", dB.GetConnection);
            dB.openConnection();
            int count = (int)command.ExecuteScalar();
            return count;
        }

        // ds nhan vien lam ca 1 2/ ca 1 3/ ca 2 3 theo thu tu uu tien giam dan
        public DataTable getEmployeeByPhancong(int caThuNhat, int caThuHai)
        {
            SqlCommand command = new SqlCommand("SELECT P.msnv FROM (SELECT msnv, uutien FROM Phanca WHERE maca = @c1 )" +
                                " as P, (SELECT msnv FROM Phanca WHERE maca = @c2) AS P2, Nhanvien as N WHERE P.msnv = P2.msnv AND P.msnv = N.msnv " +
                                "AND P.msnv in (SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien') ORDER BY P.uutien DESC");
            command.Parameters.Add("@c1", SqlDbType.Int).Value = caThuNhat;
            command.Parameters.Add("@c2", SqlDbType.Int).Value = caThuHai;
            DataTable table = this.getEmployees(command);
            return table;
        }

        public int getTotalNV()
        {
            SqlCommand command = new SqlCommand("SELECT Count(msnv) FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien'", dB.GetConnection);
            dB.openConnection();
            int count = (int)command.ExecuteScalar();
            return count;
        }

        public bool checkMsnvlt(int msnv, int msnvlt, int maca)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Nhanvien WHERE msnv = @msnvlt AND msnv NOT IN (SELECT msnv FROM Phanca WHERE maca = @maca) " +
                " AND congviec = (SELECT congviec FROM Nhanvien WHERE msnv = @msnv)", dB.GetConnection);
            command.Parameters.Add("@msnvlt", SqlDbType.Int).Value = msnvlt;
            command.Parameters.Add("@maca", SqlDbType.Int).Value = maca;
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
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
