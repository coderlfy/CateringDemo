using Foundation.Core;
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
    partial class WCFService : IArchiveIndex
    {
        public string QueryArchiveIndexData(string logonUser, string logonUserIp,
            LuceneNetHelper.Conditions.QueryCondition condition,
            Dictionary<string, string> manyField)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveIndexBusiness(logonUser, logonUserIp).SearchIndex(condition, manyField);

            });
        }
        public string QueryHistoryArchiveIndexData(string logonUser, string logonUserIp, LuceneNetHelper.Conditions.QueryCondition condition, Dictionary<string, string> manyField)
        {
            return JsonException.Wrap(() =>
            {
                return new ArchiveHistoryIndexBusiness(logonUser, logonUserIp).SearchIndex(condition, manyField);

            });
        }
    }
}
