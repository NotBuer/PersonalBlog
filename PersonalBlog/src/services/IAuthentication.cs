using PersonalBlog.src.dtos;
using PersonalBlog.src.models;
using System.Threading.Tasks;

namespace PersonalBlog.src.services
{
    public interface IAuthentication
    {
        string EncodePassword(string password);
        Task CreateUserNoDuplicatesAsync(NewUserDTO userDTO);
        string GenerateToken(UsersModel user);
        Task<AuthorizationDTO> GetAuthorizationAsync(AuthenticateDTO authenticateDTO);
    }
}
