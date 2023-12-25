using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance
{
    internal class database
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-GDHCIFF;initial catalog=ambulance;Integrated Security=True");
        public void openconection()
        {
            if (sqlconn.State == System.Data.ConnectionState.Closed)
            {
                sqlconn.Open();
            }
        }
        public void closeconection()
        {
            if (sqlconn.State == System.Data.ConnectionState.Open)
            {
                sqlconn.Close();
            }
        }
        public SqlConnection getconnection()
        {
            return sqlconn;
        }
    }
}
