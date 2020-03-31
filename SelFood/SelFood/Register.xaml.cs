using SelFood.Models;
using SelFood.Services.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {

            InitializeComponent();

        }
        private async void RegisterBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            var authService = DependencyService.Get<IAuthService>();
            var token = await authService.SignUp(new User { Email = EmailTxt.Text, Username = UsernameTxt.Text, Password = PasswordTxt.Text });

            if (string.IsNullOrWhiteSpace(token))
            {
                await DisplayAlert("Alerta", "No se pudo registrar el usuario", "OK");
                return;
            }

            await Navigation.PushModalAsync(new Home());
        }


        async void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
