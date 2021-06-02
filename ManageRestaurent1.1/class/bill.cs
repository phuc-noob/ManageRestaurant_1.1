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
        public DataTable getb_Table()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from billtable", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
    }
}
