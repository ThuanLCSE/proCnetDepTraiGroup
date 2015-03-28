﻿using System;
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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertProduct";
            cmd.Parameters.Clear();

            SqlParameter  param = new SqlParameter("@productname", SqlDbType.VarChar, 40);
            param.Value = str[0];
            cmd.Parameters.Add(param);
            param = new SqlParameter("@supplierid", SqlDbType.Int);
            param.Value = Int32.Parse(str[1]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@categoryid", SqlDbType.Int);
            param.Value = Int32.Parse(str[2]);
            cmd.Parameters.Add(param);
                param = new SqlParameter("@unitprice", SqlDbType.Money);
            param.Value = decimal.Parse( str[3]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@discontinued", SqlDbType.Bit);
            param.Value = Int32.Parse( str[4]);
                cmd.Parameters.Add(param);



            //
            cmd.ExecuteNonQuery();
            closeConnection();
            return true;
        }


        public bool update(int id, List<string> str)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateProduct";
            cmd.Parameters.Clear();

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = id;
            cmd.Parameters.Add(param);
            param = new SqlParameter("@productname", SqlDbType.VarChar, 40);
            param.Value = str[0];
            cmd.Parameters.Add(param);
            param = new SqlParameter("@supplierid", SqlDbType.Int);
            param.Value = Int32.Parse(str[1]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@categoryid", SqlDbType.Int);
            param.Value = Int32.Parse(str[2]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@unitprice", SqlDbType.Money);
            param.Value = decimal.Parse(str[3]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@discontinued", SqlDbType.Bit);
            param.Value = Int32.Parse(str[4]);
            //
            cmd.ExecuteNonQuery();
            closeConnection();
            return true;
        }

        public bool delete(int id)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteProduct";
            cmd.Parameters.Clear();

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = id;
            cmd.Parameters.Add(param);
            //
            cmd.ExecuteNonQuery();
            closeConnection();
            return true;
        }

        public SqlDataReader select()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectProduct";
            SqlDataReader dr = cmd.ExecuteReader();
            closeConnection();
            return dr;
        }
        public SqlDataReader search(int id, List<string> str)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "searchOrderProduct";
            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = id;
            cmd.Parameters.Add(param);
            param = new SqlParameter("@productname", SqlDbType.VarChar, 40);
            param.Value = str[0];
            cmd.Parameters.Add(param);
            param = new SqlParameter("@supplierid", SqlDbType.Int);
            param.Value = Int32.Parse(str[1]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@categoryid", SqlDbType.Int);
            param.Value = Int32.Parse(str[2]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@unitprice", SqlDbType.Money);
            param.Value = decimal.Parse(str[3]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@discontinued", SqlDbType.Bit);
            param.Value = Int32.Parse(str[4]);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        #endregion
    }
}
