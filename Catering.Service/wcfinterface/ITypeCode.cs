using iCat.Catering.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Catering.Service
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    interface ITypeCode
    {
        [OperationContract]
        string AddTypeCode(EntityTypeCode typeCode,
             string logonUser, string logonUserIp);
    }
}
