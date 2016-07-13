
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
    public class TypeCodeData : DataLibBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public TypeCodeData()
        {
            this.buildData();
        }
        private void buildData()
        {
            #region
            DataTable dt = new DataTable(TypeCodeMapping.TypeCode);
			dt.Columns.Add(TypeCodeMapping.c_ID, typeof(System.Guid));
			dt.Columns.Add(TypeCodeMapping.PType, typeof(System.String));
			dt.Columns.Add(TypeCodeMapping.name, typeof(System.String));
			dt.Columns.Add(TypeCodeMapping.writeTime, typeof(System.DateTime));
			dt.Columns.Add(TypeCodeMapping.writeIP, typeof(System.String));
            dt.PrimaryKey = new DataColumn[1] { dt.Columns[TypeCodeMapping.c_ID] };
            dt.TableName = TypeCodeMapping.TypeCode;
            this.Tables.Add(dt);
            this.DataSetName = "TTypeCode";
            #endregion
        }
        /// <summary>
        /// 将实体赋予数据行。
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="typeCode"></param>
        private void assignAll(
            DataRow currentRow, EntityTypeCode typeCode)
        {
            #region
			this.Assign(currentRow, TypeCodeMapping.c_ID, typeCode.c_ID);
			this.Assign(currentRow, TypeCodeMapping.PType, typeCode.PType);
			this.Assign(currentRow, TypeCodeMapping.name, typeCode.name);
			this.Assign(currentRow, TypeCodeMapping.writeTime, typeCode.writeTime);
			this.Assign(currentRow, TypeCodeMapping.writeIP, typeCode.writeIP);
            #endregion
        }
        /// <summary>
        /// 接口：添加实体到缓存。
        /// </summary>
        /// <param name="typeCode"></param>
        public void AddCache(
            EntityTypeCode typeCode)
        {
            #region
            base.checkIsNull(() => { 
                this.buildData();
            });
                
            DataRow dr = this.Tables[0].NewRow();
            assignAll(dr, typeCode);
            this.Tables[0].Rows.Add(dr);
            #endregion
        }
        /// <summary>
        /// 接口：添加多实体到缓存。
        /// </summary>
        /// <param name="typeCodes"></param>
        public void AddCache(
            IList<EntityTypeCode> typeCodes)
        {
            #region
            foreach (EntityTypeCode typecode in typeCodes)
                this.AddCache(typecode);
            #endregion
        }
        /// <summary>
        /// 接口：编辑单实体到缓存。
        /// </summary>
        /// <param name="typeCode"></param>
        public void EditCache(
            EntityTypeCode typeCode)
        {
            #region
            base.checkIsNotNull(() => { 
                DataRow dr = findRow(typeCode);

                if (dr != null)
                    this.assignAll(dr, typeCode);
                else
                    Console.WriteLine("TypeCodeData Cache hasn't typeCode！");
            });
            #endregion
        }
        /// <summary>
        /// 接口：从缓存中删除实体。
        /// </summary>
        /// <param name="typeCode"></param>
        public void DeleteCache(
            EntityTypeCode typeCode)
        {
            #region
            base.checkIsNotNull(() =>
            {
                DataRow dr = findRow(typeCode);

                if (dr != null)
                    dr.Delete();
                else
                    Console.WriteLine("TypeCodeData Cache hasn't typeCode！");
            });
            #endregion
        }
        /// <summary>
        /// 根据实体查找数据行，用于编辑或删除缓存。
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        private DataRow findRow(
            EntityTypeCode typeCode)
        {
            #region
            return this.Tables[0].Rows.Find(
                this.getPrimaryParams(typeCode));
            #endregion
        }
        /// <summary>
        /// 从实体中获取关键字参数
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        private object[] getPrimaryParams(
            EntityTypeCode typeCode)
        {
            #region
            IList<object> dbparams = new List<object>();
			dbparams.Add(typeCode.c_ID);
            return dbparams.ToArray<object>();
            #endregion
        }
    }
}

