using Archive.DBMapping;
using LuceneNetHelper.Conditions;
using LuceneNetHelper.Search;
using NormalDocumentOffice.DBMapping;
using NormalDocumentOffice.Model;
using Catering.Service.business;
using Catering.Service.business.Index;
using Catering.Service.Index;
using Catering.Service.Index.Archive;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentIndex
    {
        private LuceneNetHelper.LuceneNetManager indexServer = new LuceneNetHelper.LuceneNetManager();
        private IndexHelperGroup indexGroup = new IndexHelperGroup();

        #region 未审核
        public string IndexQueryFileMoveData(LuceneNetHelper.Conditions.QueryCondition condition)
        {
            string json = string.Empty;
            try
            {
                MoveRecordIndexBusiness.SetCommonQueryCondition(condition);
                if (string.IsNullOrWhiteSpace(condition.QueryKey))
                {
                    json = "{\"success\":'false',\"msg\":'" + "查询关键字不能使空格" + "'}";
                    return json;
                }
                indexServer.IndexDataHelper = indexGroup;
                SearchResult result = indexServer.Search(condition, QueryMoveProcDataById, new HightLightCondition());

                #region 查询结果处理
                string queryTotalDocs = "0";//组的总个数 //分页的总数据个数
                string qeryTotalProcFiles = "0";//总过程稿个数 
                Foundation.Core.JsonHelper jsonhlp = new Foundation.Core.JsonHelper();
                if (result != null)
                {
                    DataTable dt = result.Data as DataTable;
                    if (dt != null)
                    {
                        jsonhlp.GetTopicsJson(dt);
                        PageResult groupResult = result.PageResult;
                        queryTotalDocs = groupResult.TotalPage.ToString();
                        qeryTotalProcFiles = groupResult.TotalCount.ToString();

                    }
                }
                #endregion

                jsonhlp.AddObjectToJson("success", "true");
                jsonhlp.AddObjectToJson("QueryTotalProcFiles", qeryTotalProcFiles);
                jsonhlp.AddObjectToJson("QueryTotalDocs", queryTotalDocs);
                json = jsonhlp.ToString();
            }
            catch (Exception ex)
            {
                json = "{\"success\":'false',\"msg\":'" + ex.Message + "'}";
            }
            return json;
        }

        private SearchResult QueryMoveProcDataById(SearchResult result)
        {
            if (result == null)
            {
                return result;
            }
            List<string> ids = result.Data as List<string>;
            if (ids != null && ids.Count > 0)
            {
                DataSet ds = IndexOpery.GetOfficeDocumentMoveProcFileDataByIDs(ids) as DataSet;
                if (ds != null)
                {
                    result.Data = ds.Tables[0];
                }
                result.Tag = ds;
            }
            else
            {
                result.Data = null;
            }
            return result;
        }
        #endregion

        public string IndexQueryFileHistoryData(LuceneNetHelper.Conditions.QueryCondition condition)
        {
            string json = string.Empty;
            try
            {
                SearchResult result = null;
                HistoryProcFileIndexBusiness.SetCommonQueryCondition(condition);
                if (string.IsNullOrWhiteSpace(condition.QueryKey))
                {
                    json = Foundation.Core.JsonHelper.GetErrorJson("查询关键字不能为空");
                    // json = "{\"success\":'false',\"msg\":'" + "查询关键字不能使空格" + "'}";
                    return json;
                }
                indexServer.IndexDataHelper = indexGroup;
                result = indexServer.Search(condition, new HightLightCondition());

                #region 两步查询
                //condition.KeyField = OfficeDocumentHistoryProcFileMapping.docId;
                //condition.IsNeedDBMethord = true;
                //string queryKey = condition.QueryKey;
                //condition.QueryKey = null;
                //result = indexServer.Search(condition);
                ////先查询人对应的DocId
                //List<string> id = result.Data as List<string>;
                //if (id != null && id.Count > 0)
                //{
                //    string idsStr = string.Empty;
                //    idsStr += "(";
                //    for (int i = 0; i < id.Count; i++)
                //    {
                //        idsStr += "(docId:" + id[i] + ") ";
                //    }
                //    idsStr += ")";
                //    condition.ParamsFields.Add("secondQueryKey", idsStr);
                //    condition.KeyField = OfficeDocumentHistoryProcFileMapping.procFileId;
                //    condition.IsNeedDBMethord = false;
                //    condition.QueryKey = queryKey;
                //    result = indexServer.Search(condition, new HightLightCondition());
                //}
                #endregion

                #region 查询结果处理
                string queryTotalDocs = "0";//组的总个数 //分页的总数据个数
                string qeryTotalProcFiles = "0";//总过程稿个数
                Foundation.Core.JsonHelper jsonhlp = new Foundation.Core.JsonHelper();

                if (result != null)
                {
                    DataTable dt = result.Data as DataTable;
                    if (dt != null)
                    {
                        dt.Columns.Add("newFileContent");
                        SetTableInfo(dt, condition.QueryFields);

                        jsonhlp.GetTopicsJson(dt);
                        PageResult groupResult = result.PageResult;
                        queryTotalDocs = groupResult.TotalPage.ToString();
                        qeryTotalProcFiles = groupResult.TotalCount.ToString();
                    }
                }
                #endregion

                jsonhlp.AddObjectToJson("success", "true");
                jsonhlp.AddObjectToJson("total", qeryTotalProcFiles);
                //  jsonhlp.AddObjectToJson("totalPage", queryTotalDocs);
                json = jsonhlp.ToString();

            }
            catch (Exception ex)
            {
                json = Foundation.Core.JsonHelper.GetErrorJson(ex.Message);
            }
            return json;
        }

        #region 未定稿
        public string IndexGroupQueryData(GroupQueryCondition condition)
        {
            return IndexQueryData(condition);
        }
        public string IndexQueryData(LuceneNetHelper.Conditions.QueryCondition condition)
        {
            string json = string.Empty;
            try
            {
                OfficeDocumentRealIndexBusiness.SetCommonQueryCondition(condition);

                if (string.IsNullOrWhiteSpace(condition.QueryKey))
                {
                    json = Foundation.Core.JsonHelper.GetErrorJson("查询关键字不能为空");
                    return json;
                }
                indexServer.IndexDataHelper = indexGroup;
                SearchResult result = indexServer.Search(condition, QueryRealProcDataById, new HightLightCondition());

                #region 查询结果处理
                string queryTotalDocs = "0";//组的总个数 //分页的总数据个数
                string qeryTotalProcFiles = "0";//总过程稿个数
                string currentPageProcFiles = "0";//当前页过程稿个数
                Foundation.Core.JsonHelper jsonhlp = new Foundation.Core.JsonHelper();
                if (result != null)
                {
                    NormalDocumentOffice.Model.ExtOfficeDocumentRealProcFileData procfilesdata = result.Tag
                   as NormalDocumentOffice.Model.ExtOfficeDocumentRealProcFileData;
                    if (procfilesdata != null)
                    {
                        jsonhlp.GetTopicsJson(procfilesdata._ProcFilesData.Tables[0]);
                        GroupPageResult groupResult = result.PageResult as GroupPageResult;
                        queryTotalDocs = groupResult.TotalPage.ToString();
                        qeryTotalProcFiles = groupResult.TotalCount.ToString();
                        currentPageProcFiles = groupResult.GroupTotalCount.ToString();
                    }
                }

                #endregion

                jsonhlp.AddObjectToJson("success", "true");
                jsonhlp.AddObjectToJson("QueryTotalProcFiles", qeryTotalProcFiles);
                jsonhlp.AddObjectToJson("QueryCurrentPageProcFiles", currentPageProcFiles);
                jsonhlp.AddObjectToJson("QueryTotalDocs", queryTotalDocs);
                json = jsonhlp.ToString();

                #region
                //jsonhlp.GetTopicsJson(result.Data as DataTable);
                //jsonhlp.AddObjectToJson("success", "true");
                //jsonhlp.AddObjectToJson("QueryTotalDocs", result.TotalRowCount.ToString());
                //jsonhlp.AddObjectToJson("QueryTotalProcFiles", result.TotalRowCount.ToString());
                //jsonhlp.AddObjectToJson("QueryCurrentPageProcFiles", result.TotalRowCount.ToString());
                #endregion
            }
            catch (Exception ex)
            {
                json = Foundation.Core.JsonHelper.GetErrorJson(ex.Message);
            }
            return json;
        }

        private SearchResult QueryRealProcDataById(SearchResult result)
        {
            if (result == null)
            {
                return result;
            }
            bool isGroup = true;

            GroupPageResult groupResult = result.PageResult as GroupPageResult;
            if (groupResult != null)
            {
                isGroup = groupResult.IsReturnGroupField;
            }
            List<string> ids = result.Data as List<string>;
            ExtOfficeDocumentRealProcFileData data = IndexOpery.GetOfficeDocumentRealProcFileDataByIDs(ids, isGroup)
                as ExtOfficeDocumentRealProcFileData;
            if (data != null)
            {
                result.Data = data._ProcFilesData.Tables[0];
            }
            result.Tag = data;
            return result;
        }
        #endregion


        private void SetTableInfo(DataTable dt, string[] fields)
        {
            string fileContentField = "newFileContent";
            if (dt == null || dt.Rows.Count == 0 || !dt.Columns.Contains(fileContentField))
            {
                return;
            }
            if (fields.Contains(fileContentField))
            {
                //单独列
                foreach (DataRow dr in dt.Rows)
                {
                    bool isFind = false;//其他列是否包含 
                    foreach (string item in fields)
                    {
                        object fileObj = dr[item];
                        if (fileObj != null)
                        {
                            isFind = fileObj.ToString().Contains("</b></font>");
                            if (isFind)
                            {
                                break;
                            }
                        }
                    }
                    if (!isFind)
                    {
                        dr[fileContentField] = "是";
                    }
                }
            }

            #region 判断
            //if (fields.Contains(fileContentField))
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        bool isFind = false;
            //        object fileContentObj = dr[fileContentField];
            //        if (fileContentObj != null)
            //        {
            //            isFind = fileContentObj.ToString().Contains("</b></font>");
            //        }
            //        if (isFind)
            //        {
            //            dr[fileContentField] = "包含关键字";
            //        }
            //    }
            //}
            #endregion
        }

        LuceneNetHelper.Index.HightLightHelper hightLightHelper = new LuceneNetHelper.Index.HightLightHelper();
        public string SearchIndexData(QueryCondition condition)
        {
            string json = string.Empty;
            try
            {
                SearchResult result = null;

                if (string.IsNullOrWhiteSpace(condition.QueryKey))
                {
                    json = Foundation.Core.JsonHelper.GetErrorJson("查询关键字不能为空");
                    return json;
                }
                List<string> displayFields = new List<string>();
                displayFields.Add("title");
                displayFields.Add("newFileContent");
                displayFields.Add("updateTime");
                displayFields.Add("procFileId");


                string searchKey = "searchType";
                string searchType = string.Empty;
                if (condition.ParamsFields != null && condition.ParamsFields.Keys.Contains(searchKey))
                {
                    object obj = condition.ParamsFields[searchKey];
                    if (obj != null)
                    {
                        searchType = obj.ToString().ToLower();
                    }
                    if (searchType.Equals("document"))
                    {
                        HistoryProcFileIndexBusiness.SetCommonQueryCondition(condition);
                        indexServer.IndexDataHelper = indexGroup;
                        condition.QueryFields = new string[] { "title", "newFileContent" };

                    }
                    else if (searchType.Equals("archive"))
                    {
                        condition.TableKey = "tableID";
                        condition.TableValue = ArchiveRealFileMapping.ArchiveRealFile;
                        if (condition.ParamsFields != null)
                        {
                            if (condition.ParamsFields.Keys.Contains("userId"))
                            {
                                object userObj = condition.ParamsFields["userId"];
                                if (userObj != null)
                                {
                                    condition.ParamsFields["userId"] = new string[] { userObj.ToString().ToUpper() };
                                }
                            }
                            condition.ParamsFields.Add("userIdFieldName", "readUser");
                        }
                        condition.SortField = ArchiveRealFileMapping.updateTime;
                        condition.Desc = true;
                        condition.IndexPath = ArchiveIndexManager.indexPath;
                        condition.QueryFields = ArchiveIndexManager.analyzedFileds;
                        condition.IsNeedDBMethord = false;
                        condition.QueryFieldRelation = FieldRelation.Or;
                        indexServer.IndexDataHelper = new ArchiveIndexHelper();
                        displayFields.Add("fileTypeName");
                    }
                }
                if (string.IsNullOrEmpty(searchType))
                {
                    json = Foundation.Core.JsonHelper.GetErrorJson("非法查询");
                    return json;
                }

                condition.DisplayFields = displayFields.ToArray();
                result = indexServer.Search(condition);

                #region 查询结果处理
                string queryTotalDocs = "0";//组的总个数 //分页的总数据个数
                string qeryTotalProcFiles = "0";//总过程稿个数
                Foundation.Core.JsonHelper jsonhlp = new Foundation.Core.JsonHelper();

                if (result != null)
                {
                    DataTable dt = result.Data as DataTable;
                    if (dt != null)
                    {
                        hightLightHelper.HightLightData(dt, condition, 300);
                        if (!displayFields.Contains("fileTypeName"))
                        {
                            dt.Columns.Add("fileTypeName");
                            foreach (DataRow dr in dt.Rows)
                            {
                                dr["fileTypeName"] = ".doc";
                            }
                        }
                        jsonhlp.GetTopicsJson(dt);
                        PageResult groupResult = result.PageResult;
                        queryTotalDocs = groupResult.TotalPage.ToString();
                        qeryTotalProcFiles = groupResult.TotalCount.ToString();
                    }
                }
                #endregion

                jsonhlp.AddObjectToJson("success", "true");
                jsonhlp.AddObjectToJson("total", qeryTotalProcFiles);
                json = jsonhlp.ToString();

            }
            catch (Exception ex)
            {
                json = Foundation.Core.JsonHelper.GetErrorJson(ex.Message);
            }
            return json;
        }
    }
}
