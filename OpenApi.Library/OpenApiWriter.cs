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
    public class OpenApiWriter
    {

        /// <summary>
        /// Écrit la structure OpenApi sur le disque
        /// </summary>
        public void Write(string path, Api api)
        {
            var serializer = new SerializerBuilder()
                                //.WithNamingConvention(CamelCaseNamingConvention.Instance)
                                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                                .Build();

            using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.UTF8))
            {
                serializer.Serialize(streamWriter, api);
            }
        }
    }
}
