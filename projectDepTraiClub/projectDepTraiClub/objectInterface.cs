using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace projectDepTraiClub
{
    interface objectInterface
    {
        public Boolean insert();
        public Boolean update();
        public Boolean delete();
        public SqlDataReader select();
    }
}
