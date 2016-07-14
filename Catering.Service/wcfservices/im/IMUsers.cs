using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IIMUsers
    {
        public string GetJsonIMUsers(string logonUserId, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new IMUsersBusiness(logonUserId, logonUserIp).GetJsonOfIMUsers();
            });
        }
    }
}
