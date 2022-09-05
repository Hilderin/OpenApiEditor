using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenApiEditor.OpenApi
{
    public class Response
    {
        public string description { get; set; }

        public Dictionary<string, Content> content { get; set; }

    }
}
