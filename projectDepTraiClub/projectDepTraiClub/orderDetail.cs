﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class orderDetail: DTOabs
    {
        public orderDetail():base()
        {
        }

        #region objectInterface Members

        public bool insert(List<string> str)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertOrderDetail";
            cmd.Parameters.Clear();
            //
            SqlParameter param = new SqlParameter("@productid", SqlDbType.Int);
            param.Value = Int32.Parse(str[0]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@unitprice", SqlDbType.Money);
            param.Value = decimal.Parse( str[1]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@qty", SqlDbType.SmallInt);
            param.Value = Int16.Parse( str[2]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@discount", SqlDbType.Decimal);
            param.Value = decimal.Parse( str[3]);
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            closeConnection();
            return true;
        }

        public bool update(int id, List<string> str)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateOrderDetail";
            cmd.Parameters.Clear();

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = id;
            cmd.Parameters.Add(param);
            param = new SqlParameter("@productid", SqlDbType.Int);
            param.Value = Int32.Parse(str[0]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@unitprice", SqlDbType.Money);
            param.Value = decimal.Parse(str[1]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@qty", SqlDbType.SmallInt);
            param.Value = Int16.Parse(str[2]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@discount", SqlDbType.Decimal);
            param.Value = decimal.Parse(str[3]);
            //
            cmd.ExecuteNonQuery();
            closeConnection();
            return true;
        }

        public bool delete(int id)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteOrderDetail";
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
             cmd.CommandText = "selectOrderDetail";
            SqlDataReader dr = cmd.ExecuteReader();
            closeConnection();
            return dr;
        }
        public SqlDataReader search(int id, List<string> str)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "searchOrderDetail";
            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = id;
            cmd.Parameters.Add(param);
            param = new SqlParameter("@productid", SqlDbType.Int);
            param.Value = Int32.Parse(str[0]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@unitprice", SqlDbType.Money);
            param.Value = decimal.Parse(str[1]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@qty", SqlDbType.SmallInt);
            param.Value = Int16.Parse(str[2]);
            cmd.Parameters.Add(param);
            param = new SqlParameter("@discount", SqlDbType.Decimal);
            param.Value = decimal.Parse(str[3]);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        #endregion
    }

}
