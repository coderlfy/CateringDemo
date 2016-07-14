using CustomSpring.Core;
using Foundation.Core;
using NormalDocumentOffice.IService;
using NormalDocumentOffice.Model;
using Catering.Service.threads;
using SoftwareManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISoftwareUploadFileType
    {
        public string AddNewSoftwareUploadFileType(EntitySoftwareUploadFileType fileType,
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadFileTypeBusiness(logonUser, logonUserIp).AddNewSoftwareUploadFileType(fileType);
            });
            #endregion
        }
        public string EditSoftwareUploadFileType(EntitySoftwareUploadFileType fileType,
            string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadFileTypeBusiness(logonUser, logonUserIp).EditSoftwareUploadFileType(fileType);
            });
        }
        public string DeleteSoftwareUploadFileType(EntitySoftwareUploadFileType fileType, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadFileTypeBusiness(logonUser, logonUserIp).DeleteSoftwareUploadFileType(fileType);
            });
        }
        public string GetFileTypesByConditions(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize, 
            EntitySoftwareUploadFileType fileType)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadFileTypeBusiness(logonUser, logonUserIp).GetFileTypesByConditions(pageIndex, pageSize, fileType);
            });
            #endregion
        }


        public string GetJsonAllFileTypes(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadFileTypeBusiness(logonUser, logonUserIp).GetJsonAllFileTypes();
            });
            #endregion
        }
    }
}
