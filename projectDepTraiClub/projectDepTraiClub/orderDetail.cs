using System;
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

bool  objectInterface.insert()
{
 	throw new NotImplementedException();
}

bool  objectInterface.update()
{
 	throw new NotImplementedException();
}

bool  objectInterface.delete()
{
 	throw new NotImplementedException();
}

System.Data.SqlClient.SqlDataReader  objectInterface.select()
{
 	throw new NotImplementedException();
}

#endregion
    }

}
