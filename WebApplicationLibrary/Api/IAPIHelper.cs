using System.Threading.Tasks;
using WebApplicationLibrary.Models;

namespace WebApplicationLibrary.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}