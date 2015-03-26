using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class Shipper:DTOabs
    {
        public Shipper()
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

        public System.Data.SqlClient.SqlDataReader select()
        {

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectShipper";
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        #endregion
    }
}
