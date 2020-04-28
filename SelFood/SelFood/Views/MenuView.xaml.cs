using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();
        }
        async void IngredientesBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            
            await Navigation.PushModalAsync(new Ingredientes());
        }
        async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            
            await Navigation.PushModalAsync(new Login());
        }
        async void TruequeBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            
            await Navigation.PushModalAsync(new Trueque());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        /*  async void PerfilBtn_Clicked(System.Object sender, System.EventArgs e)
 {
     await Navigation.PushModalAsync(new Perfil());
 }*/
    }
}