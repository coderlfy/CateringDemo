
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
    class OrderService : IOrderService
    {
        public IOrderDao _OrderDao { get; set; }

        #region 添加操作
        /// <summary>
        /// 添加[order]数据到数据库（有源、单实体）。
        /// </summary>
        /// <param name="orderData">源数据集</param>
        /// <param name="order">欲添加的实体</param>
        public void Add(
            ref OrderData orderData,
            EntityOrder order)
        {
            #region
            orderData.AddCache(order);
            _OrderDao.Save(orderData);
            #endregion
        }
        /// <summary>
        /// 添加[order]数据到数据库（有源、多实体）。
        /// </summary>
        /// <param name="orderData">源数据集</param>
        /// <param name="orders">欲添加的多实体</param>
        public void Add(
            ref OrderData orderData,
            IList<EntityOrder> orders)
        {
            #region
            orderData.AddCache(orders);
            _OrderDao.Save(orderData);
            #endregion
        }
        /// <summary>
        /// 添加[order]数据到数据库（无源、单实体）。
        /// </summary>
        /// <param name="order">单实体</param>
        /// <returns>保存后的数据集</returns>
        public OrderData Add(
            EntityOrder order)
        {
            #region
            OrderData orderdata = new OrderData();
            this.Add(ref orderdata, order);
            return orderdata;
            #endregion
        }
        /// <summary>
        /// 添加[order]数据到数据库（无源、多实体）。
        /// </summary>
        /// <param name="orders">多实体</param>
        /// <returns>保存后的数据集</returns>
        public OrderData Add(
            IList<EntityOrder> orders)
        {
            #region
            OrderData orderdata = new OrderData();
            this.Add(ref orderdata, orders);
            return orderdata;
            #endregion
        }
        #endregion

        #region 编辑操作
        /// <summary>
        /// 编辑[order]数据到数据库（有源、单实体）
        /// </summary>
        /// <param name="orderData">源数据集</param>
        /// <param name="order">实体</param>
        public void Edit(
            ref OrderData orderData,
            EntityOrder order)
        {
            #region
            orderData.EditCache(order);
            _OrderDao.Save(orderData);
            #endregion
        }
        #endregion

        #region 删除操作
        /// <summary>
        /// 删除[order]数据集中的数据
        /// </summary>
        /// <param name="orderData">源数据集</param>
        /// <param name="order">要删除的实体</param>
        public void Delete(
            ref OrderData orderData,
            EntityOrder order)
        {
            #region
            orderData.DeleteCache(order);
            _OrderDao.Save(orderData);
            #endregion
        }
        #endregion
        
        #region 检索操作
        
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="order"></param>
        /// <returns>符合条件的数据</returns>
        public OrderData GetOrderByKeys(
            EntityOrder order)
        {
            #region
            OrderData ds = null;
            QueryCondition condition = new QueryCondition();
            
            condition._DBContainer.AddAndCondition(
                OrderMapping.o_ID, 
                EnumCondition.Equal, 
                order.o_ID, EnumSqlType.uniqguid);

            ds = _OrderDao.SelectSingleT(condition);
            return ds;
            #endregion
        }

        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        public OrderData GetAll()
        {
            #region
            return _OrderDao.SelectSingleT(null);
            #endregion
        }
        #endregion
    }
}

