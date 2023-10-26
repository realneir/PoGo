using System;
using ASI.Basecode.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Interfaces
{
    public interface IGenreRepository
    {
        IQueryable<Genre> GetAllGenres();
        Genre GetGenreById(int genreID);
        void AddGenre(Genre Genre);
        void UpdateGenre(Genre Genre);
        void DeleteGenre(int genreID);
        bool GenreExists(int genreID);
    }
}
