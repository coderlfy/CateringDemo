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
    partial class WCFService : IEmailPonderance
    {
        public string GetJsonAllData(EntityEmailPonderance model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailPonderanceBusiness(logonUser, logonUserIp).GetJsonAllData(model);
            });
        }
    }
}
