using ASI.Basecode.Data.Interfaces;
using Basecode.Data.Repositories;
using Data.Interfaces;
using ASI.Basecode.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASI.Basecode.Data.Repositories
{
    public class GenreRepository : BaseRepository, IGenreRepository
    {
        public GenreRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Genre> GetAllGenres()
        {
            return this.GetDbSet<Genre>();
        }

        public Genre GetGenreById(int genreID)
        {
            return this.GetDbSet<Genre>().Find(genreID);
        }

        public void AddGenre(Genre genre)
        {
            this.GetDbSet<Genre>().Add(genre);
            UnitOfWork.SaveChanges();
        }

        public void UpdateGenre(Genre genre)
        {
            this.SetEntityState(genre, EntityState.Modified);
            UnitOfWork.SaveChanges();
        }

        public void DeleteGenre(int genreID)
        {
            var genre = this.GetDbSet<Genre>().Find(genreID);
            if (genre != null)
            {
                this.GetDbSet<Genre>().Remove(genre);
                UnitOfWork.SaveChanges();
            }
        }

        public bool GenreExists(int genreID)
        {
            return this.GetDbSet<Genre>().Any(x => x.genreID == genreID);
        }
    }
}