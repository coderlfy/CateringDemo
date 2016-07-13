
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
using iCat.Catering.Model;

namespace iCat.Catering.IDao
{
    public interface ITypeCodeDao
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="typeCodeData">欲保存的数据集</param>
        void Save(TypeCodeData typeCodeData);
        
        /// <summary>
        /// 检索单表
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns>TypeCode的数据集</returns>
        TypeCodeData SelectSingleT(QueryCondition condition); 

        #region 用户自定义多表关联查询接口模版
        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        DataSet SelectTypeCodeByPage(
            QueryCondition condition, 
            out int totalCount);
        */
        #endregion
    }
}

