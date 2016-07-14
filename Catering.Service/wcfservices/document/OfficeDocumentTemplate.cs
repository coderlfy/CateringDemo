
using CustomSpring.Core;
using Foundation.Core;
using NormalDocumentOffice.IService;
using NormalDocumentOffice.Model;
using Catering.Service.threads;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentTemplate
    {
        private IOfficeDocumentTemplateService getIOfficeDocumentTemplateService()
        {
            #region
            return (IOfficeDocumentTemplateService)
                SpringManager.GetObject(SpringKeys.OfficeDocumentTemplateService);
            #endregion
        }

        public string AddNewDocumentTemplate(
            EntityOfficeDocumentTemplate officeDocumentTemplate)
        {
            #region
            return JsonException.Wrap(() =>
            {
                if (string.IsNullOrEmpty(officeDocumentTemplate.writeUser))
                    return JsonHelper.GetErrorJson("sessioninvalid");

                IOfficeDocumentTemplateService service = getIOfficeDocumentTemplateService();

                officeDocumentTemplate.templateId = (service.GetMaxId() + 1).ToString();
                officeDocumentTemplate.writeTime = AppTimer.GetStringForCurrentTime();
                service.Add(officeDocumentTemplate);

                return JsonHelper.GetOnlySuccessJson(true);
            });
            #endregion
        }

        public void EditDocumentTemplate(
            EntityOfficeDocumentTemplate officeDocumentTemplate)
        {
            #region
            IOfficeDocumentTemplateService service = getIOfficeDocumentTemplateService();

            OfficeDocumentTemplateData ds = service.GetOfficeDocumentTemplateDataByKeys(officeDocumentTemplate);
            service.Edit(ref ds, officeDocumentTemplate);
            #endregion
        }

        public void DeleteDocumentTemplate(
            EntityOfficeDocumentTemplate officeDocumentTemplate)
        {
            #region
            IOfficeDocumentTemplateService service = getIOfficeDocumentTemplateService();

            OfficeDocumentTemplateData ds = service.GetOfficeDocumentTemplateDataByKeys(officeDocumentTemplate);
            service.Delete(ref ds, officeDocumentTemplate);
            #endregion
        }

        public EntityOfficeDocumentTemplate GetDocumentTemplateEntityByTemplateId(
            string templateId)
        {
            #region
            IOfficeDocumentTemplateService service = getIOfficeDocumentTemplateService();

            EntityOfficeDocumentTemplate templateentity = 
                new EntityOfficeDocumentTemplate() {
                    templateId = templateId
            };

            OfficeDocumentTemplateData templatedata = service
                .GetOfficeDocumentTemplateDataByKeys(templateentity);

            if(templatedata!=null)
            {
                if(templatedata.Tables[0].Rows.Count>0)
                {
                    DataRow dr = templatedata.Tables[0].Rows[0];
                    templateentity.Get(dr);
                }
            }
            return templateentity;
            #endregion
        }
        private OfficeDocumentTemplateData GetDocumentTemplate(EntityOfficeDocumentTemplate officeDocumentTemplate,
         int pageIndex, int pageSize)
        {
            IOfficeDocumentTemplateService service = getIOfficeDocumentTemplateService();
            QueryCondition condition = new QueryCondition();
            condition._PageSize = pageSize;
            condition._PageIndex = pageIndex;
            return service.GetOfficeDocumentTemplateData(officeDocumentTemplate, condition);
        }

         /// <summary>
        /// 查询公文模板
        /// </summary>
        /// <param name="officeDocumentTemplate"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public string GetJsonDocumentTemplate(
            EntityOfficeDocumentTemplate officeDocumentTemplate,
            int pageIndex,
            int pageSize)
        {
            #region
            OfficeDocumentTemplateData data = GetDocumentTemplate(officeDocumentTemplate,
          pageIndex, pageSize);

            JsonHelper jsonhlp = new JsonHelper();
            jsonhlp.GetTopicsJson(data.Tables[0]);
            int totalCount = data.Tables[0].Rows.Count;
            jsonhlp.AddObjectToJson("total", totalCount.ToString());
            jsonhlp.AddObjectToJson("success", "true");
            return jsonhlp.ToString();
            #endregion
        }



        public string GetJsonDocumentTemplateFromCache(
            string logonUser, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentTemplateBusiness(logonUser, logonUserIp)
                    .GetJsonDocumentTemplateFromCache();
            });
        }
    }
}
