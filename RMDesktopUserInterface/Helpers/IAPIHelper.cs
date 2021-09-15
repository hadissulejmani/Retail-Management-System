using RMDesktopUserInterface.Models;
using System.Threading.Tasks;

namespace RMDesktopUserInterface.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}