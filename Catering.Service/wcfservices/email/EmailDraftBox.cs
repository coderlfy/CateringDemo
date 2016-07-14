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
    partial class WCFService : IEmailDraftBox
    {
        public string AddNewDraftBox(EntityEmailDraftBox model, EntityEmailInfo info, bool copyAttach, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailDraftBoxBusiness(logonUser, logonUserIp).AddNewDraftBox(model, info, copyAttach);
            });
        }

        public string EditDraftBox(EntityEmailDraftBox model, EntityEmailInfo info, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailDraftBoxBusiness(logonUser, logonUserIp).EditDraftBox(model, info);
            });
        }

        public string DeleteDraftBox(string draftBoxId, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailDraftBoxBusiness(logonUser, logonUserIp).DeleteDraftBox(draftBoxId);
            });
        }

        public string GetJsonDraftBoxByPage(EntityEmailDraftBox model, int pageIndex, int pageSize, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailDraftBoxBusiness(logonUser, logonUserIp).GetJsonDraftBoxByPage(model, pageIndex, pageSize);
            });
        }


        public string SendDraftBox(string draftBoxId, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailDraftBoxBusiness(logonUser, logonUserIp).SendDraftBox(draftBoxId);
            });
        }
        public string SendEmailInfo(EntityEmailInfo model, string acceptUserIds, bool copyAttach, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailDraftBoxBusiness(logonUser, logonUserIp).SendEmailInfo(model, acceptUserIds, copyAttach);
            });
        }
        public string sendEditDraftBoxEmail(EntityEmailDraftBox model, EntityEmailInfo info, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailDraftBoxBusiness(logonUser, logonUserIp).sendEditDraftBoxEmail(model, info);
            });
        }
    }
}
