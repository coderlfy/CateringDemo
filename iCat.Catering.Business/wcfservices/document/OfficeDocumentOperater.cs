using CustomSpring.Core;
using Foundation.Core;
using LuceneNetHelper.Conditions;
using LuceneNetHelper.Search;
using NormalDocumentOffice.DBMapping;
using NormalDocumentOffice.Model;
using Catering.Service.business;
using Catering.Service.Index;
using Catering.Service.threads;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentOperater
    {
        public string AddNewDocument(
            EntityOfficeDocumentRealProcFile officeDocumentRealProcFile,
            string logonUserId,
            string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentRealProcFileOperateBusiness(
                    logonUserId, logonUserIp)
                    .AddNewDocument(officeDocumentRealProcFile);
            });
            #endregion

        }

        public EntityOfficeDocumentRealProcFile GetOfficeDocumentProcFile(
    string procFileId)
        {
            #region
            return new OfficeDocumentRealProcFileOperateBusiness("", "")
                    .GetOfficeDocumentProcFile(procFileId);
            #endregion
        }

        public string EditDocumentRealProcFile(
    EntityOfficeDocumentRealProcFile officeDocumentRealProcFile, string logonUserId,
            string logonUserIp)
        {
            #region
            return new OfficeDocumentRealProcFileOperateBusiness(logonUserId, logonUserIp)
                    .EditDocumentRealProcFile(officeDocumentRealProcFile);
            #endregion
        }

        public string CopyDocumentRealProcFile(
            string procFileId,
            string logonUserId,
            string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentRealProcFileOperateBusiness(
                    logonUserId, logonUserIp)
                    .CopyDocumentRealProcFile(procFileId);
            });
            #endregion
        }

        public string GetJsonRealProcFilesByGroup(
            int pageIndex,
            int pageSize,
            string logonUserId,
            string logonUserIp,
            EntityOfficeDocumentRealProcFile officeDocumentRealProcFile)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentRealProcFileOperateBusiness(logonUserId, logonUserIp)
                    .GetJsonRealProcFilesByGroup(pageIndex, pageSize, officeDocumentRealProcFile);
            });
            #endregion
        }

        public string DeleteRealProcFile(
            string procFileId, string logonUserId, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentRealProcFileOperateBusiness(
                    logonUserId, logonUserIp)
                    .DeleteRealProcFile(procFileId);
            });
            #endregion
        }

        public string ExecOKProcFile(
            string procFileId, string logonUserId, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentOKProcFileBusiness(
                    logonUserId, logonUserIp)
                    .ExecOKProcFile(procFileId);
            });
            #endregion
        }
        public string GetUpdateUsersByprocFileId(string logonUserId, string logonUserIp,string procFileId)
        {
            #region
            return JsonException.Wrap(() =>
                {
                    return new OfficeDocumentRealProcFileOperateBusiness(logonUserId, logonUserIp).GetUpdateUsersByprocFileId(procFileId);
                });
            #endregion
        }
    }
}
