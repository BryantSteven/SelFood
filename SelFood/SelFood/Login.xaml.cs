using SelFood.Services.Interfaces;

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
        async void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
        {

            DependencyService.Get<IAuthService>();

            var authservice = DependencyService.Get<IAuthService>();


            var token = await  authservice.SignIn(Email.Text, Password.Text);

            if (token == true)
            {
             await Navigation.PushModalAsync(new Home()); //New {Pagina donde va a llevar despues de login}
                return;
            }
            else { 

            System.Console.WriteLine("no se pudo iniciar sesión");
                }

            System.Console.WriteLine(Email.Text);
            System.Console.WriteLine(Password.Text);
        }
    }
}