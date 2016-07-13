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
    partial class WCFService : IOfficeDocumentTempProcFile
    {
        private IOfficeDocumentTempProcFileService _officeDocumentTempProcFileService
            = (IOfficeDocumentTempProcFileService)SpringManager.GetObject(SpringKeys.OfficeDocumentTempProcFileService);

        public string SaveDocumentTempProcFile(
            EntityOfficeDocumentTempProcFile officeDocumentTempProcFile)
        {
            #region
            return JsonException.Wrap(() => {

                officeDocumentTempProcFile.writeTime = AppTimer.GetStringForCurrentTime(); //？未来要修改成获取数据库时间
                if (string.IsNullOrEmpty(
                    officeDocumentTempProcFile.tempProcFileId))
                    //场景1：若没有该临时文档的ID则新增。
                    addTempProcFile(officeDocumentTempProcFile);
                else
                    //场景2：若存在该临时文档，则修改该ID对应的内容。
                    //场景3：若不存在该临时文档ID对应的文档（用户直接进行数据库缓存清理），则新增。
                    editTempProcFile(officeDocumentTempProcFile);

                JsonHelper jsonhlp = new JsonHelper();
                jsonhlp.AddObjectToJson("tempProcFileId", officeDocumentTempProcFile.tempProcFileId);
                jsonhlp.AddObjectToJson("success", "true");
                return jsonhlp.ToString();
            });

            #endregion
        }

        private void addTempProcFile(
            EntityOfficeDocumentTempProcFile officeDocumentTempProcFile)
        {
            #region
            officeDocumentTempProcFile.tempProcFileId = Guid.NewGuid().ToString();
            _officeDocumentTempProcFileService.Add(officeDocumentTempProcFile);
            #endregion
        }

        private void editTempProcFile(
            EntityOfficeDocumentTempProcFile officeDocumentTempProcFile)
        {
            #region
                OfficeDocumentTempProcFileData ds =
                    _officeDocumentTempProcFileService.GetOfficeDocumentTempProcFileDataByKeys(
                    officeDocumentTempProcFile);
                if (ds.Tables[0].Rows.Count > 0)
                    _officeDocumentTempProcFileService.Edit(ref ds, officeDocumentTempProcFile);
                else
                    addTempProcFile(officeDocumentTempProcFile);
            #endregion
        }


        public string DeleteDocumentTempProcFile(
            string tempProcFileId)
        {
            #region
            return JsonException.Wrap(() =>
            {
                EntityOfficeDocumentTempProcFile tempentity =
                    new EntityOfficeDocumentTempProcFile() { tempProcFileId = tempProcFileId };

                OfficeDocumentTempProcFileData ds =
                    _officeDocumentTempProcFileService
                    .GetOfficeDocumentTempProcFileDataByKeys(tempentity);

                if (ds.Tables[0].Rows.Count > 0)
                    _officeDocumentTempProcFileService.Delete(ref ds, tempentity);

                return JsonHelper.GetOnlySuccessJson(true);

            });
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tempProcFileId"></param>
        /// <returns></returns>
        public EntityOfficeDocumentTempProcFile GetOfficeDocumentTempProcFile(
            string tempProcFileId)
        {
            #region
            EntityOfficeDocumentTempProcFile tempprocfile =
                new EntityOfficeDocumentTempProcFile()
                {
                    tempProcFileId = tempProcFileId
                };

            OfficeDocumentTempProcFileData tempprocfiledata = 
                this._officeDocumentTempProcFileService
                .GetOfficeDocumentTempProcFileDataByKeys(tempprocfile);

            tempprocfile = tempprocfiledata.
                GetEntity<EntityOfficeDocumentTempProcFile>(0);

            return tempprocfile;
            #endregion
        }
    }
}
