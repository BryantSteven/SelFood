using System;
using System.Threading.Tasks;
using Firebase.Auth;
using SelFood.Services.Interfaces;

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
            catch (Exception)
            {

                throw;
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