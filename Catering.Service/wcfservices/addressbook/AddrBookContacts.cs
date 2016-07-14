using AddressBook.Model;
using Foundation.Core;
using Catering.Service.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IAddrBookContacts
    {

        public string AddNewContacts(EntityAddrBookContacts model, EntityAddrBookPersonalInfo info, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookContactsBusiness(logonUser, logonUserIp).AddNewContacts(model, info);
            });
        }

        public string EditContacts(EntityAddrBookContacts model, EntityAddrBookPersonalInfo info, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookContactsBusiness(logonUser, logonUserIp).EditContacts(model, info);
            });
        }

        public string DeleteContacts(string contactsId, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookContactsBusiness(logonUser, logonUserIp).DeleteContacts(contactsId);
            });
        }

        public string GetJsonContactsByDept(EntityAddrBookContacts model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookContactsBusiness(logonUser, logonUserIp).GetJsonContactsByDept(model);
            });
        }

        public string GetJsonContactsByPage(EntityAddrBookContacts model, int pageIndex, int pageSize, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookContactsBusiness(logonUser, logonUserIp).GetJsonContactsByPage(model, pageIndex, pageSize);
            });
        }


        public string GetJsonUintUsers(EntityAddrBookContacts model, EntityAddrBookPersonalInfo personInfo, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookContactsBusiness(logonUser, logonUserIp).GetJsonUintUsers(model, personInfo);
            });
        }


        public string AddUintUsers(string userIds, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new AddrBookContactsBusiness(logonUser, logonUserIp).AddUintUsers(userIds);
            });
        }
    }
}
