using PersonalBlog.src.DTOS;
using PersonalBlog.src.models;
using System.Collections.Generic;
using PersonalBlog.src.data;
using System.Linq;

namespace PersonalBlog.src.repositories.implementations
{
    public class PostRepository : IPost
    {
        #region ATTRIBUTE
        private readonly PersonalBlogContext _context;
        #endregion


        #region CONSTRUCTOR
        public PostRepository(PersonalBlogContext context)
        {
            _context = context;
        }
        #endregion


        #region METHODS
        public void NewPost(NewPostDTO post)
        {
            _context.Posts.Add(new PostModel
            {
                Title = post.Title,
                Description = post.Description,
                Picture = post.Picture,
            });
            _context.SaveChanges();
        }

        public void UpdatePost(UpdatePostDTO post)
        {
            PostModel model = GetPostById(post.Id);
            model.Title = post.Title;
            model.Description = post.Description;
            model.Picture = post.Picture;
            _context.Update(model);
            _context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            _context.Posts.Remove(GetPostById(id));
            _context.SaveChanges();
        }

        public List<PostModel> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public PostModel GetPostById(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == id);
        }

        public List<PostModel> GetPostBySearch(string title, string description, string creator)
        {
            // TODO: Wait the implementation...
            return null;
        }
        #endregion

    }
}
