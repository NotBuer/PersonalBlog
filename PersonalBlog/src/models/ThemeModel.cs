﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PersonalBlog.src.models
{

    [Table("tb_themes")]
    public class ThemeModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Description { get; set; }

        [JsonIgnore]
        public List<PostModel> RelatedPosts { get; set; }

    }
    
}
