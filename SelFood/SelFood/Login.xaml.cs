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
        async void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            /*var authServe = new AuthService();
            var token = await authService.login(Email.Text, Password.Text);
            if (!string.IsNullOrEmpty(token)) {
                Navigation.PushModalAsync(new HomePage());
                return;
            }
            System.Console.WriteLine("No se pudo iniciar sesión");*/
            System.Console.WriteLine(Email.Text);
            System.Console.WriteLine(Password.Text);
        }
    }
}