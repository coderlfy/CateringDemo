using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ISystemUserInfoTree
    {
        public string GetUserInfoTree(string[] ArryId, GetUsersMode kind)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return (new SystemUserInfoWithDeptBusiness()).GetUserInfoTree(ArryId, kind);
            });
            #endregion
        }
        public string GetUserInfoTreeByCheckIds(string[] userids, string[] checkedIds, GetUsersMode kind)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return (new SystemUserInfoWithDeptBusiness()).GetUserInfoTree(userids, checkedIds, kind);
            });
            #endregion
        }
    }
}
