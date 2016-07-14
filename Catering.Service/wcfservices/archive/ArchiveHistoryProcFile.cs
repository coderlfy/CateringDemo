using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveHistoryProcFile
    {
        public string InsertArchiveHistoryProcFile(
            string logonUser, string logonUserIp,
            EntityArchiveHistoryProcFile archiveHistoryFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveHistoryProcFileBusiness(logonUser, logonUserIp)
                    .InsertArchiveHistoryProcFile(archiveHistoryFile);
            });
        }

        public string DeleteArchiveHistoryProcFile(
            string logonUser, string logonUserIp,
            EntityArchiveHistoryProcFile archiveHistoryFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveHistoryProcFileBusiness(logonUser, logonUserIp)
                    .DeleteArchiveHistoryProcFile(archiveHistoryFile);
            });
        }

        public EntityArchiveHistoryProcFile GetEntityArchiveHistoryProcFile(
          string logonUser, string logonUserIp, string procFileId)
        {

            return new ArchiveHistoryProcFileBusiness(logonUser, logonUserIp)
                .GetEntityArchiveHistoryProcFile(procFileId);

        }

        public string GetJsonArchiveHistoryProcFile(
            string logonUser, string logonUserIp,
            EntityArchiveHistoryProcFile archiveHistoryFile,
            int pageIndex, int pageSize)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveHistoryProcFileBusiness(logonUser, logonUserIp)
                    .GetJsonArchiveHistoryProcFile(archiveHistoryFile, pageIndex, pageSize);
            });
        }

        public string SwitchArchiveRealFile(
            string logonUser, string logonUserIp,
            EntityArchiveHistoryProcFile archiveHistoryFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveHistoryProcFileBusiness(logonUser, logonUserIp)
                    .SwitchArchiveRealFile(archiveHistoryFile);
            });
        }
        public string EditArchiveHistoryProcFile(
            string logonUser, string logonUserIp,
            EntityArchiveHistoryProcFile archiveHistoryFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveHistoryProcFileBusiness(logonUser, logonUserIp)
                    .EditArchiveHistoryProcFile(archiveHistoryFile);
            });
        }
    }
}
