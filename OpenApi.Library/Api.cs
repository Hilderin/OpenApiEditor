using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor.OpenApi
{
    public class Api
    {
        public string openapi { get; set; }

        public Info info { get; set; }

        public List<Server> servers { get; set; }

        public Components components { get; set; }

        public Dictionary<string, Paths> paths { get; set; }


    }
}
