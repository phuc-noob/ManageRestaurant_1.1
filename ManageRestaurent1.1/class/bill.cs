using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class bill
    {
        My_DB db = new My_DB();
        public DataTable getb_bill()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from billmenu", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public DataTable getbillbynow()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select label, count(sl) as soLuong from billmenu where checkout =@time group by label", db.getConnection);
            cmd.Parameters.Add("@time", SqlDbType.Date).Value = DateTime.Now;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public DataTable getbillbymonth()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select label, count(sl) as soLuong from billmenu group by label", db.getConnection);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }

        public DataTable getBillByid(int id)
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from billmenu where b_id =@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public bool cookdone(int bid, int fid)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("UPDATE billmenu SET state =1 where b_id =@bid and f_id =@fid", db.getConnection);

            command.Parameters.Add("@bid", SqlDbType.VarChar).Value = bid;
            command.Parameters.Add("@fid", SqlDbType.Float).Value = fid;

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public DataTable getCooker()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from billmenu where state = 0", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public bool insertFoodToBill(int id, int f_id, float price, int sl, string label,int giamgia,int state)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Billmenu (b_id,f_id,price,sl,label,giamgia,state)"
                + "VALUES (@id,@fid,@price,@sl,@label,@giamgia,@state)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@state", SqlDbType.Int).Value = state;
            command.Parameters.Add("@sl", SqlDbType.Int).Value =sl;
            command.Parameters.Add("@fid", SqlDbType.Int).Value = f_id;
            command.Parameters.Add("@label", System.Data.SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@price", System.Data.SqlDbType.Int).Value = price;
            command.Parameters.Add("@giamgia", System.Data.SqlDbType.Int).Value = giamgia;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool checkoutBill(int bid)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("UPDATE billMenu SET checkout =@time where b_id =@id", db.getConnection);


            command.Parameters.Add("@id", SqlDbType.Int).Value = bid;
            
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = DateTime.Now;

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
