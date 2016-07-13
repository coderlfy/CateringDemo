using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentReferenceLogs 
    {
        public string AddOfficeDocumentReferenceLog(
            string logonUser, string logonUserIp, 
            Model.EntityOfficeDocumentReferenceLogs referenceLog)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentReferenceLogsBusiness(logonUser, logonUserIp)
                    .AddOfficeDocumentReferenceLog(referenceLog);
            });
            #endregion
        }

        public string DeleteOfficeDocumentReferenceLog(
            string logonUser, string logonUserIp, 
            string referenceId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentReferenceLogsBusiness(logonUser, logonUserIp)
                    .DeleteOfficeDocumentReferenceLog(referenceId);
            });
            #endregion
        }

        public string GetJsonReferenceFileLogs(
            string logonUser, string logonUserIp, 
            string fileId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentReferenceLogsBusiness(logonUser, logonUserIp)
                    .GetJsonReferenceFileLogs(fileId);
            });
            #endregion
        }


        public string GetStatusOfficeDocumentReferenceLog(
            string logonUser, string logonUserIp,
            Model.EntityOfficeDocumentReferenceLogs referenceLog)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentReferenceLogsBusiness(logonUser, logonUserIp)
                    .GetStatusOfficeDocumentReferenceLog(referenceLog);
            });
            #endregion
        }
    }
}
