using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveAuthorizeCancelLogs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logonUser"></param>
        /// <param name="logonUserIp"></param>
        /// <param name="realFile">可查项：标题、上传人、上传时刻</param>
        /// <param name="current">可查项：授权给</param>
        /// <param name="cancellogs">可查项：撤销人、撤销时刻</param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public string GetJsonArchiveAuthorizeCancelLogs(
            string logonUser, string logonUserIp, 
            EntityArchiveRealFile realFile, 
            EntityArchiveAuthorizeCurrent current,
            EntityArchiveAuthorizeCancelLogs cancellogs, 
            int pageIndex, int pageSize)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveAuthorizeCancelLogsBusiness(logonUser, logonUserIp)
                    .GetJsonArchiveAuthorizeCancelLogs(realFile, current,cancellogs, pageIndex, pageSize);
            });
            #endregion
        }
    }
}
