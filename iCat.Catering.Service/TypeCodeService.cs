
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
    class TypeCodeService : ITypeCodeService
    {
        public ITypeCodeDao _TypeCodeDao { get; set; }

        #region 添加操作
        /// <summary>
        /// 添加[typeCode]数据到数据库（有源、单实体）。
        /// </summary>
        /// <param name="typeCodeData">源数据集</param>
        /// <param name="typeCode">欲添加的实体</param>
        public void Add(
            ref TypeCodeData typeCodeData,
            EntityTypeCode typeCode)
        {
            #region
            typeCodeData.AddCache(typeCode);
            _TypeCodeDao.Save(typeCodeData);
            #endregion
        }
        /// <summary>
        /// 添加[typeCode]数据到数据库（有源、多实体）。
        /// </summary>
        /// <param name="typeCodeData">源数据集</param>
        /// <param name="typeCodes">欲添加的多实体</param>
        public void Add(
            ref TypeCodeData typeCodeData,
            IList<EntityTypeCode> typeCodes)
        {
            #region
            typeCodeData.AddCache(typeCodes);
            _TypeCodeDao.Save(typeCodeData);
            #endregion
        }
        /// <summary>
        /// 添加[typeCode]数据到数据库（无源、单实体）。
        /// </summary>
        /// <param name="typeCode">单实体</param>
        /// <returns>保存后的数据集</returns>
        public TypeCodeData Add(
            EntityTypeCode typeCode)
        {
            #region
            TypeCodeData typecodedata = new TypeCodeData();
            this.Add(ref typecodedata, typeCode);
            return typecodedata;
            #endregion
        }
        /// <summary>
        /// 添加[typeCode]数据到数据库（无源、多实体）。
        /// </summary>
        /// <param name="typeCodes">多实体</param>
        /// <returns>保存后的数据集</returns>
        public TypeCodeData Add(
            IList<EntityTypeCode> typeCodes)
        {
            #region
            TypeCodeData typecodedata = new TypeCodeData();
            this.Add(ref typecodedata, typeCodes);
            return typecodedata;
            #endregion
        }
        #endregion

        #region 编辑操作
        /// <summary>
        /// 编辑[typeCode]数据到数据库（有源、单实体）
        /// </summary>
        /// <param name="typeCodeData">源数据集</param>
        /// <param name="typeCode">实体</param>
        public void Edit(
            ref TypeCodeData typeCodeData,
            EntityTypeCode typeCode)
        {
            #region
            typeCodeData.EditCache(typeCode);
            _TypeCodeDao.Save(typeCodeData);
            #endregion
        }
        #endregion

        #region 删除操作
        /// <summary>
        /// 删除[typeCode]数据集中的数据
        /// </summary>
        /// <param name="typeCodeData">源数据集</param>
        /// <param name="typeCode">要删除的实体</param>
        public void Delete(
            ref TypeCodeData typeCodeData,
            EntityTypeCode typeCode)
        {
            #region
            typeCodeData.DeleteCache(typeCode);
            _TypeCodeDao.Save(typeCodeData);
            #endregion
        }
        #endregion
        
        #region 检索操作
        
        /// <summary>
        /// 根据实体的指定属性从数据库中查询符合条件的数据
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns>符合条件的数据</returns>
        public TypeCodeData GetTypeCodeByKeys(
            EntityTypeCode typeCode)
        {
            #region
            TypeCodeData ds = null;
            QueryCondition condition = new QueryCondition();

            condition._DBContainer.AddAndCondition(
                TypeCodeMapping.c_ID,
                EnumCondition.Equal,
                typeCode.c_ID, EnumSqlType.uniqguid);

            condition._DBContainer.AddAndCondition(
                TypeCodeMapping.PType,
                EnumCondition.Equal,
                typeCode.PType, EnumSqlType.nvarchar);

            ds = _TypeCodeDao.SelectSingleT(condition);
            return ds;
            #endregion
        }

        /// <summary>
        /// 获取全部数据（表数据量大时慎用）
        /// </summary>
        /// <returns>表全部数据</returns>
        public TypeCodeData GetAll()
        {
            #region
            return _TypeCodeDao.SelectSingleT(null);
            #endregion
        }
        #endregion


        public TypeCodeData GetData(EntityTypeCode typeCode)
        {
            throw new NotImplementedException();
        }
    }
}

