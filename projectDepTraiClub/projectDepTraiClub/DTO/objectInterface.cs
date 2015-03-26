using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Project
{
    interface objectInterface
    {
         Boolean insert(List<String> str);
         Boolean update(int id, List<String> str);
         Boolean delete(int id);
         SqlDataReader select();
    }
}
