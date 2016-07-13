using Foundation.Core;
using Catering.Service.WCFServiceV1;
using OfficalV1Authority.DBMapping;
using OfficalV1Authority.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISystemLogin
    {
        public string CheckUserLogin(
            string UserLoginName, string PassWord,
            ref string UserID, ref string UserKeyNO,
            ref string UserName, ref string UserDuty,
            ref string UserDempId)
        {
            #region
            return (new SystemUserLoginBusiness()).CheckUserLogin(
                UserLoginName, PassWord, 
                ref UserID, ref UserKeyNO, 
                ref UserName, ref UserDuty, 
                ref UserDempId);
            #endregion
        }
    }
}
