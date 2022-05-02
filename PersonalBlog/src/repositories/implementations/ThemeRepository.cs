using PersonalBlog.src.DTOS;
using PersonalBlog.src.models;
using PersonalBlog.src.data;
using System.Collections.Generic;
using System.Linq;

namespace PersonalBlog.src.repositories.implementations
{
    public class ThemeRepository : ITheme
    {

        #region ATTRIBUTES
        private readonly PersonalBlogContext _context;
        #endregion


        #region CONSTRUCTOR
        public ThemeRepository(PersonalBlogContext context)
        {
            _context = context;
        }
        #endregion


        #region METHODS
        public void NewTheme(NewThemeDTO themeDTO)
        {
            _context.Themes.Add(new ThemeModel
            {
                Description = themeDTO.Description,
            });
            _context.SaveChanges();
        }

        public void UpdateTheme(UpdateThemeDTO themeDTO)
        {
            ThemeModel model = TakeThemeById(themeDTO.Id);
            model.Description = themeDTO.Description;
            _context.Update(model);
            _context.SaveChanges();
        }

        public void DeleteTheme(int id)
        {
            _context.Themes.Remove(TakeThemeById(id));
            _context.SaveChanges();
        }

        public List<ThemeModel> TakeAllThemes()
        {
            return _context.Themes.ToList();
        }

        public List<ThemeModel> TakeThemeByDescription(string description)
        {
            return _context.Themes.Where(t => t.Description == description).ToList();
        }

        public ThemeModel TakeThemeById(int id)
        {
            return _context.Themes.FirstOrDefault(t => t.Id == id);
        }
        #endregion
    }
}
