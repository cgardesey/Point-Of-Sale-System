using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using settings = Point_Of_Sale_System.Properties.Settings;

namespace Point_Of_Sale_System
{
    public sealed class GlobalFunction
    {
        public static string cartNo;
        public static DataTable dt = new DataTable();

        //GET DATA FROM TABLE
    public static System.Data.DataTable getUnitPrice(string sql)
    {
     using (var myAdapter = new SqlDataAdapter(sql, settings.Default.POSConnectionString))
     {
         using (dt = new System.Data.DataTable())
         {
             myAdapter.Fill(dt);
            
         }
     }
     return dt;
    }

    }
   
}
