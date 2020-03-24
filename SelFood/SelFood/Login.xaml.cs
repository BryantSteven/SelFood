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
           /*
            var authserve = new authservice();
            var token = await authservice.login(email.text, password.text);
            if (!string.isnullorempty(token)) {
                navigation.pushmodalasync(new homepage());
                return;
            }
           
            System.console.writeline("no se pudo iniciar sesión");*/
            System.Console.WriteLine(Email.Text);
            System.Console.WriteLine(Password.Text);
        }
    }
}