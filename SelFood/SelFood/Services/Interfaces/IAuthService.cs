using System;
using System.Threading.Tasks;

namespace SelFood.Services.Interfaces
{
    public interface IAuthService
    {
        String getAuthKey();
        bool IsUserSigned();
        Task<bool> SignUp(String email, String password);
        Task<bool> SignIn(String email, String password);
        void SignInWithGoogle();
        Task<bool> SignInWithGoogle(String token);
        Task<bool> Logout();
    }

    //Task<string> SignUp(string email, string password);
    //Task<string> SignIn(string email, string password);
}

