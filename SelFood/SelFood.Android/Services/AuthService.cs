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
        public string getAuthKey()
        {
            throw new NotImplementedException();
        }
         // Comprobar si el usuario ya esta logeado
        public bool IsUserSigned()
        {
            var user = Firebase.Auth.FirebaseAuth.GetInstance(MainActivity.app).CurrentUser;
            var signedIn = user != null;
            return signedIn;
        }
        // Salir de la aplicacion
        public async Task<bool> Logout()
        {
            try
            {
                Firebase.Auth.FirebaseAuth.GetInstance(MainActivity.app).SignOut();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
         //Fin de salir de la aplicacion

         // Login con contraseña y email
        public async Task<bool> SignIn(string email, string password)
        {
            try
            {

                await Firebase.Auth.FirebaseAuth.GetInstance(MainActivity.app).SignInWithEmailAndPasswordAsync(email, password);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
         //Fin login contraseña y email.

        public void SignInWithGoogle()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SignInWithGoogle(string token)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SignUp(string email, string password)
        {
            throw new NotImplementedException();
        }

    }
}