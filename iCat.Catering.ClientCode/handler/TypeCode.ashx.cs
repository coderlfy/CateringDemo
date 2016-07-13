
/****************************************
***生成器版本：V2.0
***创建人：lifengyan
***生成时间：2016-07-12 23:42:15
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using iCat.Catering.DBMapping;
using iCat.Catering.Client.WCFService;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace iCat.Catering.Client
{
    public class TypeCode : PageHandlerBase, IHttpHandler
    {
        private EntityTypeCode _typeCode = new EntityTypeCode();
        private TypeCodeClient _typeCodeClient = new TypeCodeClient();

        /// <summary>
        /// 截取页面传来的各参数。
        /// </summary>
        /// <param name="request"></param>
        private void getPostParams(
            HttpRequest request)
        {
            #region
            NameValueCollection paramsarray = request.Params;
			this._typeCode.c_ID = paramsarray[TypeCodeMapping.c_ID];
			this._typeCode.PType = paramsarray[TypeCodeMapping.PType];
			this._typeCode.name = paramsarray[TypeCodeMapping.name];
			this._typeCode.writeTime = paramsarray[TypeCodeMapping.writeTime];
			this._typeCode.writeIP = paramsarray[TypeCodeMapping.writeIP];
            #endregion
        }
        /// <summary>
        /// 获取分页列表信息
        /// </summary>
        /// <param name="json"></param>
        private void ActionList(
            ref string json)
        {
            #region
            GridParamsByPage p = base.GetPageParams();
            //json = this._typeCodeClient.GetTypeCodeByPage(
            //    this.SessionUserId, this.SessionUserIp, 
            //    p.PageIndex, p.PageSize, this._typeCode);
            #endregion
        }
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <param name="json"></param>
        private void ActionGetAll(
            ref string json)
        {
            #region
            //json = this._typeCodeClient.GetJsonByAll();
            #endregion
        }
        /// <summary>
        /// 添加新记录
        /// </summary>
        /// <param name="json"></param>
        private void ActionAddNew(
            ref string json)
        {
            #region
            //json = this._typeCodeClient.AddTypeCode(
            //  this.SessionUserId, this.SessionUserIp, 
            //  imapplyforgroup);
            #endregion
        }
        /// <summary>
        /// 编辑指定行的记录
        /// </summary>
        /// <param name="json"></param>
        private void ActionEdit(
            ref string json)
        {
            #region
            #endregion
        }
        /// <summary>
        /// 删除指定记录
        /// </summary>
        /// <param name="json"></param>
        private void ActionDelete(
            ref string json)
        {
            #region
            #endregion
        }

        /// <summary>
        /// 处理请求的过程，当前台页面调用本文件时，自动执行本方法。
        /// </summary>
        /// <param name="context">上下文</param>
        public void ProcessRequest(
            HttpContext context)
        {
            #region
            HttpRequest request = context.Request;
            String action = request.QueryString["action"];
            String json = "";

            this.getPostParams(request);

            switch (action)
            {
                case "list":
                    this.ActionList(ref json);
                    break;
                case "viewall":
                    this.ActionGetAll(ref json);
                    break;
                case "add":
                    this.ActionAddNew(ref json);
                    break;
                case "update":
                    this.ActionEdit(ref json);
                    break;
                case "delete":
                    this.ActionDelete(ref json);
                    break;
                default:
                    break;
            }
            context.Response.ContentType = "text/json";
            context.Response.Write(json);
            #endregion
        }

        public bool IsReusable
        {
            #region
            get
            {
                return false;
            }
            #endregion
        }
    }
}

