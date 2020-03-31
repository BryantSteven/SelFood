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
    public partial class Register : ContentPage
    {
        public Register()
        {

            InitializeComponent();

        }
        async void RegisterBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Home());

            var authservice = DependencyService.Get<IAuthService>();


            var token = await authservice.SignUp(Email.Text, Password.Text);
            if (token == true)
            {
                await Navigation.PushModalAsync(new Home()); //New {Pagina donde va a llevar despues de login}
                return;
            }else {

            System.Console.WriteLine("no se pudo registrar nuevo usuario");
            }

            System.Console.WriteLine(Email.Text);
            System.Console.WriteLine(Password.Text);
        }

    
        async void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();


        }
    }
}