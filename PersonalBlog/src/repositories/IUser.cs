using PersonalBlog.src.DTOS;
using PersonalBlog.src.models;

namespace PersonalBlog.src.repositories
{
    /// <summary>
    /// Represents User CRUD actions
    /// <para> Author: Rodrigo Franca </para>
    /// <para> Version: 1.0 </para>
    /// <para> Date: 29/04/2022 </para>
    /// </summary>
    public interface IUser
    {
        void CreateUser(NewUserDTO userDTO);
        void UpdateUser(UpdateUserDTO userDTO);
        void DeleteUser(int id);
        UserModel GetUserById(int id);
        UserModel GetUserByEmail(string email);
        UserModel GetUserByName(string name);
    }
}
