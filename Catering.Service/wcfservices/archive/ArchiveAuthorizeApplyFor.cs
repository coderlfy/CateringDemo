using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveAuthorizeApplyFor
    {


        public string CancelAuthorizeApplyFor(
            string logonUser, string logonUserIp,
            string archiveId, string[] toUser)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeApplyForBusiness(logonUser, logonUserIp)
                    .CancelAuthorizeApplyFor(archiveId, toUser);
            });
            #endregion
        }

        public string GetJsonAuthorizeApplyForsByMe(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize,
            EntityArchiveAuthorizeApplyFor applyfor,
            EntityArchiveRealFile realfile)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeApplyForBusiness(logonUser, logonUserIp)
                    .GetJsonAuthorizeApplyForsByMe(pageIndex, pageSize, applyfor, realfile);
            });
            #endregion
        }

        public string AddAuthorizeApplyFor(
            string logonUser, string logonUserIp,
            string archiveId, string[] toUser,
            bool isWrite, string memo)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeApplyForBusiness(logonUser, logonUserIp)
                    .AddAuthorizeApplyFor(archiveId, toUser, isWrite, memo);
            });
            #endregion
        }
    }
}
