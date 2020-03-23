using System.Threading.Tasks;

namespace SelFood.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> SignUp(string email, string password);
        Task<string> SignIn(string email, string password);
    }
}
