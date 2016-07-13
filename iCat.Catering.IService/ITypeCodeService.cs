
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
    public interface ITypeCodeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeCodeData"></param>
        /// <param name="typeCode"></param>
        void Add(
            ref TypeCodeData typeCodeData,
            EntityTypeCode typeCode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeCodeData"></param>
        /// <param name="typeCodes"></param>
        void Add(
           ref TypeCodeData typeCodeData,
           IList<EntityTypeCode> typeCodes);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        TypeCodeData Add(
            EntityTypeCode typeCode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeCodes"></param>
        /// <returns></returns>
        TypeCodeData Add(
            IList<EntityTypeCode> typeCodes);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeCodeData"></param>
        /// <param name="typeCode"></param>
        void Edit(
            ref TypeCodeData typeCodeData,
            EntityTypeCode typeCode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeCodeData"></param>
        /// <param name="typeCode"></param>
        void Delete(
            ref TypeCodeData typeCodeData,
            EntityTypeCode typeCode);

        
        /// <summary>
        /// 根据实体的关键字从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns>符合条件的数据</returns>
        TypeCodeData GetTypeCodeByKeys(
            EntityTypeCode typeCode);
        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        TypeCodeData GetAll();
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据（条件只=）
        /// </summary>
        /// <returns>符合条件的数据</returns>
        TypeCodeData GetData(
            EntityTypeCode typeCode);
    }
}

