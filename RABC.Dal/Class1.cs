using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace RABC.Dal
{
    public class Class1
    {
        public void Test()
        {
            using (RABCDbContext dbContext = new Dal.RABCDbContext())
            {

            }
            using (SqlConnection con=new SqlConnection ())
            {
                //con.Query<>
            }
        }
    }
}
