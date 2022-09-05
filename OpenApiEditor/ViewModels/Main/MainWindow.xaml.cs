using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Animation;
using OpenApiEditor.ViewModels.Schemas;

namespace OpenApiEditor.ViewModels.Main
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; private set; }


        /// <summary>
        /// Constructeur
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            this.Title = "Open Api Editor";

            //IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            //WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            //AppWindow appWindow = AppWindow.GetFromWindowId(myWndId);
            //appWindow.SetIcon((IconId)0);

            ViewModel = new MainViewModel();
            //root.DataContext = ViewModel;
            root.Loaded += Root_Loaded;
        }

        private async void Root_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadAsync();
        }

        /// <summary>
        /// Click sur un élément du side bar
        /// </summary>
        private void SideBarItemsListView_SelectionChanged(object sender, Microsoft.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {

            MainSidebarItemModel selectedItem = (MainSidebarItemModel)SideBarItemsListView.SelectedItem;
            if (selectedItem != null)
                MainFrame.Navigate(typeof(AddSetSchemaPage), selectedItem.Name, new EntranceNavigationTransitionInfo());

        }



        //private void myButton_Click(object sender, RoutedEventArgs e)
        //{
        //    myButton.Content = "Clicked";
        //}
    }
}
