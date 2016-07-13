using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISystemApplicationUser
    {
        public string GetApplicationUser()
        {
            return (new SystemApplicationUserBusiness()).GetUserInfo();
        }
    }
}
