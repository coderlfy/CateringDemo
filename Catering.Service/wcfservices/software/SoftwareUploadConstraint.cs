using Foundation.Core;
using SoftwareManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISoftwareUploadConstraint
    {
        public string GetUploadFileType(string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SoftwareUploadConstraintBusiness(logonUser, logonUserIp).GetUploadFileType();
            });
            #endregion
        }


        public string GetUploadConstraint(string logonUser, string logonUserIp)
        {
            return new SoftwareUploadConstraintBusiness(logonUser, logonUserIp).GetUploadConstraint();
        }


        public string SaveUploadConstraint(string logonUser, string logonUserIp, EntitySoftwareUploadConstraint UploadConstraint)
        {
            return new SoftwareUploadConstraintBusiness(logonUser, logonUserIp).SaveUploadConstraint(UploadConstraint);
        }
    }
}
 