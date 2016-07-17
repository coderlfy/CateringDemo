using Catering.Service.customize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Catering.Service.wcfhost
{
    public class Host
    {
        private static ServiceHost _host = null;

        public static void Start()
        {
            #region
            if (_host == null)
            {
                Uri uri = new Uri(CustomConfig._ServiceURL.ToString());
                _host = new ServiceHost(typeof(WCFService), uri);

                Type serverType = typeof(WCFService);
                Type[] iTypes = serverType.GetInterfaces();
                foreach (Type item in iTypes)
                {
                    object[] attInfo = item.GetCustomAttributes(typeof(ServiceContractAttribute), false);
                    attInfo = attInfo as ServiceContractAttribute[];
                    if (attInfo != null && attInfo.Length > 0)
                    {
                        addServiceEndPoint(item, item.Name);
                    }
                }

                CustomBehavior.Add(_host);
            }

            if (_host.State != CommunicationState.Opened)
            {
                _host.Open();
                Console.WriteLine("WCF Service开启成功！当前时间：{0}", DateTime.Now);

            }
            #endregion
        }

        private static void addServiceEndPoint(
            Type interfaceType, string interfaceName)
        {
            #region
            NetTcpBinding tcpbinding = new NetTcpBinding();
            
            NetTcpSecurity security = new NetTcpSecurity();
            security.Mode = SecurityMode.None;
            tcpbinding.Security = security;
            tcpbinding.MaxBufferSize = 2147483647;
            tcpbinding.MaxReceivedMessageSize = 2147483647;
            tcpbinding.ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas()
            {
                MaxArrayLength = 2147483647,
                MaxBytesPerRead = 2147483647,
                MaxDepth = 2147483647,
                MaxStringContentLength = 2147483647
            };
            _host.AddServiceEndpoint(interfaceType, tcpbinding, interfaceName);
            #endregion
        }

        public static void Stop()
        {
            #region
            if (_host != null)
            {
                if (_host.State == CommunicationState.Opened)
                {
                    _host.Close();
                    Console.WriteLine("WCF Service停止运行！当前时间：{0}", DateTime.Now);
                }
                _host = null;
            }
            #endregion
        }
    }
}
