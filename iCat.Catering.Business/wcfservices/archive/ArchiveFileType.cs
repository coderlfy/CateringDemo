using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveFileType
    {
        public string AddNewArchiveFileType(EntityArchiveFileType fileType, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveFileTypeBusiness(logonUser, logonUserIp).AddNewArchiveFileType(fileType);
            });
            #endregion
        }

        public string GetArchiveFileTypesByConditions(string logonUser, string logonUserIp, int pageIndex, int pageSize, EntityArchiveFileType fileType)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveFileTypeBusiness(logonUser, logonUserIp).GetFileTypesByConditions(pageIndex, pageSize,fileType);
            });
            #endregion
        }

        public string EditArchiveFileType(EntityArchiveFileType fileType, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveFileTypeBusiness(logonUser, logonUserIp).EditArchiveFileType(fileType);
            });
            #endregion
        }

        public string DeleteArchiveFileType(EntityArchiveFileType fileType, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveFileTypeBusiness(logonUser, logonUserIp).DeleteArchiveFileType(fileType);
            });
            #endregion
        }


        public string LockOrUnlockArchiveFileType(string archiveFileTypeId, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveFileTypeBusiness(logonUser, logonUserIp).LockOrUnlockArchiveFileType(archiveFileTypeId);
            });
            #endregion
        }


        public string GetArchiveFileTypesAllFromCache(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveFileTypeBusiness(logonUser, logonUserIp).GetArchiveFileTypesAllFromCache();
            });
            #endregion
        }
    }
}
