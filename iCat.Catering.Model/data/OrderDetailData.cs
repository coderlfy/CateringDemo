
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
using iCat.Catering.DBMapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace iCat.Catering.Model
{
    public class OrderDetailData : DataLibBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OrderDetailData()
        {
            this.buildData();
        }
        private void buildData()
        {
            #region
            DataTable dt = new DataTable(OrderDetailMapping.OrderDetail);
			dt.Columns.Add(OrderDetailMapping.d_ID, typeof(System.Guid));
			dt.Columns.Add(OrderDetailMapping.o_ID, typeof(System.Guid));
			dt.Columns.Add(OrderDetailMapping.f_ID, typeof(System.Guid));
            dt.PrimaryKey = new DataColumn[1] { dt.Columns[OrderDetailMapping.d_ID] };
            dt.TableName = OrderDetailMapping.OrderDetail;
            this.Tables.Add(dt);
            this.DataSetName = "TOrderDetail";
            #endregion
        }
        /// <summary>
        /// 将实体赋予数据行。
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="orderDetail"></param>
        private void assignAll(
            DataRow currentRow, EntityOrderDetail orderDetail)
        {
            #region
			this.Assign(currentRow, OrderDetailMapping.d_ID, orderDetail.d_ID);
			this.Assign(currentRow, OrderDetailMapping.o_ID, orderDetail.o_ID);
			this.Assign(currentRow, OrderDetailMapping.f_ID, orderDetail.f_ID);
            #endregion
        }
        /// <summary>
        /// 接口：添加实体到缓存。
        /// </summary>
        /// <param name="orderDetail"></param>
        public void AddCache(
            EntityOrderDetail orderDetail)
        {
            #region
            base.checkIsNull(() => { 
                this.buildData();
            });
                
            DataRow dr = this.Tables[0].NewRow();
            assignAll(dr, orderDetail);
            this.Tables[0].Rows.Add(dr);
            #endregion
        }
        /// <summary>
        /// 接口：添加多实体到缓存。
        /// </summary>
        /// <param name="orderDetails"></param>
        public void AddCache(
            IList<EntityOrderDetail> orderDetails)
        {
            #region
            foreach (EntityOrderDetail orderdetail in orderDetails)
                this.AddCache(orderdetail);
            #endregion
        }
        /// <summary>
        /// 接口：编辑单实体到缓存。
        /// </summary>
        /// <param name="orderDetail"></param>
        public void EditCache(
            EntityOrderDetail orderDetail)
        {
            #region
            base.checkIsNotNull(() => { 
                DataRow dr = findRow(orderDetail);

                if (dr != null)
                    this.assignAll(dr, orderDetail);
                else
                    Console.WriteLine("OrderDetailData Cache hasn't orderDetail！");
            });
            #endregion
        }
        /// <summary>
        /// 接口：从缓存中删除实体。
        /// </summary>
        /// <param name="orderDetail"></param>
        public void DeleteCache(
            EntityOrderDetail orderDetail)
        {
            #region
            base.checkIsNotNull(() =>
            {
                DataRow dr = findRow(orderDetail);

                if (dr != null)
                    dr.Delete();
                else
                    Console.WriteLine("OrderDetailData Cache hasn't orderDetail！");
            });
            #endregion
        }
        /// <summary>
        /// 根据实体查找数据行，用于编辑或删除缓存。
        /// </summary>
        /// <param name="orderDetail"></param>
        /// <returns></returns>
        private DataRow findRow(
            EntityOrderDetail orderDetail)
        {
            #region
            return this.Tables[0].Rows.Find(
                this.getPrimaryParams(orderDetail));
            #endregion
        }
        /// <summary>
        /// 从实体中获取关键字参数
        /// </summary>
        /// <param name="orderDetail"></param>
        /// <returns></returns>
        private object[] getPrimaryParams(
            EntityOrderDetail orderDetail)
        {
            #region
            IList<object> dbparams = new List<object>();
			dbparams.Add(orderDetail.d_ID);
            return dbparams.ToArray<object>();
            #endregion
        }
    }
}

