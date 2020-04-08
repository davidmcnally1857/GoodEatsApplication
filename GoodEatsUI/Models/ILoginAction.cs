using System.Threading.Tasks;

namespace GoodEatsUI.Models
{
    public interface ILoginAction
    {
        Task<bool> Login(string username, string password);
    }
}