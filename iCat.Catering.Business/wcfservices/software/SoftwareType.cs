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
    partial class WCFService : ISoftwareType
    {
        public string AddNewSoftwareType(
            EntitySoftwareType softwareType,
             string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).AddNewSoftwareType(softwareType);
            });
            #endregion
        }
        public string AddAddNewSoftwareType(
            EntitySoftwareType softwareType,
             string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).AddAddNewSoftwareType(softwareType);
            });
            #endregion
        }
        public string DeleteSoftwareType(
            EntitySoftwareType softwareType,
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).DeleteSoftwareType(softwareType);
            });
            #endregion
        }
        public string EditSoftwareType(
            EntitySoftwareType softwareType,
             string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).EditSoftwareType(softwareType);
            });
            #endregion
        }
        public string GetJsonSoftwareType(
            EntitySoftwareType softwareType, 
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).GetJsonSoftwareType(softwareType);
            });
            #endregion
        }
        public string GetComBoxJsonSoftwareType(
            EntitySoftwareType softwareType, 
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).GetComBoxJsonSoftwareType(softwareType);
            });
            #endregion
        }
        public string GetSingleComBoxJsonSoftwareType(
            EntitySoftwareType softwareType, 
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).GetSingleComBoxJsonSoftwareType(softwareType);
            });
            #endregion
        }
        public string getSoftwareTypeList(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).getSoftwareTypeList();
            });
            #endregion
        }
        public string LockedSoftWareType(
            string logonUser, string logonUserIp, 
            string softwareTypeId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).LockOrUnlockSoftwareType(softwareTypeId);
            });
            #endregion
        }
        public string GetJsonAllSoftwareTypes(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareTypeBusiness(logonUser, logonUserIp).GetJsonAllSoftwareTypes();
            });
            #endregion
        }
    }
}
