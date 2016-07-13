﻿/****************************************
###创建人：lify
###创建时间：不记得了
###公司：Cat Studio
###最后修改时间：2012-04-03
###最后修改人：lify
###修改摘要：
****************************************/
#region V1.0
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web.Script.Serialization;

namespace JsonHlpLib
{
    public class DataTableConverter : JavaScriptConverter
    {
        /// <summary>
        /// 重写序列化方式
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            #region
            DataTable dt = obj as DataTable;
            Dictionary<string, object> result = new Dictionary<string, object>();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    row.Add(dc.ColumnName, dr[dc.ColumnName]);
                }
                rows.Add(row);
            }
            result["topics"] = rows;
            return result;
            #endregion
        }



        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            #region
            throw new NotImplementedException();
            #endregion
        }
        /// <summary>
        /// 设置支持的序列化对象类型
        /// </summary>
        public override IEnumerable<Type> SupportedTypes
        {
            #region
            get
            {
                return new Type[] { typeof(DataTable) };
            }
            #endregion
        }
    }
}
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Foundation.Core
{
    public class DataTableConverter
    {
        /// <summary>
        /// 重写序列化方式
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        private static string CreateSerialize(
            DataTable dt,
            string jsonTablename,
            List<string> returnColumnNames)
        {
            #region
            string result = "";
            StringBuilder rowjson = new StringBuilder();
            string topicname = (jsonTablename == null) ? "topics" : jsonTablename;

            foreach (DataRow dr in dt.Rows)
                rowjson.AppendFormat("{{{0}}},", getSingleRowJson(dr, dt.Columns, returnColumnNames));

            if (dt.Rows.Count > 0)
                rowjson.Remove(rowjson.Length - 1, 1);

            result = string.Format("{{\"{0}\":[{1}]}}", topicname, rowjson);
            return result;
            #endregion
        }

        private static StringBuilder getSingleRowJson(
            DataRow currentRow,
            DataColumnCollection cols,
            List<string> returnColumnNames)
        {
            #region
            StringBuilder sb = new StringBuilder();
            foreach (DataColumn dc in cols)
            {
                if (returnColumnNames != null)
                    if (returnColumnNames.IndexOf(dc.ColumnName) == -1)
                        continue;

                string temp = "";
                if (dc.DataType == typeof(Boolean))
                {
                    temp = (currentRow[dc.ColumnName] == System.DBNull.Value)
                        ? "null"
                        : Convert.ToBoolean(currentRow[dc.ColumnName]).ToString().ToLower();

                    sb.Append(String.Format("\"{0}\":{1},",
                        dc.ColumnName, temp));
                }
                else if (dc.DataType == typeof(DateTime))
                {
                    temp = (currentRow[dc.ColumnName] == System.DBNull.Value)
                        ? ""
                        : Convert.ToDateTime(currentRow[dc.ColumnName]).ToString("yyyy-MM-dd HH:mm:ss");

                    sb.Append(String.Format("\"{0}\":\"{1}\",",
                        dc.ColumnName, temp));
                }
                else
                {
                    sb.Append(String.Format("\"{0}\":\"{1}\",",
                        dc.ColumnName,
                        JsonFilter.Exec(currentRow[dc.ColumnName].ToString())));
                }
            }
            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);

            return sb;
            #endregion
        }

        public static string Serialize(DataTable dt)
        {
            return CreateSerialize(dt, null, null);
        }
        public static string Serialize(
            DataTable dt,
            List<string> returnColumnNames)
        {
            return CreateSerialize(dt, null, returnColumnNames);
        }
        public static string Serialize(
            DataTable dt,
            string jsonTablename)
        {
            return CreateSerialize(dt, jsonTablename, null);
        }
        /*
        public object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            #region
            throw new NotImplementedException();
            #endregion
        }
         
        /// <summary>
        /// 设置支持的序列化对象类型
        /// </summary>
        public override IEnumerable<Type> SupportedTypes
        {
            #region
            get
            {
                return new Type[] { typeof(DataTable) };
            }
            #endregion
        }
        */
    }
}

