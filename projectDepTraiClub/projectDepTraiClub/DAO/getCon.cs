using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Project.DAO
{
    class getCon
    {
        public SqlConnection ConDB()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                //@"server=.\sqlexpress;database=EmployeeDB;integrated security=true";
                @"server=localhost;database=EmployeeDB;integrated security=true";
            con.Open();

            return con;
        }
    }
}
