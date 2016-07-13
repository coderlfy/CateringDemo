using CustomSpring.Core;
using Foundation.Core;
using NormalDocumentOffice.IService;
using NormalDocumentOffice.Model;
using Catering.Service.threads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentType
    {
        private IOfficeDocumentTypeService getIOfficeDocumentTypeService()
        {
            #region
            return (IOfficeDocumentTypeService)
                SpringManager.GetObject(SpringKeys.OfficeDocumentTypeService);
            #endregion
        }

        public string GetAllDocumentTypes()
        {
            IOfficeDocumentTypeService service = this.getIOfficeDocumentTypeService();
            OfficeDocumentTypeData data = service.GetAll();
            JsonHelper jsonhlp = new JsonHelper();
            jsonhlp.GetTopicsJson(data.Tables[0]);
            int totalCount = data.Tables[0].Rows.Count;
            jsonhlp.AddObjectToJson("total", totalCount.ToString());
            jsonhlp.AddObjectToJson("success", "true");
            return jsonhlp.ToString();

        }

        #region 公文种类
        /// <summary>
        /// 添加文种
        /// </summary>
        /// <param name="officeDocumenttype"></param>

        public string AddNewDocumentType(EntityOfficeDocumentType officeDocumenttype)
        {
            return JsonException.Wrap(() =>
            {
                if (string.IsNullOrEmpty(officeDocumenttype.writeUser))
                    return JsonHelper.GetErrorJson("sessioninvalid");

                IOfficeDocumentTypeService service = getIOfficeDocumentTypeService();
                officeDocumenttype.writeTime = AppTimer.GetStringForCurrentTime();

                officeDocumenttype.officeDocumentTypeID = (service.GetMaxId() + 1).ToString();
                service.Add(officeDocumenttype);

                return JsonHelper.GetOnlySuccessJson(true);
            });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="officeDocumenttype"></param>

        public string DeleteDocumentType(EntityOfficeDocumentType officeDocumenttype)
        {
            return JsonException.Wrap(() =>
            {
                IOfficeDocumentTypeService service = getIOfficeDocumentTypeService();
                OfficeDocumentTypeData data = service.GetOfficeDocumentTypeDataByKeys(officeDocumenttype);
                service.Delete(ref data, officeDocumenttype);
                return JsonHelper.GetOnlySuccessJson(true);
            });
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="officeDocumenttype"></param>

        public void UpdateDocumentType(EntityOfficeDocumentType officeDocumenttype)
        {
            IOfficeDocumentTypeService service = getIOfficeDocumentTypeService();

            OfficeDocumentTypeData data = service.GetOfficeDocumentTypeDataByKeys(officeDocumenttype);
            service.Edit(ref data, officeDocumenttype);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="officeDocumentTemplate"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>

        private OfficeDocumentTypeData GetDocumentType(EntityOfficeDocumentType officeDocumentTemplate,
            int pageIndex, int pageSize)
        {
            IOfficeDocumentTypeService service = getIOfficeDocumentTypeService();
            QueryCondition condition = new QueryCondition();
            condition._PageSize = pageSize;
            condition._PageIndex = pageIndex;
            return service.GetOfficeDocumentTypeData(officeDocumentTemplate, condition);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="officeDocumentTemplate"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>

        public string GetDocumentTypeJosn(EntityOfficeDocumentType officeDocumentTemplate,
            int pageIndex, int pageSize)
        {
            OfficeDocumentTypeData data = GetDocumentType(officeDocumentTemplate, pageIndex, pageSize);
            #region
            JsonHelper jsonhlp = new JsonHelper();
            jsonhlp.GetTopicsJson(data.Tables[0]);
            int totalCount = data.Tables[0].Rows.Count;
            jsonhlp.AddObjectToJson("total", totalCount.ToString());
            jsonhlp.AddObjectToJson("success", "true");
            return jsonhlp.ToString();
            #endregion
        }

        #endregion



        public string GetAllXMLDocumentTypes()
        {
            IOfficeDocumentTypeService service = this.getIOfficeDocumentTypeService();
            return (new XMLUtility()).ConvertDataTableToXML(service.GetAll().Tables[0]);
        }


        public string GetJsonAllDocumentTypesFromCache(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentTypeBusiness(logonUser, logonUserIp)
                    .GetJsonAllDocumentTypesFromCache();
            });
            #endregion
        }
    }
}
