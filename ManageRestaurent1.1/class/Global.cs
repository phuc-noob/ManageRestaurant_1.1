using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRestaurent1._1
{
    class Global
    {
        public static bool isMangage { get; set; }
        public static bool stateTable { get; set; }
        public static int location_YmenuItem{get;set;}
        public static string tableNumber { get; set; }
        public static DataTable billFood { get; set; }
        public static int bill_id { get; set; }
        public static int table_id { get; set; }
        public static int total { get; set; }
        public static int GlobalUserId { get; private set; }

        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}
