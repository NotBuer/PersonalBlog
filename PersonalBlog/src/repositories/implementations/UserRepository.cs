using PersonalBlog.src.data;
using PersonalBlog.src.DTOS;
using PersonalBlog.src.models;
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
            _context.Users.Add(new UserModel
            {
                Email = userDTO.Email,
                Name = userDTO.Name,
                Password = userDTO.Password,
                Picture = userDTO.Picture
            });
            _context.SaveChanges();
        }

        public void UpdateUser(UpdateUserDTO userDTO)
        {
            UserModel user = GetUserById(userDTO.Id);
            user.Name = userDTO.Name;
            user.Password = userDTO.Password;
            user.Picture = userDTO.Picture;
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            _context.Users.Remove(GetUserById(id));
            _context.SaveChanges();
        }

        public UserModel GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public UserModel GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public UserModel GetUserByName(string name)
        {
            return _context.Users.FirstOrDefault(u => u.Name == name);
        }
        #endregion

    }
}
