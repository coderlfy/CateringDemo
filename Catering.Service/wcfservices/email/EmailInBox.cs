using AddressBook.Model;
using Foundation.Core;
using Mail.Model;
using Catering.Service.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IEmailInBox
    {
        public string DeleteInBox(string InBoxId, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailInBoxBusiness(logonUser, logonUserIp).DeleteInBox(InBoxId);
            });
        }
        public string GetJsonInBoxByPage(EntityEmailInBox model, int pageIndex, int pageSize, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailInBoxBusiness(logonUser, logonUserIp).GetJsonInBoxByPage(model, pageIndex, pageSize);
            });
        }
        public string EditInBox(EntityEmailInBox model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailInBoxBusiness(logonUser, logonUserIp).EditInBox(model);
            });
        }
    }
}
