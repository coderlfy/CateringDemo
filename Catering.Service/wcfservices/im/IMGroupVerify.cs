using Foundation.Core;
using LHWebIM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IIMGroupVerify
    {
        public string GroupVerify(EntityIMGroupVerify model, EntityIMGroup group, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupVerifyBusiness(logonUser, logonUserIp).IMGroupVerify(model, group);
            });
        }

        public string GetJsonGroupVerify(EntityIMGroupVerify model, EntityIMGroup group, int pageIndex, int pageSize, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupVerifyBusiness(logonUser, logonUserIp).GetJsonIMGroup(model,group,pageIndex,pageSize);
            });
        } 
    }
}
