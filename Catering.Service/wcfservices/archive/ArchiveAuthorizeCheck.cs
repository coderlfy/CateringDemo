using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveAuthorizeCheck
    {
        public string AddArchiveAuthorizeCheck(
            string logonUser, string logonUserIp,
            List<Archive.Model.EntityArchiveAuthorizeApplyFor> applyFors,
            bool isPassed, string checkMemo)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeCheckBusiness(logonUser, logonUserIp)
                    .AddArchiveAuthorizeCheck(applyFors, isPassed, checkMemo);
            });
            #endregion
        }


        public string GetJsonAuthorizeApplyForByLeader(
            string logonUser, string logonUserIp,
            EntityArchiveAuthorizeApplyFor applyFor,
            EntityArchiveRealFile realFile,
            int pageIndex, int pageSize)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeCheckBusiness(logonUser, logonUserIp)
                    .GetJsonAuthorizeApplyForByLeader(applyFor, realFile, pageIndex, pageSize);
            });
            #endregion
        }


        public string GetJsonAuthorizeHasCheckForNormal(
            string logonUser, string logonUserIp,
            EntityArchiveAuthorizeCheck check,
            EntityArchiveAuthorizeApplyFor applyFor,
            EntityArchiveRealFile realFile, 
            int pageIndex, int pageSize)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeCheckBusiness(logonUser, logonUserIp)
                    .GetJsonAuthorizeHasCheckForNormal(check, applyFor, realFile, pageIndex, pageSize);
            });
            #endregion
        }
    }
}
