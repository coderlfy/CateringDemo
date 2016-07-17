using iCat.Catering.Dao;
using iCat.Catering.IDao;
using iCat.Catering.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCat.Catering.Service
{
    class DBManagerService : IDBManagerService
    {
        public IDBManagerDao _DBManagerDao { get; set; }
        public DateTime GetDBCurrentTime()
        {
            return _DBManagerDao.SelectGetDate();
        }
    }
}
