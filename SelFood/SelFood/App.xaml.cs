using Xamarin.Forms;
using SelFood.Services;
using SelFood.Views;

namespace SelFood
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterD { get; set; }
        public static NavigationPage Navigator { get; internal set; }
        public static MasterView Master { get; internal set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Login();
            


        }

        
    }
}
