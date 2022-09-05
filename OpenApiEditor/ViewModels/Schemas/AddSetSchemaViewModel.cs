using OpenApiEditor.OpenApi;
using OpenApiEditor.ViewModels.Main;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor.ViewModels.Schemas
{
    /// <summary>
    /// Modèle pour le schéma
    /// </summary>
    public class AddSetSchemaViewModel : ViewModelBase<string>
    {
        private Schema _schema;


        /// <summary>
        /// Titre du schéma
        /// </summary>
        public string Title
        {
            get => _schema.title;
            set
            {
                if (_schema.title != value)
                {
                    _schema.title = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Description du schéma
        /// </summary>
        public string Description
        {
            get => _schema.description;
            set
            {
                if (_schema.description != value)
                {
                    _schema.description = value;
                    RaisePropertyChanged();
                }
            }
        }



        /// <summary>
        /// Load les données
        /// </summary>
        public override async Task LoadAsync()
        {

            if (_schema != null)
                return;


            _schema = await AppHost.ApiRepository.GetSchema(this.ID);

            if (_schema == null)
                _schema = new Schema();


        }


    }
}
