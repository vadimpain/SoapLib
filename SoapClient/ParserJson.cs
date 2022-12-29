using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace SoapClient
{
    public class ParserJson
    {
        public static JsonSettings GetJsonSettings(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                var reader = streamReader.ReadToEnd();
                var jsonSettings = JsonConvert.DeserializeObject<JsonSettings>(reader);

                return jsonSettings;
            }
        }

    }
}
