using AddressBook.Model;
using Foundation.Core;
using Catering.Service.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IAddrBookPersonalInfo
    {

        public string OpertPersonalInfo(EntityAddrBookPersonalInfo model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookPersonalInfoBusiness(logonUser, logonUserIp).OpertPersonalInfo(model);
            });
        }

        public string GetJsonPersonalInfo(EntityAddrBookPersonalInfo model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookPersonalInfoBusiness(logonUser, logonUserIp).GetJsonPersonalInfo(model);
            });
        }
    }
}
