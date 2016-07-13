
/****************************************
***生成器版本：V2.0
***创建人：lifengyan
***生成时间：2016-07-12 23:42:15
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using iCat.Catering.IDao;
using iCat.Catering.IService;
using iCat.Catering.Model;
using iCat.Catering.DBMapping;
using Foundation.Core;
using System;
using System.Collections.Generic;

namespace iCat.Catering.Service
{
    class OrderDetailService : IOrderDetailService
    {
        public IOrderDetailDao _OrderDetailDao { get; set; }

        #region 添加操作
        /// <summary>
        /// 添加[orderDetail]数据到数据库（有源、单实体）。
        /// </summary>
        /// <param name="orderDetailData">源数据集</param>
        /// <param name="orderDetail">欲添加的实体</param>
        public void Add(
            ref OrderDetailData orderDetailData,
            EntityOrderDetail orderDetail)
        {
            #region
            orderDetailData.AddCache(orderDetail);
            _OrderDetailDao.Save(orderDetailData);
            #endregion
        }
        /// <summary>
        /// 添加[orderDetail]数据到数据库（有源、多实体）。
        /// </summary>
        /// <param name="orderDetailData">源数据集</param>
        /// <param name="orderDetails">欲添加的多实体</param>
        public void Add(
            ref OrderDetailData orderDetailData,
            IList<EntityOrderDetail> orderDetails)
        {
            #region
            orderDetailData.AddCache(orderDetails);
            _OrderDetailDao.Save(orderDetailData);
            #endregion
        }
        /// <summary>
        /// 添加[orderDetail]数据到数据库（无源、单实体）。
        /// </summary>
        /// <param name="orderDetail">单实体</param>
        /// <returns>保存后的数据集</returns>
        public OrderDetailData Add(
            EntityOrderDetail orderDetail)
        {
            #region
            OrderDetailData orderdetaildata = new OrderDetailData();
            this.Add(ref orderdetaildata, orderDetail);
            return orderdetaildata;
            #endregion
        }
        /// <summary>
        /// 添加[orderDetail]数据到数据库（无源、多实体）。
        /// </summary>
        /// <param name="orderDetails">多实体</param>
        /// <returns>保存后的数据集</returns>
        public OrderDetailData Add(
            IList<EntityOrderDetail> orderDetails)
        {
            #region
            OrderDetailData orderdetaildata = new OrderDetailData();
            this.Add(ref orderdetaildata, orderDetails);
            return orderdetaildata;
            #endregion
        }
        #endregion

        #region 编辑操作
        /// <summary>
        /// 编辑[orderDetail]数据到数据库（有源、单实体）
        /// </summary>
        /// <param name="orderDetailData">源数据集</param>
        /// <param name="orderDetail">实体</param>
        public void Edit(
            ref OrderDetailData orderDetailData,
            EntityOrderDetail orderDetail)
        {
            #region
            orderDetailData.EditCache(orderDetail);
            _OrderDetailDao.Save(orderDetailData);
            #endregion
        }
        #endregion

        #region 删除操作
        /// <summary>
        /// 删除[orderDetail]数据集中的数据
        /// </summary>
        /// <param name="orderDetailData">源数据集</param>
        /// <param name="orderDetail">要删除的实体</param>
        public void Delete(
            ref OrderDetailData orderDetailData,
            EntityOrderDetail orderDetail)
        {
            #region
            orderDetailData.DeleteCache(orderDetail);
            _OrderDetailDao.Save(orderDetailData);
            #endregion
        }
        #endregion
        
        #region 检索操作
        
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="orderDetail"></param>
        /// <returns>符合条件的数据</returns>
        public OrderDetailData GetOrderDetailByKeys(
            EntityOrderDetail orderDetail)
        {
            #region
            OrderDetailData ds = null;
            QueryCondition condition = new QueryCondition();
            
            condition._DBContainer.AddAndCondition(
                OrderDetailMapping.d_ID, 
                EnumCondition.Equal, 
                orderDetail.d_ID, EnumSqlType.uniqguid);

            ds = _OrderDetailDao.SelectSingleT(condition);
            return ds;
            #endregion
        }

        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        public OrderDetailData GetAll()
        {
            #region
            return _OrderDetailDao.SelectSingleT(null);
            #endregion
        }
        #endregion
    }
}

