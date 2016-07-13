using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveExecOkLogs
    {
        public string GetJsonArchiveExecOkLogs(string logonUser, string logonUserIp, int pageIndex, int pageSize, EntityArchiveExecOkLogs archiveExecOkLogs, EntityArchiveHistoryProcFile archiveHistoryFile)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveExecOkLogsBusiness(logonUser, logonUserIp)
                    .GetArchiveExecOkLogsByPage(pageIndex, pageSize, archiveExecOkLogs,archiveHistoryFile);
            });
            #endregion
        }
    }
}
