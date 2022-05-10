using PersonalBlog.src.dtos;
using PersonalBlog.src.models;
using System.Collections.Generic;

namespace PersonalBlog.src.repositories
{
    public interface IPost
    {
        void NewPost(NewPostDTO post);
        void UpdatePost(UpdatePostDTO post);
        void DeletePost(int id);
        PostModel GetPostById(int id);
        List<PostModel> GetAllPosts();
        List<PostModel> GetPostBySearch(string title, string description, string creator);
    }
}
