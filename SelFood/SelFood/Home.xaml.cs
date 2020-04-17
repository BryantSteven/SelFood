using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            
            InitializeComponent();
        }

        async void GoBackBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();


        }

         async void Butt_Trueque_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Trueque());
        }
        ////async void Butt_ingresarPapa_Clicked(object sender, EventArgs e)
        ////{
        ////    
        ////    await firebase
        ////    .Child("Ingredients")
        ////    .PostAsync(new (ingredient) { ingredientId = 1, Name = papa });
        ////}
       
        //public async Task Addingredient(string ingredient)
        //{

        //    await firebase.Child("Ingredients").PostAsync(new ingredient() { IngredientId = new IngredientId, Name = ingredient });
              
              

        }
}