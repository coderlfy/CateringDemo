using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Catering.Service
{

    partial class WCFService : ISystem
    {

        public string RefreshAllModulesCache(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new SystemBusiness(logonUser, logonUserIp)
                    .RefreshAllModulesCache();
            });
            #endregion
        }
    }
}
