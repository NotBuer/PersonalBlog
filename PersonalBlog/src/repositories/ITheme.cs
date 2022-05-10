using PersonalBlog.src.dtos;
using PersonalBlog.src.models;
using System.Collections.Generic;

namespace PersonalBlog.src.repositories
{
    public interface ITheme
    {

        void NewTheme(NewThemeDTO themeDTO);
        void UpdateTheme(UpdateThemeDTO themeDTO);
        void DeleteTheme(int id);
        ThemeModel GetThemeById(int id);
        List<ThemeModel> GetThemesByDescription(string description);

    }
}
