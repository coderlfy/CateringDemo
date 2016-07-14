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
    partial class WCFService : IEmailAttachment
    {
        public string DeleteAttachment(string[] attachmentId, bool reSend, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailAttachmentBusiness(logonUser, logonUserIp).DeleteAttachment(attachmentId, reSend);
            });
        }

        public string AddNewAttachments(EntityEmailAttachment[] models, bool reSend, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailAttachmentBusiness(logonUser, logonUserIp).AddNewAttachments(models, reSend);
            });
        }

        public EntityEmailAttachment DownAttachment(string attachmentId, string logonUser, string logonUserIp)
        {
            return new EmailAttachmentBusiness(logonUser, logonUserIp).DownAttachment(attachmentId);
        }
        public string GetJsonAttachmentByPage(EntityEmailAttachment model, int pageIndex, int pageSize, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new EmailAttachmentBusiness(logonUser, logonUserIp).GetJsonAttachmentByPage(model, pageIndex, pageSize);
            });
        }
    }
}
