
/****************************************
***生成器版本：V2.0
***创建人：lifengyan
***生成时间：2016-07-12 23:42:15
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using iCat.Catering.Model;
using System;
using System.Collections.Generic;

namespace iCat.Catering.IService
{
    public interface IOrderDetailService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDetailData"></param>
        /// <param name="orderDetail"></param>
        void Add(
            ref OrderDetailData orderDetailData,
            EntityOrderDetail orderDetail);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDetailData"></param>
        /// <param name="orderDetails"></param>
        void Add(
           ref OrderDetailData orderDetailData,
           IList<EntityOrderDetail> orderDetails);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDetail"></param>
        /// <returns></returns>
        OrderDetailData Add(
            EntityOrderDetail orderDetail);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDetails"></param>
        /// <returns></returns>
        OrderDetailData Add(
            IList<EntityOrderDetail> orderDetails);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDetailData"></param>
        /// <param name="orderDetail"></param>
        void Edit(
            ref OrderDetailData orderDetailData,
            EntityOrderDetail orderDetail);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDetailData"></param>
        /// <param name="orderDetail"></param>
        void Delete(
            ref OrderDetailData orderDetailData,
            EntityOrderDetail orderDetail);

        
        /// <summary>
        /// 根据实体的关键字从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="orderDetail"></param>
        /// <returns>符合条件的数据</returns>
        OrderDetailData GetOrderDetailByKeys(
            EntityOrderDetail orderDetail);
        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        OrderDetailData GetAll();
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据（条件只=）
        /// </summary>
        /// <returns>符合条件的数据</returns>
        OrderDetailData GetData(
            EntityOrderDetail orderDetail);
    }
}

