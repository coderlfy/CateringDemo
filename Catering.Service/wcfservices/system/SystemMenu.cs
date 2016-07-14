using Foundation.Core;
using Catering.Service.WCFServiceV1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISystemMenu
    {
        public string GetSystemMenu(
            string logonUserId, string logonUserIp,
            string userName, string fullName)
        {
            return (new SystemUserMenuBusiness(logonUserId, logonUserIp).GetUserMenu(userName, fullName));
        }
    }
}
