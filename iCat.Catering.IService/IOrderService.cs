
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
    public interface IOrderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderData"></param>
        /// <param name="order"></param>
        void Add(
            ref OrderData orderData,
            EntityOrder order);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderData"></param>
        /// <param name="orders"></param>
        void Add(
           ref OrderData orderData,
           IList<EntityOrder> orders);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        OrderData Add(
            EntityOrder order);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        OrderData Add(
            IList<EntityOrder> orders);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderData"></param>
        /// <param name="order"></param>
        void Edit(
            ref OrderData orderData,
            EntityOrder order);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderData"></param>
        /// <param name="order"></param>
        void Delete(
            ref OrderData orderData,
            EntityOrder order);

        
        /// <summary>
        /// 根据实体的关键字从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="order"></param>
        /// <returns>符合条件的数据</returns>
        OrderData GetOrderByKeys(
            EntityOrder order);
        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        OrderData GetAll();
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据（条件只=）
        /// </summary>
        /// <returns>符合条件的数据</returns>
        OrderData GetData(
            EntityOrder order);
    }
}

