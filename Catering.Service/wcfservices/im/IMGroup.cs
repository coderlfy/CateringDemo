using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IIMGroup
    {

        public string AddNewIMGroup(
            LHWebIM.Model.EntityIMGroup officeIMGroup, 
            string logonUser, 
            string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMGroupBusiness(logonUser, logonUserIp).AddNewIMGroup(officeIMGroup);
            });
            #endregion
        }

        public string DeleteIMGroup(
            string deleteGroupId, 
            string logonUser, 
            string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                LHWebIM.Model.EntityIMGroup officeIMGroup = 
                    new LHWebIM.Model.EntityIMGroup() { 
                        groupId = deleteGroupId 
                    };

                return new IMGroupBusiness(logonUser, logonUserIp)
                    .DeleteIMGroup(officeIMGroup);
            });
            #endregion
        }

        public string EditIMGroup(
            LHWebIM.Model.EntityIMGroup officeIMGroup, 
            string logonUser, 
            string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMGroupBusiness(logonUser, logonUserIp)
                    .EditIMGroup(officeIMGroup);
            });
            #endregion
        }



        public string GetJsonIMGroup(
            LHWebIM.Model.EntityIMGroup officeIMGroup, 
            int pageIndex, int pageSize, 
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMGroupBusiness(logonUser, logonUserIp)
                    .GetJsonIMGroup(officeIMGroup, pageIndex, pageSize);
            });
            #endregion
        }


        public LHWebIM.Model.EntityIMGroup GetIMGroupEntityById(string Id)
        {
            throw new NotImplementedException();
        }


        public string GetJsonIMGroupsForMe(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMGroupBusiness(logonUser, logonUserIp)
                    .GetJsonIMGroupsForMe();
            });
            #endregion
        }


        public string GetJsonIMGroupUsersByGroupId(
            string groupId, 
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new IMGroupUsersBusiness(logonUser, logonUserIp)
                    .GetJsonIMGroupUsersByGroupId(groupId);
            });
            #endregion
        }
    }
}
