using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Foundation.Core
{
    public class JsonHelperV2
    {
        private static JsonSerializerSettings _jSettingIgnoreNULL = null;
        public static JsonSerializerSettings _JsonSettingIgnoreNULL
        {
            get {
                if (_jSettingIgnoreNULL == null)
                {
                    _jSettingIgnoreNULL = new JsonSerializerSettings();
                    _jSettingIgnoreNULL.NullValueHandling = NullValueHandling.Ignore;
                }

                return _jSettingIgnoreNULL;
            }
        }

        public static string GetJson(
            object jsonObject)
        {
            var jSetting = new JsonSerializerSettings();
            jSetting.DefaultValueHandling = DefaultValueHandling.Ignore;
            jSetting.NullValueHandling = NullValueHandling.Ignore;
            return Format(JsonConvert.SerializeObject(jsonObject, jSetting));
        }

        private static string Format(
            string json)
        {
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(json);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return json;
            }         

        }
    }
}
