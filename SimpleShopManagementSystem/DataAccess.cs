using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SimpleShopManagementSystem
{
    class DataAccess
    {
        public SqlConnection con;

        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=AALAKIB07-PC;Initial Catalog=simpleshopmanagement;Persist Security Info=True;User ID=sa;Password=123456789");
        }
    }
}
