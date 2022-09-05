using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor.OpenApi
{
    public class Property
    {

        public string type { get; set; }

        public string description { get; set; }

        public Property items { get; set; }

        public Dictionary<string, Property> properties { get; set; }

        public List<string> required { get; set; }

        public List<Property> allOf { get; set; }

        public List<Property> oneOf { get; set; }

        public List<Property> anyOf { get; set; }


    }
}
