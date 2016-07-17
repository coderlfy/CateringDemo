using Foundation.Core;
using Spring.Data.Core;
using Spring.Transaction;
using Spring.Transaction.Support;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    abstract class AbstractBusiness
    {

        public delegate string LogonCallback();

        private string _logonUser;

        public string _LogonUser
        {
            get { return _logonUser; }
            set { _logonUser = value; }
        }

        private string _logonUserIp;

        public string _LogonUserIp
        {
            get { return _logonUserIp; }
            set { _logonUserIp = value; }
        }

        public AbstractBusiness(
            string logonUserId, string logonUserIp)
        {
            if (!string.IsNullOrEmpty(logonUserId))
                this._LogonUser = logonUserId.ToLower();
            this._logonUserIp = logonUserIp;
        }
        public AbstractBusiness(
            string logonUserId)
        {
            if (!string.IsNullOrEmpty(logonUserId))
                this._LogonUser = logonUserId.ToLower();
        }

        /// <summary>
        /// 将多个业务操作进行事务包装
        /// </summary>
        /// <param name="business"></param>
        /// <returns></returns>
        protected string TransactionWarp(
            TransactionDelegate business)
        {
            #region
            IPlatformTransactionManager transactionmanager =
                new ServiceDomainPlatformTransactionManager();
            TransactionTemplate transtemplate =
                new TransactionTemplate(transactionmanager);

            return transtemplate.Execute(business).ToString();
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        protected string UserSessionCheck(
            LogonCallback callback)
        {
            #region
            if (string.IsNullOrEmpty(this._LogonUser))
                return JsonHelper.GetErrorJson("sessioninvalid");
            return (callback != null) ? callback() : JsonHelper.GetErrorJson("业务方法为NULL！");
            #endregion
        }

        protected delegate DataSet DLGetBusinessData(
            QueryCondition condition, out int totalCount);
        protected string GetJsonByPage(
            int pageIndex, int pageSize,
            DLGetBusinessData getBusinessData)
        {
            #region
            return this.UserSessionCheck(delegate
            {
                QueryCondition condition = new QueryCondition()
                {
                    _PageIndex = pageIndex,
                    _PageSize = pageSize
                };
                int totalCount = 0;
                JsonHelper jsonhlp = new JsonHelper();
                jsonhlp.GetTopicsJson(getBusinessData(condition, out totalCount).Tables[0]);
                jsonhlp.AddObjectToJson("total", totalCount.ToString());
                jsonhlp.AddObjectToJson("success", "true");
                return jsonhlp.ToString();
            });
            #endregion
        }

        public string getModulesGUIDLower(Module module) {
            switch (module) {
                case Module.AddressBook:
                    return "7a3c4397-6685-4bc4-a66d-2120b86c02e8";
                case Module.Archive:
                    return "05510414-f65e-42de-a7fc-85dbe9c759b2";
                case Module.Document:
                    return "d33b06bf-8930-439a-a671-1b82e3cbfc60";
                case Module.FirstPage:
                    return "bc4cb7d0-2353-4052-8ae4-5fd9525cfb6d";
                case Module.IM:
                    return "34ff8044-68fd-43e4-9528-bf9115bc20a8";
                case Module.Index:
                    return "3adfe552-baaf-49d9-a846-447bd58b2722";
                case Module.Mail:
                    return "6c8f8127-d8c8-478b-ac8b-0eb4bfefbf2a";
                case Module.Message:
                    return "4219c525-a564-4b8c-9c49-148c08830e48";
                case Module.Notice:
                    return "719894a3-8035-4929-a0c2-79c43b398b3f";
                case Module.Software:
                    return "7090ce17-a57a-4cf3-a441-00beab0f20a1";
                case Module.System:
                    return "a600e26a-0b12-437e-857a-99ed882d74ae";
            }
            return Guid.NewGuid().ToString().ToLower();
        }
    }

    public enum Module
    {
        AddressBook,
        Archive,
        Document,
        FirstPage,
        IM,
        Index,
        Mail,
        Message,
        Notice,
        Software,
        System
    }
}
