using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenApiEditor.OpenApi
{
    public class Server
    {

        public string url { get; set; }

        public string description { get; set; }
    }
}
