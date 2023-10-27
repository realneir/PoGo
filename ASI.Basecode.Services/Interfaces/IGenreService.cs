using Services.Models;
using System.Collections.Generic;

namespace PogoAdmin.Services
{
    public interface IGenreService
    {
        IEnumerable<GenreViewModel> GetAllGenres();
        GenreViewModel GetGenreById(int genreID);
        void AddGenre(GenreViewModel model);
        void UpdateGenre(GenreViewModel model);
        void DeleteGenre(int genreID);
    }
}