
/****************************************
***生成器版本：V2.0
***创建人：lifengyan
***生成时间：2016-07-12 23:42:15
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using CustomSpring.Core;
using Foundation.Core;
using iCat.Catering.IDao;
using iCat.Catering.Model;

namespace iCat.Catering.Dao
{
    public class OrderDao : BaseDao, IOrderDao
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="orderData">欲保存的数据集</param>
        public void Save(OrderData orderData)
        {
            base.Save(orderData);
        }
        
        /// <summary>
        /// 检索单表
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns>Order的数据集</returns>
        public OrderData SelectSingleT(
            QueryCondition condition)
        {
            return base.GetDataSet<OrderData>(condition);
        }

        #region 用户自定义多表关联查询模版
        /*
        public DataSet SelectOrderByPage(
            QueryCondition condition, 
            out int totalCount) 
        {
            #region
            //该sql语句需用户自定义构建
            string businesssql = @"select a.applyForId,a.userOfApplyFor,d.groupId,d.groupNO,d.groupName,
a.applyForMemo,a.applyForTime 
 from IMApplyForGroup a
left join IMVerifyApplyFor b on a.applyForId=b.applyForId 
join IMGroup d on a.groupId=d.groupId ";
            //分页后的呈现数据源
            DataSet ds = new DataSet();
            //添加分页依据字段（必选，可多个），请根据实际业务定义。
            condition.AddInKey(OrderMapping.primaryKeyName);
            //填充数据源
            base.fillDsByPage(ds, condition, businesssql);
            //符合查询条件的数据记录（调用基类查询方法）
            totalCount = base.selectRecordCount(
                condition, businesssql);
            return ds;
            #endregion
        }
        */
        #endregion
    }
}

