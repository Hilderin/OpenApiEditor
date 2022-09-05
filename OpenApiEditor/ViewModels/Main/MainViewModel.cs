using OpenApiEditor.OpenApi;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace OpenApiEditor.ViewModels.Main
{
    /// <summary>
    /// ViewModel de la main window
    /// </summary>
    public class MainViewModel: ViewModelBase<string>
    {
       
        private Api _api = null;

        public ObservableCollection<MainSidebarItemModel> SidebarItems { get; } = new ObservableCollection<MainSidebarItemModel>();


        public MainViewModel()
        {
            
        }

        /// <summary>
        /// Load les données
        /// </summary>
        public override async Task LoadAsync()
        {

            if (_api != null)
                return;


            _api = await AppHost.ApiRepository.GetApiAsync();


            if (_api?.components?.schemas != null)
            {
                foreach (KeyValuePair<string, Schema> kv in _api.components.schemas.OrderBy(skv => skv.Key))
                {
                    this.SidebarItems.Add(new MainSidebarItemModel(kv.Key, kv.Key, MainSidebarItemType.Schema));
                    
                }
            }

        }
    }
}
