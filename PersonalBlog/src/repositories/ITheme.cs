using PersonalBlog.src.DTOS;
using PersonalBlog.src.models;
using System.Collections.Generic;

namespace PersonalBlog.src.repositories
{
    public interface ITheme
    {
        void NewTheme(NewThemeDTO themeDTO);
        void UpdateTheme(UpdateThemeDTO themeDTO);
        void DeleteTheme(int id);
        ThemeModel TakeThemeById(int id);
        List<ThemeModel> TakeThemeByDescription(string description);

    }
}
