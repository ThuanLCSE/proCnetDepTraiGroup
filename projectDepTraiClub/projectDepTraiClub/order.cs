﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class order:objectInterface
    {
        SqlCommand cmd = new SqlCommand();
        public order()
        {
            cmd.Connection= (new dataAccessObjest).getCon();
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
            cmd.CommandText = "selectOrder";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            return dr;
        }

        #endregion
    }
}
