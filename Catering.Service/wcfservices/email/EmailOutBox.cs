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
    partial class WCFService : IEmailOutBox
    {




        public string DeleteOutBox(string OutBoxId, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailOutBoxBusiness(logonUser, logonUserIp).DeleteOutBox(OutBoxId);
            });
        }

        public string GetJsonOutBoxByPage(EntityEmailOutBox model, int pageIndex, int pageSize, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailOutBoxBusiness(logonUser, logonUserIp).GetJsonOutBoxByPage(model, pageIndex, pageSize);
            });
        }




        public string EditOutBox(EntityEmailOutBox model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailOutBoxBusiness(logonUser, logonUserIp).EditOutBox(model);
            });
        }
    }
}
