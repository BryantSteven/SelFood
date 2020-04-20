using SelFood.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {

           
            InitializeComponent();
        }

        async void RegisterBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Register());
        }

        private async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            var fbLogin = DependencyService.Get<IAuthService>();
            var token = await fbLogin.SignIn(EmailTxt.Text, PasswordTxt.Text);

            //if (string.IsNullOrWhiteSpace(token))
            //{
            //    await DisplayAlert("Alerta", "No se pudo iniciar sesión", "OK");
            //    return;
            //}

            await Navigation.PushModalAsync(new Home());
        }
    }
}