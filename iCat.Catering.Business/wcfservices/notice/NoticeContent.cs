using Foundation.Core;
using Notice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : INoticeContent
    {
        public string AddNoticeContent(
            string logonUser, string logonUserIp, 
            Notice.Model.EntityNoticeContent noticeContent)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .AddNewNoticeContent(noticeContent);
            });
            #endregion
        }

        public string GetNoticeContentForManage(
            string logonUser, string logonUserIp, 
            int pageIndex, int pageSize, 
            Notice.Model.EntityNoticeContent content)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .GetNoticesForManage(content, pageIndex, pageSize);
            });
            #endregion
        }

        public string GetNoticeContentForReceiverView(
            string logonUser, string logonUserIp,
            int pageIndex, int pageSize, EntityNoticeContent content,
            EntityNoticeSendLog sendlog,
            EntityNoticeContentReceiveStatus receiveStatus)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeReceiveLogBusiness(logonUser, logonUserIp)
                    .GetNoticeContentForReceiverView(pageIndex, pageSize, content, sendlog, receiveStatus);
            });
            #endregion
        }

        public string ReleaseNoticeContent(
            string logonUser, string logonUserIp, 
            string contentId, string[] toUserIds)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .ReleaseNoticeContent(contentId, toUserIds);
            });
            #endregion
        }

        public string ReleaseNoticeContentForTimeout(
            string logonUser, string logonUserIp, 
            string contentId, string[] toUserIds, 
            string sendTime)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .ReleaseNoticeContentByTimeout(contentId, toUserIds, sendTime);
            });
            #endregion
        }

        public string CancelReleaseNoticeContent(
            string logonUser, 
            string logonUserIp, 
            string contentId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .CancelReleaseNoticeContent(contentId);
            });
            #endregion
        }


        public string GetJsonContent(
            string logonUser, 
            string logonUserIp, 
            string contentId)
        {
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .GetJsonContent(contentId);
            });
        }


        public string UpdateNoticeContent(
            string logonUser, string logonUserIp, 
            Notice.Model.EntityNoticeContent noticeContent)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .EditNoticeContent(noticeContent);
            });
            #endregion
        }

        public string DeleteNoticeContent(
            string logonUser, string logonUserIp, 
            Notice.Model.EntityNoticeContent noticeContent)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .DeleteNoticeContent(noticeContent);
            });
            #endregion
        }


        public string LockNoticeContent(
            string logonUser, string logonUserIp, 
            string contentId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentBusiness(logonUser, logonUserIp)
                    .LockOrUnlockNoticeContent(contentId);
            });
            #endregion
        }


        public string ExecReadForNoticeContent(
            string logonUser, string logonUserIp, 
            string contentId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeContentReceiveStatusBusiness(logonUser, logonUserIp)
                    .ExecIsReadForNoticeContent(contentId);
            });
            #endregion
        }


        public string GetJsonReceiversForLastSend(
            string logonUser, string logonUserIp, 
            string contentId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new NoticeReceiveLogBusiness(logonUser, logonUserIp)
                    .GetJsonReceivers(contentId);
            });
            #endregion
        }
    }
}
