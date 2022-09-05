using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace OpenApiEditor.OpenApi
{
    public class OpenApiReader
    {

        /// <summary>
        /// Lit la structure OpenApi sur le disque
        /// </summary>
        public Api Read(string path)
        {
            var deserializer = new DeserializerBuilder()
                                //.WithNamingConvention(CamelCaseNamingConvention.Instance)
                                .IgnoreUnmatchedProperties()
                                .Build();

            using (StreamReader streamReader = new StreamReader(path))
            {
                return deserializer.Deserialize<Api>(streamReader);
            }
        }
    }
}
