using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenApiEditor.OpenApi
{
    public class Parameter
    {

        public string name { get; set; }

        public string @in { get; set; }

        public bool required { get; set; }

        public Schema schema { get; set; }

        public string description { get; set; }

        public bool allowEmptyValue { get; set; }

    }
}
