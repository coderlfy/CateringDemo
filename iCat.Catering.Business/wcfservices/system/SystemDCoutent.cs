
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISystemDCoutent
    {
        public string GetsDCoutent()
        {
            return (new SysTemCoutentBusiness()).GetDCoutentJson();
        }
    }
}
