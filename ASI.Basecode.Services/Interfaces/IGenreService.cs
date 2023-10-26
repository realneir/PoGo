﻿using ASI.Basecode.Services.Models;
using System.Collections.Generic;

namespace ASI.Basecode.WebApp.Services
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