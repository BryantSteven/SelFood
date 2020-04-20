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
    public partial class Trueque : ContentPage
    {
        public Trueque()
        {
            InitializeComponent();
            var text1 = Producto.Text;
        }

        private void Btn_Buscar(object sender, EventArgs e)
        {
            var text1 = Producto.Text;
            

        }

        private void Btn_Post(object sender, EventArgs e)
        {
            var text2 = Post.Text;
        }

        async void GoBackBtn_Clicked(object sender, EventArgs e) {
            await Navigation.PopModalAsync();
        }
    }
}