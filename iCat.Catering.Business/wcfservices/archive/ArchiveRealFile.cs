using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveRealFile
    {
        public string AddArchiveRealFile(
            string logonUser, string logonUserIp,
            Archive.Model.EntityArchiveRealFile archiveRealFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveRealFileBusiness(logonUser, logonUserIp)
                    .AddArchiveRealFile(archiveRealFile);
            });
        }

        public string UpdateArchiveRealFile(
            string logonUser, string logonUserIp,
            Archive.Model.EntityArchiveRealFile archiveRealFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveRealFileBusiness(logonUser, logonUserIp)
                    .UpdateArchiveRealFile(archiveRealFile);
            });
        }
        public string EditArchiveRealFile(
            string logonUser, string logonUserIp,
            Archive.Model.EntityArchiveRealFile archiveRealFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveRealFileBusiness(logonUser, logonUserIp)
                    .EditArchiveRealFile(archiveRealFile);
            });
        }
        public string DeleteArchiveRealFile(
            string logonUser, string logonUserIp,
            Archive.Model.EntityArchiveRealFile archiveRealFile)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveRealFileBusiness(logonUser, logonUserIp)
                    .DeleteArchiveRealFile(archiveRealFile);
            });
        }

        public string GetJsonArchiveRealFileFromIndexDB(
            string logonUser, string logonUserIp,
            Archive.Model.EntityArchiveRealFile archiveRealFile,
            int pageIndex, int pageSize)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveRealFileBusiness(logonUser, logonUserIp)
                    .GetJsonArchiveRealFileFromIndexDB(archiveRealFile, pageIndex, pageSize);
            });
        }

        public Archive.Model.EntityArchiveRealFile GetEntityArchiveRealFile(
            string logonUser, string logonUserIp,
            string archiveId)
        {
            return new ArchiveRealFileBusiness(logonUser, logonUserIp).GetEntity(archiveId);
        }

        public string GetTreeJsonCanSendToUsers(
            string logonUser, string archiveId)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveRealFileBusiness(logonUser)
                    .GetTreeJsonCanSendToUsers(archiveId);
            });
        }
        public Archive.Model.EntityArchiveRealFile GeArchiveRealFiletEntity(string logonUser, string archiveId)
        {
            return new ArchiveRealFileBusiness(logonUser).GetEntity(archiveId);
        }
    }
}
