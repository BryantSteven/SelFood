using SelFood.Models;
using SelFood.Services.Interfaces;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : MasterDetailPage
    {
        //private IList<Product> _products;

        public Home()
        {
            InitializeComponent();
            this.Master = new master();
            this.Detail = new NavigationPage(new detail());

            App.MasterD = this;
          
        }

        async void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            //MessagingCenter.Send(this, "AddProduct", ProductsList);
            //var name = ProductEn.Text;
            //var Quantity = QuantityEn.Text;
            //ProductsList product = new ProductsList();
            //LvProductsList.ItemsSource = product._product;
            

        }



        private async void TruequeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Trueque());
        }
    }

  
}
