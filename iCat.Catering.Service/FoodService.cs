
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
    class FoodService : IFoodService
    {
        public IFoodDao _FoodDao { get; set; }

        #region 添加操作
        /// <summary>
        /// 添加[food]数据到数据库（有源、单实体）。
        /// </summary>
        /// <param name="foodData">源数据集</param>
        /// <param name="food">欲添加的实体</param>
        public void Add(
            ref FoodData foodData,
            EntityFood food)
        {
            #region
            foodData.AddCache(food);
            _FoodDao.Save(foodData);
            #endregion
        }
        /// <summary>
        /// 添加[food]数据到数据库（有源、多实体）。
        /// </summary>
        /// <param name="foodData">源数据集</param>
        /// <param name="foods">欲添加的多实体</param>
        public void Add(
            ref FoodData foodData,
            IList<EntityFood> foods)
        {
            #region
            foodData.AddCache(foods);
            _FoodDao.Save(foodData);
            #endregion
        }
        /// <summary>
        /// 添加[food]数据到数据库（无源、单实体）。
        /// </summary>
        /// <param name="food">单实体</param>
        /// <returns>保存后的数据集</returns>
        public FoodData Add(
            EntityFood food)
        {
            #region
            FoodData fooddata = new FoodData();
            this.Add(ref fooddata, food);
            return fooddata;
            #endregion
        }
        /// <summary>
        /// 添加[food]数据到数据库（无源、多实体）。
        /// </summary>
        /// <param name="foods">多实体</param>
        /// <returns>保存后的数据集</returns>
        public FoodData Add(
            IList<EntityFood> foods)
        {
            #region
            FoodData fooddata = new FoodData();
            this.Add(ref fooddata, foods);
            return fooddata;
            #endregion
        }
        #endregion

        #region 编辑操作
        /// <summary>
        /// 编辑[food]数据到数据库（有源、单实体）
        /// </summary>
        /// <param name="foodData">源数据集</param>
        /// <param name="food">实体</param>
        public void Edit(
            ref FoodData foodData,
            EntityFood food)
        {
            #region
            foodData.EditCache(food);
            _FoodDao.Save(foodData);
            #endregion
        }
        #endregion

        #region 删除操作
        /// <summary>
        /// 删除[food]数据集中的数据
        /// </summary>
        /// <param name="foodData">源数据集</param>
        /// <param name="food">要删除的实体</param>
        public void Delete(
            ref FoodData foodData,
            EntityFood food)
        {
            #region
            foodData.DeleteCache(food);
            _FoodDao.Save(foodData);
            #endregion
        }
        #endregion
        
        #region 检索操作
        
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="food"></param>
        /// <returns>符合条件的数据</returns>
        public FoodData GetFoodByKeys(
            EntityFood food)
        {
            #region
            FoodData ds = null;
            QueryCondition condition = new QueryCondition();
            
            condition._DBContainer.AddAndCondition(
                FoodMapping.f_ID, 
                EnumCondition.Equal, 
                food.f_ID, EnumSqlType.uniqguid);

            ds = _FoodDao.SelectSingleT(condition);
            return ds;
            #endregion
        }

        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        public FoodData GetAll()
        {
            #region
            return _FoodDao.SelectSingleT(null);
            #endregion
        }
        #endregion
    }
}

