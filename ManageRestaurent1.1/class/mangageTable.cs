using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class manageTable
    {
        My_DB db = new My_DB();
        public DataTable getAllTable()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from infotable", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }


        public bool updateBillTable(int id, int b_id, float total, int amount, int status, DateTime checkin)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("UPDATE infotable SET id_bill=@bid, total =@total,amount =@amount,status =@status, checkin =@checkin where id =@id", db.getConnection);


            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@bid", SqlDbType.Int).Value = b_id;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@status", SqlDbType.Int).Value = status;
            command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;

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
        public int getIdByLabel(string label)
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id from infoTable where label =@label", db.getConnection);
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return int.Parse(dt.Rows[0]["id"].ToString());
            db.closeConnection();
        }
    }
}
