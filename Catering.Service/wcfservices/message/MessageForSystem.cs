using Foundation.Core;
using LHMessage.Model;
using System;
using System.Collections.Generic;
using Catering.Service.threads;
using System.Linq;
using System.Text;
using CustomSpring.Core;

namespace Catering.Service
{
    partial class WCFService : IMessageForSystem
    {
        public string GetJsonOfSystemMessages(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize,
            EntityMessageForSystem message)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new MessageForSystemBusiness(logonUser, logonUserIp)
                    .GetJsonOfSystemMessages(pageIndex, pageSize, message);
            });
            #endregion
        }
        public string DeleteJsonOfSystemMessageByMessageId(
            string logonUser, string logonUserIp, 
            EntityMessageForSystem message)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new MessageForSystemBusiness(logonUser, logonUserIp)
                    .DeleteJsonOfSystemMessageByMessageId(message);
            });
            #endregion
        }
        public string DeleteJsonOfSystemMessageByTimeSpan(
            string logonUser, string logonUserIp, 
            EntityMessageForSystem message)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new MessageForSystemBusiness(logonUser, logonUserIp)
                    .DeleteJsonOfSystemMessageByTimeSpan(message);
            });
            #endregion
        }
        public string SetIsTopByMessageId(
            string logonUser, string logonUserIp, 
            EntityMessageForSystem message)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new MessageForSystemBusiness(logonUser, logonUserIp)
                     .SetIsTopByMessageId(message);
            });
            #endregion
        }
        public string CancelIsTopByMessageId(
            string logonUser, string logonUserIp, 
            EntityMessageForSystem message)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new MessageForSystemBusiness(logonUser, logonUserIp)
                     .CancelIsTopByMessageId(message);
            });
            #endregion
        }
        public string EnsureIsReadByMessageId(
            string logonUser, string logonUserIp, 
            EntityMessageForSystem message)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new MessageForSystemBusiness(logonUser, logonUserIp)
                    .EnsureIsReadByMessageId(message);
            });
            #endregion
        }
        public string GetJsonOfSystemMessagesByConditions(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize, 
            EntityMessageForSystem message)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new MessageForSystemBusiness(logonUser, logonUserIp)
                    .GetJsonOfSystemMessagesByConditions(pageIndex, pageSize, message);
            });
            #endregion
        }

    }
}
