using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace HimalayaDotnet
{
    public class HimalayaElement
    {
        public string Type { get; set; } = "";
        public string TagName { get; set; } = "";
        public List<HimalayaAttribute> Attributes { get; set; } = new List<HimalayaAttribute>();
        public List<HimalayaElement> Children { get; set; } = new List<HimalayaElement>();

        public static List<HimalayaElement> ParseJson(string json)
        {
            return JsonConvert.DeserializeObject<List<HimalayaElement>>(json);
        }
    }
}
