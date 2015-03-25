using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Project
{
    class orderDetail: objectInterface
    {
        SqlCommand cmd = new SqlCommand();
        public orderDetail()
        {
            cmd.Connection = (new dataAccessObjest()).getCon();
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
            throw new NotImplementedException();
        }

        #endregion
    }

}
