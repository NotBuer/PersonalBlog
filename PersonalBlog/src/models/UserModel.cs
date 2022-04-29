using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PersonalBlog.src.models
{
    
    [Table("tb_users")]
    public class UserModel
    {
        public UserModel() { }

        public UserModel(int id, string name, string email, string password, string picture)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Picture = picture;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(40)]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string Password { get; set; }

        public string Picture { get; set; }

        [JsonIgnore]
        public List<PostModel> UserPosts { get; set; }
        
    }
    
}
