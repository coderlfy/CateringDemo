using Foundation.Core;
using LHWebIM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IIMApplyForGroup
    {
        public string AddApplyForGroup(
            string logonUser, string logonUserIp, 
            LHWebIM.Model.EntityIMApplyForGroup applyForGroup)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMApplyForGroupBusiness(logonUser, logonUserIp).AddApplyForGroup(applyForGroup);
            });
            #endregion
        }


        public string GetGroupsOfOthers(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize, EntityIMGroup group)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMApplyForGroupBusiness(logonUser, logonUserIp).GetGroupsOfOthers(pageIndex, pageSize, group);
            });
            #endregion
        }


        public string GetUserListOfApplyForGroup(
            string logonUser, string logonUserIp, 
            int pageIndex, int pageSize, 
            EntityIMApplyForGroup applyForGroup)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return "";//new IMApplyForGroupBusiness(logonUser, logonUserIp).GetGroupsOfOthers(pageIndex, pageSize, applyForGroup);
            });
            #endregion
        }


        public string GetApplyForGroupByPage(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize, 
            EntityIMGroup group)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMApplyForGroupBusiness(logonUser, logonUserIp).GetApplyForGroupByPage(pageIndex, pageSize, group);
            });
            #endregion
        }

        public string AllowJoinGroup(
            string logonUserId, string logonUserIp, 
            EntityIMApplyForGroup applyForGroup, 
            EntityIMGroup imGroup)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMApplyForGroupBusiness(logonUserId, logonUserIp)
                    .AllowJoinGroup(applyForGroup, imGroup);
            });
            #endregion
        }
        public string RefuseJoinGroup(
            string logonUserId, string logonUserIp, 
            EntityIMApplyForGroup applyForGroup, 
            EntityIMGroup imGroup)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMApplyForGroupBusiness(logonUserId, logonUserIp)
                    .refuseJoinGroup(applyForGroup, imGroup);
            });
            #endregion
        }
    }
}
