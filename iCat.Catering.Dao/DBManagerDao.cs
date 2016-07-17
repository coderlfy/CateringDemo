using CustomSpring.Core;
using iCat.Catering.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCat.Catering.Dao
{
    class DBManagerDao : BaseDao, IDBManagerDao
    {
        public DateTime SelectGetDate()
        {
            return Convert.ToDateTime(this.AdoTemplate.ExecuteScalar(System.Data.CommandType.Text, "select getdate()"));
        }
    }
}
