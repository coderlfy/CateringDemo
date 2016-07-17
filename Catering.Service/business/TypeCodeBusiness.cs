
/****************************************
***生成器版本：V2.0
***创建人：lifengyan
***生成时间：2016-07-12 23:42:15
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using Foundation.Core;
using CustomSpring.Core;
using iCat.Catering.Model;
using iCat.Catering.IService;

namespace Catering.Service
{
    class TypeCodeBusiness : AbstractBusiness
    {
        private ITypeCodeService _typeCodeService
            = (ITypeCodeService)SpringManager.GetObject(SpringKeys.TypeCodeService);

        public TypeCodeBusiness(
            string logonUserId, string logonUserIp) 
            : base(logonUserId, logonUserIp)
        { }
        public TypeCodeBusiness(
            string logonUserId = "") 
            : base(logonUserId)
        { }

        public string GetJson(EntityTypeCode typecode)
        {
            return JsHelper.Get(_typeCodeService.GetTypeCodeByKeys(typecode));
        }
        /// <summary>
        /// 根据关键字获取实体对象
        /// </summary>
        /// <param name="c_ID"></param>
        /// <returns>实体</returns>
        EntityTypeCode GetEntity(
            string c_ID)
        {
            #region
            EntityTypeCode entitykeys =
                new EntityTypeCode()
                {
                    c_ID = c_ID
                };

            TypeCodeData ds = 
                this._typeCodeService.GetTypeCodeByKeys(entitykeys);

            return ds.GetEntity<EntityTypeCode>(0);
            #endregion
        }
    }
}

