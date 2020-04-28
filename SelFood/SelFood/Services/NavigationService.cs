using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SelFood.Views;

namespace SelFood.Services
{

    public class NavigationService
    {
        public void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                case "Login":
                    Application.Current.MainPage = new NavigationPage(new Login());
                    break;
                case "MasterView":
                    Application.Current.MainPage = new MasterView();
                    break;
            }
        }

        public async Task NavigateOnMaster(string pageName)
        {
           
            switch (pageName)
            {
                case "CategoriesView":
                    await App.Navigator.PushAsync(
                        new Ingredientes());
                    break;
                case "ProductsView":
                    await App.Navigator.PushAsync(
                        new Trueque());
                    break;
                case "NewCategoryView":
                    await App.Navigator.PushAsync(
                        new Login());
                    break;

            }
        }

        public async Task NavigateOnLogin(string pageName)
        {
            switch (pageName)
            {
                case "NewCustomerView":
                    await Application.Current.MainPage.Navigation.PushAsync(
                        new Login());
                    break;
            }
        }

        public async Task BackOnMaster()
        {
            await App.Navigator.PopAsync();
        }

        public async Task BackOnLogin()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}

