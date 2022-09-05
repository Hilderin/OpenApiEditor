using OpenApiEditor.OpenApi;
using OpenApiEditor.ViewModels.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor.Repositories
{
    public class ApiRepository
    {

        private Api _api = null;


        public ApiRepository()
        {

        }

        /// <summary>
        /// Permet d'aller chercher l'api sur le disque
        /// </summary>
        public async Task<Api> GetApiAsync()
        {

            if (_api == null)
            {
                _api = await Task.Factory.StartNew(() =>
                {
                    OpenApiReader reader = new OpenApiReader();

                    return reader.Read(@"C:\Users\si_z_\OneDrive\Bureau\documentation-api\Stages\reference\stages-api.yaml");
                });
            }


            return _api;


        }

        /// <summary>
        /// Permet d'aller chercher un schéma par son nom
        /// </summary>
        public async Task<Schema> GetSchema(string name)
        {
            Api api = await GetApiAsync();

            Schema schema = null;

            if (api?.components?.schemas != null)
            {
                _api.components.schemas.TryGetValue(name, out schema);
            }

            return schema;

        }



    }
}
