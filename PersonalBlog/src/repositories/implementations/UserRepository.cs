using PersonalBlog.src.data;
using PersonalBlog.src.dtos;
using PersonalBlog.src.models;
using System.Collections.Generic;
using System.Linq;

namespace PersonalBlog.src.repositories.implementations
{
    public class UserRepository : IUser
    {

        #region ATTRIBUTES
        private readonly PersonalBlogContext _context;
        #endregion


        #region CONSTRUCTORS
        public UserRepository(PersonalBlogContext context)
        {
            _context = context;
        }
        #endregion


        #region METHODS
        public void CreateUser(NewUserDTO userDTO)
        {
            _context.User.Add(new UsersModel
            {
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = userDTO.Password,
                Photo = userDTO.Photo,
                UserType = userDTO.UserType,
            });
            _context.SaveChanges();
        }

        public void UpdateUser(UpdateUserDTO userDTO)
        {
            UsersModel user = GetUserById(userDTO.Id);
            user.Name = userDTO.Name;
            user.Password = userDTO.Password;
            user.Photo = userDTO.Photo;
            _context.User.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id) 
        {
            _context.User.Remove(GetUserById(id));
            _context.SaveChanges();
        }

        public UsersModel GetUserByEmail(string email) 
        {
            return _context.User.FirstOrDefault(u => u.Email == email);
        }

        public UsersModel GetUserById(int id) 
        {
            return _context.User.FirstOrDefault(u => u.Id == id);
        }

        public UsersModel GetUserByName(string name)
        {
            return _context.User.FirstOrDefault(u => u.Name == name);
        }

        public List<UsersModel> GetUsersByName(string name)
        {
            throw new System.NotImplementedException();
        }
        #endregion

    }
}
