using FirstPageSetting.Model;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IFirstPageModule
    {
        public string GetFirstPageModule(
            string userId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new FirstPageModuleByUserBusiness(userId).GetJsonFirstPageModuleByUserId();
            });
            #endregion
        }

        public void AddFirstPageModule(string logonUserId,
            List<EntityFirstPageModule> firstPageModules)
        {
            new FirstPageModuleBusiness(logonUserId).AddFirstPageModule(firstPageModules);
        }

        public string SaveFirstPageModuleEntity(
            string logonUserId, string logonUserIp, 
            EntityFirstPageModuleByUser firstPageModules)
        {
            return JsonException.Wrap(() =>
            {
                return new FirstPageModuleByUserBusiness(logonUserId, logonUserIp)
                    .SaveFirstPageModuleEntity(firstPageModules);
            });
        }
    }
}
