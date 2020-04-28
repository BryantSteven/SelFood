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
    public partial class master : ContentPage
    {
        public master()
        {
            InitializeComponent();
        }

        private async void btnIngredientes_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Ingredientes());
        }
       
        private async void btnTrueque_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Trueque());
        }

        private void btnSalir_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}