using Archive.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IArchiveType
    {

        public string AddNewArchiveType(EntityArchiveType archiveType, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveTypeBusiness(logonUser, logonUserIp).AddArchiveType(archiveType);
            });
            #endregion
        }

        public string AddAddNewArchiveType(EntityArchiveType archiveType, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveTypeBusiness(logonUser, logonUserIp).AddAddNewArchiveType(archiveType);
            });
            #endregion
        }

        public string EditArchiveType(EntityArchiveType archiveType, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveTypeBusiness(logonUser, logonUserIp).UpdateArchiveType(archiveType);
            });
            #endregion
        }

        public string DeleteArchiveType(EntityArchiveType archiveType, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveTypeBusiness(logonUser, logonUserIp).DeleteArchiveType(archiveType);
            });
            #endregion
        }

        public string GetJsonArchiveType(string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveTypeBusiness(logonUser, logonUserIp).GetJsonArchiveType();
            });
            #endregion
        }


        public string LockOrUnlockArchiveType(string archiveTypeId, string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveTypeBusiness(logonUser, logonUserIp).LockOrUnlockArchiveType(archiveTypeId);
            });
            #endregion
        }


        public string GetJsonArchiveTypeAllFromCache(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new ArchiveTypeBusiness(logonUser, logonUserIp).GetJsonArchiveTypeAllFromCache();
            });
            #endregion
        }
    }
}
