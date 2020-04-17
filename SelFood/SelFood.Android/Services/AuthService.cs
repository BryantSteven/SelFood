using System;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Database;
using SelFood.Droid.Services;
using SelFood.Models;
using SelFood.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(AuthService))]
namespace SelFood.Droid.Services
{
    public class AuthService : IAuthService
    {
        public async Task<string> SignIn(string email, string password)
        {   
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
            return string.Empty;
        }

        public async Task<string> SignUp(User user)
        {
            try
            {
                var registeredUser = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(user.Email, user.Password);
                var token = await registeredUser.User.GetIdTokenAsync(false);
                var database = FirebaseDatabase.Instance.GetReference("usuarios").Push();
                database.Child("UserId").SetValue(registeredUser.User.Uid);
                database.Child("Username").SetValue(user.Username);
                return token.Token;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
            return string.Empty;
        }
        //public async task<string> AddIngredient(Ingrediente ingrediente)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception f)
        //    {

        //        Console.WriteLine(($"Error: {f}");
        //    }
        //    return string.Empty;
        //}
    }
}
