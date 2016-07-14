
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
    public class OrderData : DataLibBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OrderData()
        {
            this.buildData();
        }
        private void buildData()
        {
            #region
            DataTable dt = new DataTable(OrderMapping.Order);
			dt.Columns.Add(OrderMapping.o_ID, typeof(System.Guid));
			dt.Columns.Add(OrderMapping.orderNO, typeof(System.String));
			dt.Columns.Add(OrderMapping.writeTime, typeof(System.DateTime));
			dt.Columns.Add(OrderMapping.writeIP, typeof(System.String));
            dt.PrimaryKey = new DataColumn[1] { dt.Columns[OrderMapping.o_ID] };
            dt.TableName = OrderMapping.Order;
            this.Tables.Add(dt);
            this.DataSetName = "TOrder";
            #endregion
        }
        /// <summary>
        /// 将实体赋予数据行。
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="order"></param>
        private void assignAll(
            DataRow currentRow, EntityOrder order)
        {
            #region
			this.Assign(currentRow, OrderMapping.o_ID, order.o_ID);
			this.Assign(currentRow, OrderMapping.orderNO, order.orderNO);
			this.Assign(currentRow, OrderMapping.writeTime, order.writeTime);
			this.Assign(currentRow, OrderMapping.writeIP, order.writeIP);
            #endregion
        }
        /// <summary>
        /// 接口：添加实体到缓存。
        /// </summary>
        /// <param name="order"></param>
        public void AddCache(
            EntityOrder order)
        {
            #region
            base.checkIsNull(() => { 
                this.buildData();
            });
                
            DataRow dr = this.Tables[0].NewRow();
            assignAll(dr, order);
            this.Tables[0].Rows.Add(dr);
            #endregion
        }
        /// <summary>
        /// 接口：添加多实体到缓存。
        /// </summary>
        /// <param name="orders"></param>
        public void AddCache(
            IList<EntityOrder> orders)
        {
            #region
            foreach (EntityOrder order in orders)
                this.AddCache(order);
            #endregion
        }
        /// <summary>
        /// 接口：编辑单实体到缓存。
        /// </summary>
        /// <param name="order"></param>
        public void EditCache(
            EntityOrder order)
        {
            #region
            base.checkIsNotNull(() => { 
                DataRow dr = findRow(order);

                if (dr != null)
                    this.assignAll(dr, order);
                else
                    Console.WriteLine("OrderData Cache hasn't order！");
            });
            #endregion
        }
        /// <summary>
        /// 接口：从缓存中删除实体。
        /// </summary>
        /// <param name="order"></param>
        public void DeleteCache(
            EntityOrder order)
        {
            #region
            base.checkIsNotNull(() =>
            {
                DataRow dr = findRow(order);

                if (dr != null)
                    dr.Delete();
                else
                    Console.WriteLine("OrderData Cache hasn't order！");
            });
            #endregion
        }
        /// <summary>
        /// 根据实体查找数据行，用于编辑或删除缓存。
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        private DataRow findRow(
            EntityOrder order)
        {
            #region
            return this.Tables[0].Rows.Find(
                this.getPrimaryParams(order));
            #endregion
        }
        /// <summary>
        /// 从实体中获取关键字参数
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        private object[] getPrimaryParams(
            EntityOrder order)
        {
            #region
            IList<object> dbparams = new List<object>();
			dbparams.Add(order.o_ID);
            return dbparams.ToArray<object>();
            #endregion
        }
    }
}

