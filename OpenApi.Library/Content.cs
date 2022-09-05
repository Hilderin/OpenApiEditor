using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenApiEditor.OpenApi
{
    public class Content
    {
        public Schema schema { get; set; }

        public Dictionary<string, object> examples { get; set; }

    }
}
