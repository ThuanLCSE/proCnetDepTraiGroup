﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    class Categori : objectInterface
    {
        SqlCommand cmd = new SqlCommand();
        public Categori()
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
           cmd.CommandText = "selectCategories";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            return dr;
        }

        #endregion
    }
}
