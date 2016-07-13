
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
    public class EntityFood : IEntity
    {
		/// <summary>
		/// 关键字。
		/// </summary>
		public String f_ID { get; set; }
		/// <summary>
		/// 形态（菜、汤、饮料）。
		/// </summary>
		public String Morp { get; set; }
		/// <summary>
		/// 显示的编号。
		/// </summary>
		public String ViewNO { get; set; }
		/// <summary>
		/// 食物名称。
		/// </summary>
		public String FoodName { get; set; }
		/// <summary>
		/// 单价。
		/// </summary>
		public String Price { get; set; }
        /// <summary>
        /// 从数据集中根据主键获取实体时（接口方法）
        /// </summary>
        /// <param name="dr"></param>
        public void Get(DataRow dr)
        {
			this.f_ID = dr[FoodMapping.f_ID].ToString();
			this.Morp = dr[FoodMapping.Morp].ToString();
			this.ViewNO = dr[FoodMapping.ViewNO].ToString();
			this.FoodName = dr[FoodMapping.FoodName].ToString();
			this.Price = dr[FoodMapping.Price].ToString();
        }
    }
}

