
using Foundation.Core;
using NormalDocumentOffice.Model;
using Catering.Service.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : IOfficeDocumentTempSegment
    {

        public string AddNewDocumentTempSegment(Model.EntityOfficeDocumentTempSegment tempSegment, string logonUserId,
            string logonUserIp)
        {

            #region
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentTempSegmentBusiness(logonUserId, logonUserIp).AddNewSegment(tempSegment);
            });
            #endregion
        }

        public string DeleteDocumentTempSegment(string segmentId, string logonUserId, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentTempSegmentBusiness(logonUserId, logonUserIp).DeleteSegment(segmentId);

            });
        }

        public string UpdateDocumentTempSegment(EntityOfficeDocumentTempSegment tempSegment, string logonUserId, string logonUserIp)
        {
            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentTempSegmentBusiness(logonUserId, logonUserIp).UpdateSegment(tempSegment);
            });
        }

        public string GetDocumentTempSegmentJson(EntityOfficeDocumentTempSegment tempSegment,
            int pageIndex, int pageSize, string logonUserId, string logonUserIp)
        {

            return JsonException.Wrap(() =>
            {
                return new OfficeDocumentTempSegmentBusiness(logonUserId, logonUserIp).GetJsonSegmentJson(pageIndex, pageSize, tempSegment);
            });
        }
    }
}
