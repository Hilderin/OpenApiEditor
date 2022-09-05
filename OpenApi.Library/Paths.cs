using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor.OpenApi
{
    public class Paths
    {
        public string description { get; set; }

        public Path get { get; set; }
        public Path put { get; set; }
        public Path post { get; set; }
        public Path delete { get; set; }

        public List<Parameter> parameters { get; set; }

    }
}
