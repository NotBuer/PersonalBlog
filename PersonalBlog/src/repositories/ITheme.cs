using PersonalBlog.src.dtos;
using PersonalBlog.src.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalBlog.src.repositories
{
    public interface ITheme
    {

        Task NewThemeAsync(NewThemeDTO themeDTO);
        Task UpdateThemeAsync(UpdateThemeDTO themeDTO);
        Task DeleteThemeAsync(int id);
        Task<ThemeModel> GetThemeByIdAsync(int id);
        Task<List<ThemeModel>> GetThemesByDescriptionAsync(string description);
        Task<List<ThemeModel>> GetAllThemesAsync();

    }
}
