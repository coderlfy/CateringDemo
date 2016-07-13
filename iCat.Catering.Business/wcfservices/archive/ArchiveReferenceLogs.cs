using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveReferenceLogs
    {
        public string AddArchiveReferenceLogForDocument(
            string logonUser, string logonUserIp, 
            Archive.Model.EntityArchiveReferenceLogs referenceLog)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveReferenceLogsBusiness(logonUser, logonUserIp)
                    .AddArchiveReferenceLogForDocument(referenceLog);
            });
            #endregion
        }

        public string DeleteArchiveReferenceLog(
            string logonUser, string logonUserIp, 
            string referenceId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveReferenceLogsBusiness(logonUser, logonUserIp)
                    .DeleteArchiveReferenceLog(referenceId);
            });
            #endregion
        }


        public string GetStatusArchiveReferenceLog(
            string logonUser, string logonUserIp, 
            Archive.Model.EntityArchiveReferenceLogs referenceLog)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveReferenceLogsBusiness(logonUser, logonUserIp)
                    .GetStatusArchiveReferenceLog(referenceLog);
            });
            #endregion
        }
    }
}
