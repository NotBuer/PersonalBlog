using PersonalBlog.src.utils;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PersonalBlog.src.models
{
    [Table("tb_users")]
    public class UsersModel
    {
        public UsersModel () { }

        public UsersModel(string name, string email, string password, string photo, UserType userType)
        {
            Name = name;
            Email = email;
            Password = password;
            Photo = photo;
            UserType = userType;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(30)]
        public string Email { get; set; }

        [Required, StringLength(30)]
        public string Password { get; set; }
       
        public string Photo { get; set; }

        [Required]
        public UserType UserType { get; set; }

        [JsonIgnore]
        public List<PostModel> MyPosts { get; set; }

    }
}
