using System;
using System.Threading.Tasks;
using Firebase.Auth;
using SelFood.Droid.Services;
using SelFood.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(AuthService))]
namespace SelFood.Droid.Services
{
    public class AuthService : IAuthService
    {
        //public AuthService() {
        //    var instance = FirebaseAuth.GetInstance(app);
        //    if (instance == null)
        //    {
        //        instance = new FirebaseAuth(app);
        //    }
        //}
        public async Task<string> SignIn(string email, string password)
        {
            try
            {
                var prueba = FirebaseAuth.Instance;

                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (Exception e)
            {

                return string.Empty;
            }
        }

        public async Task<string> SignUp(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}