using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Foundation.Core
{
    public class XMLUtility
    {
        public string ConvertDataTableToXML(
            DataTable xmlDs)
        {
            #region
            using (MemoryStream stream = new MemoryStream())
            {
                using (XmlTextWriter writer = new XmlTextWriter(stream, Encoding.UTF8))
                {
                    xmlDs.WriteXml(writer, XmlWriteMode.IgnoreSchema);
                    
                    long count = stream.Length;
                    byte[] arr = new byte[count];
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.Read(arr, 0, (int)count);
                    string xml = Encoding.UTF8.GetString(arr);
                    xml = xml.Substring(1, xml.Length - 1);
                    return xml;
                }
            }
            #endregion
        }

        public DataSet ConvertXMLToDataSet(
            string xmlData)
        {
            #region
            using (StringReader stream = new StringReader(xmlData)) { 
                using(XmlTextReader reader = new XmlTextReader(stream))
                { 
                    DataSet ds = new DataSet();
                    ds.ReadXml(reader);
                    return ds;
                }
            }
            #endregion
        }
    }
}
