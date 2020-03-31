using SelFood.Models;
using System.Threading.Tasks;

namespace SelFood.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> SignIn(string email, string password);
        Task<string> SignUp(User user);
        //Task<bool> Logout();
    }
}
