using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenApiEditor.OpenApi
{
    public class Schema : Property
    {

        public string title { get; set; }

        [YamlMember(Alias = "$ref")]
        public string reference { get; set; }

        //public string type { get; set; }

        //public string description { get; set; }

        public List<string> @enum { get; set; }

        public string example { get; set; }

        public List<Dictionary<string, object>> examples { get; set; }

        [YamlMember(Alias = "x-examples")]
        public Dictionary<string, object> xexamples { get; set; }

        public string format { get; set; }

        public bool? nullable { get; set; }

        //public Dictionary<string, Property> properties { get; set; }

        //public List<string> required { get; set; }
    }
}
