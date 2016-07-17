using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catering.Service
{
    partial class WCFService : ITypeCode
    {

        public string AddTypeCode(
            iCat.Catering.Model.EntityTypeCode typeCode, 
            string logonUser, 
            string logonUserIp)
        {
            #region
            throw new NotImplementedException();
            #endregion
        }


        public string GetTypeCodes(
            iCat.Catering.Model.EntityTypeCode typeCode)
        {
            #region
            return new TypeCodeBusiness().GetJson(typeCode);
            #endregion
        }
    }
}
