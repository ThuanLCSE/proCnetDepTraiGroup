using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class products:DTOabs
    {
        public products():base()
        {
        }
        #region objectInterface Members

        public bool insert(List<string> str)
        {
            throw new NotImplementedException();
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
            cmd.CommandText = "selectProduct";
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        #endregion
    }
}
