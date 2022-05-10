using PersonalBlog.src.dtos;
using PersonalBlog.src.models;

namespace PersonalBlog.src.services
{
    public interface IAuthentication
    {
        string EncodePassword(string password);
        void CreateUserNoDuplicates(NewUserDTO userDTO);
        string GenerateToken(UsersModel user);
        AuthorizationDTO GetAuthorization(AuthenticateDTO authenticateDTO);
    }
}
