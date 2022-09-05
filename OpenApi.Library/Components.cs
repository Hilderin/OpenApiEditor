using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor.OpenApi
{
    public class Components
    {

        public Dictionary<string, Schema> schemas { get; set; }

        public Dictionary<string, Parameter> parameters { get; set; }


    }
}
