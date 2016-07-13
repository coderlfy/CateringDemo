using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Catering.Service
{
    class CustomBehavior
    {
        public static void Add(ServiceHost host)
        {
            #region
            ServiceMetadataBehavior smb = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (smb == null)
                host.Description.Behaviors.Add(new ServiceMetadataBehavior());

            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
            #endregion
        }
    }
}
