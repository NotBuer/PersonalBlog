using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.src.DTOS
{

    /// <summary>
    /// DTO for create a new user data.
    /// <para> Author: Rodrigo Franca </para>
    /// <para> Version: 1.0 </para>
    /// <para> Date: 29/04/2022 </para>
    /// </summary>
    public class NewUserDTO
    {
        public NewUserDTO(string name, string email, string password, string picture)
        {
            Name = name;
            Email = email;
            Password = password;
            Picture = picture;
        }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(40)]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string Password { get; set; }

        public string Picture { get; set; }
    }

    /// <summary>
    /// DTO for update the user data.
    /// <para> Author: Rodrigo Franca </para>
    /// <para> Version: 1.0 </para>
    /// <para> Date: 29/04/2022 </para>
    /// </summary>
    public class UpdateUserDTO
    {
        public UpdateUserDTO(string name, string password, string picture)
        {
            Name = name;
            Password = password;
            Picture = picture;
        }

        [Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(20)]
        public string Password { get; set; }

        public string Picture { get; set; }
    }

    /// <summary>
    /// DTO for delete the user data.
    /// <para> Author: Rodrigo Franca </para>
    /// <para> Version: 1.0 </para>
    /// <para> Date: 29/04/2022 </para>
    /// </summary>
    public class DeleteUserDTO
    {

    }
    
}
