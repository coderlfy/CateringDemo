using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : INoticeColumns
    {
        public string AddNoticeColumn(
            string logonUser, string logonUserIp, 
            Notice.Model.EntityNoticeColumns noticeColumn)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .AddNewNoticeColumn(noticeColumn);
            });
            #endregion
        }

        public string UpdateNoticeColumn(
            string logonUser, string logonUserIp, 
            Notice.Model.EntityNoticeColumns noticeColumn)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .EditNoticeColumn(noticeColumn);
            });
            #endregion
        }

        public string DeleteNoticeColumn(
            string logonUser, string logonUserIp, 
            Notice.Model.EntityNoticeColumns noticeColumn)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .DeleteNoticeColumn(noticeColumn);
            });
            #endregion
        }

        public string GetNoticeColumnsJson(
            string logonUser, string logonUserIp,
            Notice.Model.EntityNoticeColumns noticeColumn, 
            int pageIndex, int pageSize)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .GetNoticeColumnsJson(noticeColumn, pageIndex, pageSize);
            });
            #endregion
        }


        public string SetNoticeColumnManagers(
            string logonUser, string logonUserIp, 
            string columnId, 
            string[] toUserIds)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnManagerBusiness(logonUser, logonUserIp)
                    .SetManager(columnId, toUserIds);
            });
            #endregion
        }


        public string GetJsonNoticeColumnsByAll(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .GetNoticeColumnsAll();
            });
            #endregion
        }

        public string GetJsonNoticeColumnsByMyManageAll(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .GetNoticeColumnsMyManageAll();
            });
            #endregion
        }


        public string GetJsonNoticeColumnsByAllFromCache(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .GetNoticeColumnsAllFromCache();
            });
            #endregion
        }

        public string GetJsonNoticeColumnsByMyManageAllFromCache(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeColumnsBusiness(logonUser, logonUserIp)
                    .GetNoticeColumnsMyManageAllFromCache();
            });
            #endregion
        }
    }
}
