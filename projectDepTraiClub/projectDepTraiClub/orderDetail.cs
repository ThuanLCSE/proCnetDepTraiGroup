using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class orderDetail: objectInterface
    {
        SqlCommand cmd = new SqlCommand();
        public orderDetail()
        {
            cmd.Connection= (new dataAccessObjest).getCon();
        }

        #region objectInterface Members

        bool objectInterface.insert(List<string> str)
        {
            throw new NotImplementedException();
        }

        bool objectInterface.update(int id, List<string> str)
        {
            throw new NotImplementedException();
        }

        bool objectInterface.delete(int id)
        {
            throw new NotImplementedException();
        }

        SqlDataReader objectInterface.select()
        {
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.CommandText = "selectOrderDetail";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            return dr;
        }

        #endregion
    }

}
