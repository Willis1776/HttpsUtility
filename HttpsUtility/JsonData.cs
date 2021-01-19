using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace HttpsUtility
{
    public class JsonData
    {
        public string ConvertToJson(EnergyData[] powerData)
        {
            var unitData = powerData.Skip(1).ToList();
            var jo = GetJsonObject(unitData, "Usage");
            return JsonConvert.SerializeObject(jo);
        }

        private JObject GetJsonObject(object rawData, string sectionName)
        {
            var jobject = new JObject {{sectionName, JToken.FromObject(rawData)}};
            return jobject;
        }
    }
}