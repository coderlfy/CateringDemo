using Foundation.Core;
using NormalDocumentOffice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentHistoryProcFile
    {
        public string GetJsonOfHistoryProcFiles(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize,
            EntityOfficeDocumentHistoryProcFile procFileKeys, EntityOfficeDocumentOKProcFile okprocFileKeys)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentHistoryProcFileBusiness(logonUser, logonUserIp)
                    .GetJsonHistoryOfOKFiles(pageIndex, pageSize, procFileKeys, okprocFileKeys);
            });
            #endregion
        }

        public string GetJsonProcFilesByHistoryDocID(
            string logonUser, string logonUserIp, string docId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentHistoryProcFileBusiness(logonUser, logonUserIp)
                    .GetJsonProcFilesByHistoryDocID(docId);
            });
            #endregion
        }


        public EntityOfficeDocumentHistoryProcFile GetOfficeDocumentHistoryProcFile(
            string procFileId)
        {
            #region
            return new OfficeDocumentHistoryProcFileBusiness("", "")
                    .GetOfficeDocumentHistoryProcFile(procFileId);
            #endregion
        }


        public EntityOfficeDocumentOKProcFile GetOfficeDocumentOKFile()
        {
            throw new NotImplementedException();
        }
    }
}
