
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
    public interface IFoodService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="foodData"></param>
        /// <param name="food"></param>
        void Add(
            ref FoodData foodData,
            EntityFood food);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="foodData"></param>
        /// <param name="foods"></param>
        void Add(
           ref FoodData foodData,
           IList<EntityFood> foods);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        FoodData Add(
            EntityFood food);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="foods"></param>
        /// <returns></returns>
        FoodData Add(
            IList<EntityFood> foods);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="foodData"></param>
        /// <param name="food"></param>
        void Edit(
            ref FoodData foodData,
            EntityFood food);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="foodData"></param>
        /// <param name="food"></param>
        void Delete(
            ref FoodData foodData,
            EntityFood food);

        
        /// <summary>
        /// 根据实体的关键字从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="food"></param>
        /// <returns>符合条件的数据</returns>
        FoodData GetFoodByKeys(
            EntityFood food);
        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        FoodData GetAll();
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据（条件只=）
        /// </summary>
        /// <returns>符合条件的数据</returns>
        FoodData GetData(
            EntityFood food);
    }
}

