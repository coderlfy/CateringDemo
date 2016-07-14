using Foundation.Core;
using LHWebIM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IIMGroupPullUsersVerify
    {

        public string AddNewIMGroupPullUsersVerify(EntityIMGroupPullUserVerify model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupPullUsersVerifyBusiness(logonUser, logonUserIp).AddNewIMGroupPullUsers(model);
            });
        }

        public string GetJsonIMGroupPullUsersVerify(EntityIMGroupPullUserVerify model, int pageIndex, int pageSize, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupPullUsersVerifyBusiness(logonUser, logonUserIp).GetJsonIMGroupPullUsersVerify(model, pageIndex, pageSize);
            });

        }
    }
}
