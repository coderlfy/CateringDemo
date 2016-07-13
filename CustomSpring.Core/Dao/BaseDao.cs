using Foundation.Core;
using Spring.Data.Common;
using Spring.Data.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CustomSpring.Core
{
    public class BaseDao : AdoDaoSupport
    {
        private const string _saveSqlFormat = @"-------------------开始执行保存操作-------------------
SQL语句：[{1}]
表名：[{2}]
结果：dataset内的记录条数[{3}],数据库受影响条数[{4}]
开始执行时刻：[{0}]
结束执行时刻：[{5}]
-------------------本次操作已完成---------------------";
        /// <summary>
        /// 保存数据集（添加、编辑、删除）单行或多行数据
        /// </summary>
        /// <param name="ds"></param>
        public void Save(
            DataSet ds)
        {
            #region

            string tablename = "";
            this.checkTablesCount(ds, () =>
            {
                tablename = ds.Tables[0].TableName;
                this.checkTablesName(tablename, () =>
                {
                    List<object> views = new List<object>();
                    views.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));
                    string selectsql = SQLCreator.CreateBuilderSelectSQL(ds);
                    views.Add(selectsql);
                    views.Add(tablename);
                    views.Add(ds.Tables[0].Rows.Count);

                    IDbParameters paramskey = getSelectParams(ds);

                    int updatecount = this.AdoTemplate.DataSetUpdateWithCommandBuilder(
                        ds, System.Data.CommandType.Text,
                        selectsql, paramskey,
                        ds.Tables[0].TableName);

                    views.Add(updatecount);
                    views.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));

                    if (SpringManager._EnableViewSaveSql)
                        Console.WriteLine(string.Format(_saveSqlFormat, views.ToArray()));
                });
            });
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public int GetMaxId<T>()
        {
            #region
            Type t = typeof(T);
            DataSet tuser = (DataSet)Activator.CreateInstance(t);

            DataColumn[] cols = SQLCreator.GetPrimaryKey(tuser);
            string keyfieldname = "";
            foreach (DataColumn col in cols)
            {
                Type fieldtype = col.DataType;
                TypeCode coltype = Type.GetTypeCode(fieldtype);
                if (coltype == TypeCode.Byte ||
                    coltype == TypeCode.Int16 ||
                    coltype == TypeCode.Int32 ||
                    coltype == TypeCode.Int64)
                {
                    keyfieldname = col.ColumnName;
                    break;
                }
            }
            string selectsql = string.Format(
                "select max([{0}]) from [{1}]",
                keyfieldname,
                tuser.Tables[0].TableName);

            object maxid = this.AdoTemplate
                .ExecuteScalar(CommandType.Text, selectsql);
            return (maxid != System.DBNull.Value) ? Convert.ToInt32(maxid) : 0;
            #endregion
        }

        public int GetCount<T>()
        {
            #region
            Type t = typeof(T);
            DataSet tuser = (DataSet)Activator.CreateInstance(t);

            DataColumn[] cols = SQLCreator.GetPrimaryKey(tuser);
            string keyfieldname = cols.Length > 0 ? cols[0].ColumnName : "*";

            string selectsql = string.Format(
                "select count([{0}]) as rowscount from [{1}]",
                keyfieldname,
                tuser.Tables[0].TableName);

            object count = this.AdoTemplate
                .ExecuteScalar(CommandType.Text, selectsql);

            if (SpringManager._EnableViewSelectCountSql)
                ExtConsole.WriteWithColor(selectsql);

            return (count != System.DBNull.Value) ? Convert.ToInt32(count) : 0;
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="willSaveDs"></param>
        /// <returns></returns>d
        private IDbParameters getSelectParams(
            DataSet willSaveDs)
        {
            #region
            DataTable willsavedt = willSaveDs.Tables[0];
            if (willsavedt.PrimaryKey.Length <= 0)
                Console.Write("欲保存的数据集没有主键，不能自动生成sql语句！");
            string keyfieldname = willSaveDs.Tables[0].PrimaryKey[0].ColumnName;
            IDbParameters dbparams = this.AdoTemplate.CreateDbParameters(); ;
            dbparams.Add(keyfieldname, DbType.String).Value = "";
            return dbparams;
            #endregion
        }
        /*
        private DbType getDbType(DataColumn primarykey0)
        { 
            if(primarykey0.DataType == )
        }
         * */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="action"></param>
        private void checkTablesCount(
            DataSet ds, Action action)
        {
            #region
            if (ds.Tables.Count == 0)
            {
                Console.WriteLine("exec savesql error: dataset hasn't any table!");
                return;
            }
            if (action != null)
                action();

            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="action"></param>
        private void checkTablesName(
            string tableName, Action action)
        {
            #region
            if (string.IsNullOrEmpty(tableName))
            {
                Console.WriteLine("exec savesql error: tablename is empty!");
                return;
            }
            if (action != null)
                action();
            #endregion
        }
        protected T GetDataSet<T>(
            QueryCondition condition)
        {
            return this.GetDataSet<T>(condition, null);
        }

        protected T GetDataSet<T>(
            QueryCondition condition,
            string sql)
        {
            #region
            if (condition == null)
                condition = new QueryCondition();

            T ds = default(T);
            Type t = typeof(T);
            ds = (T)Activator.CreateInstance(t);

            DataSet temp = ds as DataSet;
            sql = (string.IsNullOrEmpty(sql)) ? string.Format(
                "select * from [{0}]",
                temp.Tables[0].TableName) : sql;
            sql = SQLCreator.GetSelectSQL(sql, condition, temp);

            //Console.WriteLine("-------------------开始执行查询操作-------------------");
            //Console.WriteLine("SQL语句：[{0}]", sql);
            //Console.WriteLine("开始执行时刻：[{0}]", DateTime.Now);
            this.AdoTemplate.DataSetFill(temp,
                CommandType.Text, sql,
                new string[1] { temp.Tables[0].TableName }
                );

            if (SpringManager._EnableViewSelectSql)
                ExtConsole.WriteWithColor(sql);

            //Console.WriteLine("结束执行时刻：[{0}]", DateTime.Now);
            //Console.WriteLine("-------------------本次查询操作已完成-----------------");

            return ds;
            #endregion
        }
        protected void SetAdoTemplate(
    string providerName, string connectionString)
        {
            #region
            Spring.Data.Core.AdoTemplate adotemplate = new Spring.Data.Core.AdoTemplate();
            adotemplate.DbProvider = DbProviderFactory.GetDbProvider(providerName);
            adotemplate.DbProvider.ConnectionString = connectionString;
            base.AdoTemplate = adotemplate;
            #endregion
        }
        protected string GetConnection()
        {
            return base.AdoTemplate.DbProvider.ConnectionString;
        }

        protected int selectRecordCount(
            QueryCondition condition, string businessSql)
        {
            #region
            int totalcount = 0;
            string strcondition = condition._DBContainer.ToString();
            string sqlwhere = string.IsNullOrEmpty(strcondition) ? "" : " where " + strcondition;
            string sqlcount = string.Format("select count(*) from ({0}{1}) as x", businessSql, sqlwhere);
            totalcount = Convert.ToInt32(
                this.AdoTemplate.ExecuteScalar(
                CommandType.Text, sqlcount));

            if (SpringManager._EnableViewSelectCountSql)
                ExtConsole.WriteWithColor(sqlcount);

            return totalcount;
            #endregion
        }
        protected void fillDsByPage(
            DataSet sourceDs,
            QueryCondition condition,
            string businessSql)
        {
            #region
            string querysql = SQLCreator.GetSelectSQL(
                businessSql, condition, sourceDs);

            if (!string.IsNullOrEmpty(condition._TableName))
                this.AdoTemplate.DataSetFill(sourceDs,
                    CommandType.Text, querysql, new string[] { condition._TableName });
            else
                this.AdoTemplate.DataSetFill(sourceDs,
                CommandType.Text, querysql);

            if (SpringManager._EnableViewSelectSql)
                ExtConsole.WriteWithColor(querysql);

            #endregion
        }
    }
}
