
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Login_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }
        async void RegisterBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Register());
        }
        
    }
}