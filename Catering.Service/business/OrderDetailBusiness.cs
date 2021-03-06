
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
    class OrderDetailBusiness : AbstractBusiness
    {
        private IOrderDetailService _orderDetailService
            = (IOrderDetailService)SpringManager.GetObject(SpringKeys.OrderDetailService);

        public OrderDetailBusiness(
            string logonUserId, string logonUserIp) 
            : base(logonUserId, logonUserIp)
        { }
        public OrderDetailBusiness(
            string logonUserId) 
            : base(logonUserId)
        { }
        /// <summary>
        /// 根据关键字获取实体对象
        /// </summary>
        /// <param name="d_ID"></param>
        /// <returns>实体</returns>
        EntityOrderDetail GetEntity(
            string d_ID)
        {
            #region
            EntityOrderDetail entitykeys =
                new EntityOrderDetail()
                {
                    d_ID = d_ID
                };

            OrderDetailData ds = 
                this._orderDetailService.GetOrderDetailByKeys(entitykeys);

            return ds.GetEntity<EntityOrderDetail>(0);
            #endregion
        }
    }
}

