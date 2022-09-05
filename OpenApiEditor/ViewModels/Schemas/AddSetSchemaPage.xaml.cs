using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace OpenApiEditor.ViewModels.Schemas
{
    /// <summary>
    /// Page d'édition des schémas
    /// </summary>
    public sealed partial class AddSetSchemaPage : Page
    {
        public AddSetSchemaViewModel ViewModel { get; set; } = new AddSetSchemaViewModel();

        public AddSetSchemaPage()
        {
            this.InitializeComponent();
            
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        { 
            ViewModel.ID = e.Parameter.ToString();

            await ViewModel.LoadAsync();

            base.OnNavigatedTo(e);
        }

        
    }
}
