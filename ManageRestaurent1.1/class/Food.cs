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
    class Food
    {
        public string tenMon { get; set; }
        public float cost { get; set; }

        My_DB db = new My_DB();
        public DataTable getTFood()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from typeFood", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }

        public bool insertTFoot(string label, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("INSERT INTO typeFood (label,picture)"
                + "VALUES (@label,@picture)", db.getConnection);

            command.Parameters.Add("@label", System.Data.SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = image.ToArray();

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
        public bool insertFood(int id,string label, float cost,string type, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("INSERT INTO food (id,label,type,cost,picture)"
                + "VALUES (@id,@label,@type,@cost,@picture)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", System.Data.SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@cost", System.Data.SqlDbType.Float).Value = cost;
            command.Parameters.Add("@type", System.Data.SqlDbType.VarChar).Value = type;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = image.ToArray();

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

        public DataTable getFood()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from food", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public DataTable getFoodByLabel(string label)
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from food where label =@label", db.getConnection);
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public bool deleteFoodByLabel(string label)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM food WHERE label =@label", db.getConnection);
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
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
        public bool updateFood(string label,float cost,string type,MemoryStream image)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("UPDATE food SET label =@label, type =@type,cost =@cost,picture =@picture where label =@label", db.getConnection);

            command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@cost", SqlDbType.Float).Value = cost;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = image.ToArray();
           
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
