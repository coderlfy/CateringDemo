using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IIMGroupPullUsers
    {

        public string AddNewIMGroupPullUsers(LHWebIM.Model.EntityIMGroupPullUsers officeIMGroup, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupPullUsersBusiness(logonUser, logonUserIp).AddNewIMGroupPullUsers(officeIMGroup);
            });
        }

        public string GetJsonIMGroupPullUsers(LHWebIM.Model.EntityIMGroupPullUsers officeIMGroup, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupPullUsersBusiness(logonUser, logonUserIp).GetJsonIMGroupPullUsers(officeIMGroup);
            });

        }


        public LHWebIM.Model.EntityIMGroupPullUsers GetIMGroupPullUsersEntityById(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
