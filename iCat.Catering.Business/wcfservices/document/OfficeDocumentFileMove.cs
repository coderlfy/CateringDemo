using CustomSpring.Core;
using Foundation.Core;
using LuceneNetHelper.Conditions;
using LuceneNetHelper.Search;
using NormalDocumentOffice.IService;
using NormalDocumentOffice.Model;
using Catering.Service.business.Index;
using Catering.Service.Index;
using Spring.Transaction.Interceptor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentFileMove
    {
        public string MoveProcFileToUsers(
            string logonUser,
            string logonUserIp,
            string procFileId,
            string[] ToUsers, string moveMemo)
        {
            #region
            return JsonException.Wrap(() =>
            {
                new OfficeDocumentFileMoveRecordBusiness(logonUser, logonUserIp)
                    .StartMove(procFileId, ToUsers, moveMemo);
            });
            #endregion
        }

        public string GetRecordsOfMoveProcFiles(
            string logonUser,
            int pageIndex, int pageSize,
            EntityOfficeDocumentRealProcFile procFileKeys,
            EntityOfficeDocumentFileMoveRecord moveRecordKeys)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentFileMoveRecordBusiness(logonUser)
                    .GetJsonMoveRecordsByPage(pageIndex, pageSize, procFileKeys, moveRecordKeys);
            });
            #endregion
        }

        public string MoveProcFileCheck(
            string logonUser, string logonUserIp,
            List<EntityOfficeDocumentFileMoveRecord> moveRecords,
            bool isPassed,string title,
            string checkMemo)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentFileMoveRecordBusiness(
                    logonUser, logonUserIp)
                    .CheckMove(moveRecords, isPassed,title, checkMemo);

            });
            #endregion
        }

        public string GetChecksOfMoveRecords(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize,
            EntityOfficeDocumentRealProcFile procFileKeys,
            EntityOfficeDocumentFileMoveCheck moveCheckKeys,EntityOfficeDocumentFileMoveRecord moverecordKeys)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentFileMoveCheckBusiness(logonUser, logonUserIp)
                    .GetJsonMoveChecksByPage(pageIndex, pageSize, procFileKeys, moveCheckKeys,moverecordKeys);
            });
            #endregion
        }
    }
}
