using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace projectDepTraiClub
{
    interface objectInterface
    {
         Boolean insert();
         Boolean update();
         Boolean delete();
         SqlDataReader select();
    }
}
