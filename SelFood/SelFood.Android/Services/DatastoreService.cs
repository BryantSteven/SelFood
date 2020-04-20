using Firebase.Database;
using System;
using System.Threading.Tasks;

namespace SelFood.Droid.Services
{
    public class DatastoreService
    {
     
        public async Task<string> CargarIngrediente()
        {
            try
            {
                var database = FirebaseDatabase.Instance.GetReference("Ingredientes").Push();
                database.Child("Nombre").SetValue("Prueba");
                database.Child("Cantidad").SetValue("Prueba");
                 
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
            return string.Empty;
        }
    }
}