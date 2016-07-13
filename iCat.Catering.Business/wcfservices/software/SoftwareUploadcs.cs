using Foundation.Core;
using SoftwareManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISoftwareUpload
    {
        public string GetSoftWareUploadByUser(string logonUser, string logonUserIp, int pageIndex, int pageSize, EntitySoftwareUpload softwareUpload)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadBusiness(logonUser, logonUserIp).GetSoftWareUploadByUser(pageIndex, pageSize, softwareUpload);
            });
            #endregion
        }

        public string GetSoftWareUploadCanUse(string logonUser, string logonUserIp, int pageIndex, int pageSize,EntitySoftwareUpload softwareUpload)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadBusiness(logonUser, logonUserIp).GetSoftWareUploadCanUse(pageIndex, pageSize,softwareUpload);
            });
            #endregion
        }

        public string DeleteSoftWare(string logonUser, string logonUserIp,EntitySoftwareUpload softwareUpload)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadBusiness(logonUser, logonUserIp).DeleteSoftWare(softwareUpload);
            });
            #endregion
        }

        public string EditSoftWare(string logonUser, string logonUserIp,EntitySoftwareUpload softwareUpload)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadBusiness(logonUser, logonUserIp).EditSoftWare(softwareUpload);
            });
            #endregion
        }

        public string AddSofrWare(string logonUser, string logonUserIp,EntitySoftwareUpload softwareUpload)
        {
           #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadBusiness(logonUser, logonUserIp).AddSofrWare(softwareUpload);
            });
            #endregion
        }

        public EntitySoftwareUpload SoftwareDownload(string logonUser, string logonUserIp,string  softwareUploadId)
        {
            return new SoftwareUploadBusiness("","").SoftwareDownload(softwareUploadId);
        }


        public string GetManagerSoftWare(string logonUser, string logonUserIp, int pageIndex, int pageSize, EntitySoftwareUpload softwareUpload)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadBusiness(logonUser, logonUserIp).GetManagerSoftWare(pageIndex, pageSize, softwareUpload);
            });
            #endregion
        }


        public string LockedSoftWare(string logonUser, string logonUserIp, string softwareId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadBusiness(logonUser, logonUserIp).LockOrUnlockSoftware(softwareId);
            });
            #endregion
        }
    }
}
