using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PBOTenantMoney
{
    class koneksi
    {
        public SqlConnection getconn()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = "Data Source=LAPTOP-PI7J2QHN;Initial Catalog=PBOTenantMoney;Integrated Security=True";
            return sqlconn;
        }
    }
}
