using Foundation.Core;
using LHWebIM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IIMGroupUser
    {

        public string EditIMGroupUsers(EntityIMGroupUsers model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupUsersBusiness(logonUser, logonUserIp).EditIMGroupUser(model);
            });
        }


        public string DeleteIMGroupUsers(EntityIMGroupUsers model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupUsersBusiness(logonUser, logonUserIp).DeleteIMGroupUser(model);
            });
        }


        public string PullBlackGroupUsers(EntityIMGroupUsers model, string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMGroupUsersBusiness(logonUser, logonUserIp).PullBlackGroupUsers(model);
            });
        }
    }
}
