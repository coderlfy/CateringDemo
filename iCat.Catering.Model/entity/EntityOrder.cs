
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
using System.Data;
using System;

namespace iCat.Catering.Model
{
    public class EntityOrder : IEntity
    {
		/// <summary>
		/// 关键字。
		/// </summary>
		public String o_ID { get; set; }
		/// <summary>
		/// 订单编号。
		/// </summary>
		public String orderNO { get; set; }
		/// <summary>
		/// 出单时刻。
		/// </summary>
		public String writeTime { get; set; }
		/// <summary>
		/// 出单人IP。
		/// </summary>
		public String writeIP { get; set; }
        /// <summary>
        /// 从数据集中根据主键获取实体时（接口方法）
        /// </summary>
        /// <param name="dr"></param>
        public void Get(DataRow dr)
        {
			this.o_ID = dr[OrderMapping.o_ID].ToString();
			this.orderNO = dr[OrderMapping.orderNO].ToString();
			this.writeTime = dr[OrderMapping.writeTime].ToString();
			this.writeIP = dr[OrderMapping.writeIP].ToString();
        }
    }
}

