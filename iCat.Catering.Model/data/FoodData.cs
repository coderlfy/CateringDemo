
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
    public class FoodData : DataLibBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public FoodData()
        {
            this.buildData();
        }
        private void buildData()
        {
            #region
            DataTable dt = new DataTable(FoodMapping.Food);
			dt.Columns.Add(FoodMapping.f_ID, typeof(System.Guid));
			dt.Columns.Add(FoodMapping.Morp, typeof(System.Guid));
			dt.Columns.Add(FoodMapping.ViewNO, typeof(System.String));
			dt.Columns.Add(FoodMapping.FoodName, typeof(System.String));
			dt.Columns.Add(FoodMapping.Price, typeof(System.Decimal));
            dt.PrimaryKey = new DataColumn[1] { dt.Columns[FoodMapping.f_ID] };
            dt.TableName = FoodMapping.Food;
            this.Tables.Add(dt);
            this.DataSetName = "TFood";
            #endregion
        }
        /// <summary>
        /// 将实体赋予数据行。
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="food"></param>
        private void assignAll(
            DataRow currentRow, EntityFood food)
        {
            #region
			this.Assign(currentRow, FoodMapping.f_ID, food.f_ID);
			this.Assign(currentRow, FoodMapping.Morp, food.Morp);
			this.Assign(currentRow, FoodMapping.ViewNO, food.ViewNO);
			this.Assign(currentRow, FoodMapping.FoodName, food.FoodName);
			this.Assign(currentRow, FoodMapping.Price, food.Price);
            #endregion
        }
        /// <summary>
        /// 接口：添加实体到缓存。
        /// </summary>
        /// <param name="food"></param>
        public void AddCache(
            EntityFood food)
        {
            #region
            base.checkIsNull(() => { 
                this.buildData();
            });
                
            DataRow dr = this.Tables[0].NewRow();
            assignAll(dr, food);
            this.Tables[0].Rows.Add(dr);
            #endregion
        }
        /// <summary>
        /// 接口：添加多实体到缓存。
        /// </summary>
        /// <param name="foods"></param>
        public void AddCache(
            IList<EntityFood> foods)
        {
            #region
            foreach (EntityFood food in foods)
                this.AddCache(food);
            #endregion
        }
        /// <summary>
        /// 接口：编辑单实体到缓存。
        /// </summary>
        /// <param name="food"></param>
        public void EditCache(
            EntityFood food)
        {
            #region
            base.checkIsNotNull(() => { 
                DataRow dr = findRow(food);

                if (dr != null)
                    this.assignAll(dr, food);
                else
                    Console.WriteLine("FoodData Cache hasn't food！");
            });
            #endregion
        }
        /// <summary>
        /// 接口：从缓存中删除实体。
        /// </summary>
        /// <param name="food"></param>
        public void DeleteCache(
            EntityFood food)
        {
            #region
            base.checkIsNotNull(() =>
            {
                DataRow dr = findRow(food);

                if (dr != null)
                    dr.Delete();
                else
                    Console.WriteLine("FoodData Cache hasn't food！");
            });
            #endregion
        }
        /// <summary>
        /// 根据实体查找数据行，用于编辑或删除缓存。
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        private DataRow findRow(
            EntityFood food)
        {
            #region
            return this.Tables[0].Rows.Find(
                this.getPrimaryParams(food));
            #endregion
        }
        /// <summary>
        /// 从实体中获取关键字参数
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        private object[] getPrimaryParams(
            EntityFood food)
        {
            #region
            IList<object> dbparams = new List<object>();
			dbparams.Add(food.f_ID);
            return dbparams.ToArray<object>();
            #endregion
        }
    }
}

