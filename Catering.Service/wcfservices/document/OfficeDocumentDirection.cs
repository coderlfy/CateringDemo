using CustomSpring.Core;
using Foundation.Core;
using NormalDocumentOffice.IService;
using NormalDocumentOffice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentDirection
    {
       
        #region 方向

        private IOfficeDocumentDirectionService directionService;

        public IOfficeDocumentDirectionService DirectionService
        {
            get
            {
                if (directionService == null)
                {
                    directionService = (IOfficeDocumentDirectionService)SpringManager.GetObject(SpringKeys.OfficeDocumentDirectionService);
                }
                return directionService;
            }
            set { directionService = value; }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="officeDocumenttype"></param>
       
        public void AddNewDocumentDirection(EntityOfficeDocumentDirection officeDocumenttype)
        {
            officeDocumenttype.directionId = (DirectionService.GetMaxId() + 1).ToString();
            DirectionService.Add(officeDocumenttype);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="officeDocumenttype"></param>
       
        public void DeleteDocumentDirection(EntityOfficeDocumentDirection officeDocumenttype)
        {
            OfficeDocumentDirectionData data = DirectionService.GetOfficeDocumentDirectionDataByKeys(officeDocumenttype);
            DirectionService.Delete(ref data, officeDocumenttype);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="officeDocumenttype"></param>
       
        public void UpdateDocumentDirection(EntityOfficeDocumentDirection officeDocumenttype)
        {
            OfficeDocumentDirectionData data = DirectionService.GetOfficeDocumentDirectionDataByKeys(officeDocumenttype);
            DirectionService.Edit(ref data, officeDocumenttype);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="officeDocumentTemplate"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
       
        public OfficeDocumentDirectionData GetDocumentDirection(EntityOfficeDocumentDirection officeDocumentTemplate,
            int pageIndex, int pageSize)
        {
            QueryCondition condition = new QueryCondition();
            condition._PageSize = pageSize;
            condition._PageIndex = pageIndex;
            return DirectionService.GetOfficeDocumentDirectionData(officeDocumentTemplate, condition);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="officeDocumentTemplate"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
       
        public string GetDocumentDirectionJosn(EntityOfficeDocumentDirection officeDocumentTemplate,
            int pageIndex, int pageSize)
        {
            OfficeDocumentDirectionData data = GetDocumentDirection(officeDocumentTemplate, pageIndex, pageSize);
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


        public string GetJsonDocumentDirectionAllFromCache(
            string logonUser, string logonUserIp)
        {
            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentDirectionBusiness(logonUser, logonUserIp)
                    .GetJsonDocumentDirectionAllFromCache();
            });
            #endregion
        }
    }
}
