using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class employee:DTOabs
    {
        
        public employee():base()
        {
            
        }
        #region objectInterface Members
        
        public bool insert(List<string> str)
        {

            return false;
        }

        public bool update(int id, List<string> str)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader select()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectEmployee";
            SqlDataReader dr = cmd.ExecuteReader();
          
            return dr;
        }

        #endregion
    }
}
