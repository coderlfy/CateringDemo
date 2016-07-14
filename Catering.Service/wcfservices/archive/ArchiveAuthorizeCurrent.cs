using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveAuthorizeCurrent
    {

        public string CancelAuthorizeCurrent(
            string logonUser, string logonUserIp,
            List<Archive.Model.EntityArchiveAuthorizeCurrent> authorizeCurrents,
            string memo)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeCurrentBusiness(logonUser, logonUserIp)
                    .CancelAuthorizeCurrent(authorizeCurrents, memo);
            });
            #endregion
        }

        public string GetJsonAuthorizeCurrent(
            string logonUser, string logonUserIp, 
            EntityArchiveAuthorizeApplyFor applyfor,
            EntityArchiveRealFile realFile,
            EntityArchiveAuthorizeCheck check,
            EntityArchiveAuthorizeCurrent current,
            int pageIndex, int pageSize)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeCurrentBusiness(logonUser, logonUserIp)
                    .GetJsonAuthorizeCurrent(applyfor, realFile, check, current, pageIndex, pageSize);
            });
            #endregion
        }
    }
}
