using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenApiEditor.OpenApi
{
    public class Path
    {

        public string summary { get; set; }


        public string operationId { get; set; }

        public string description { get; set; }


        public List<string> tags { get; set; }

        public Dictionary<string, Response> responses { get; set; }


        public Request requestBody { get; set; }

    }
}
