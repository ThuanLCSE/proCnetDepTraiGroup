﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace projectDepTraiClub
{
    class orderDetail: objectInterface
    {
        SqlCommand cmd = new SqlCommand();
        public orderDetail()
        {
            cmd.Connection=(new dataAccessObjest()).getCon();
        }


        #region objectInterface Members

        public bool insert()
        {
            throw new NotImplementedException();
        }

        public bool update()
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader select()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}