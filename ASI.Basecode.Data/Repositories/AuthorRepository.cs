using Data.Interfaces;
using Data.Repositories;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repositories
{
    public class AuthorRepository : BaseRepository, IAuthorRepository
    {
        public AuthorRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Author> GetAllAuthors()
        {
            return this.GetDbSet<Author>();
        }

        public Task<Author> GetAuthorById(string authorID)
        {
            var author = this.GetDbSet<Author>().Where(a => a.authorId == authorID).SingleOrDefaultAsync();

            return author;
        }

        public void AddAuthor(Author author)
        {
            this.GetDbSet<Author>().Add(author);
            UnitOfWork.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            this.SetEntityState(author, EntityState.Modified);
            UnitOfWork.SaveChanges();
        }

        public void DeleteAuthor(int authorID)
        {
            var author = this.GetDbSet<Author>().Find(authorID);
            if (author != null)
            {
                this.GetDbSet<Author>().Remove(author);
                UnitOfWork.SaveChanges();
            }
        }

        public bool AuthorExists(int authorID)
        {
            return this.GetDbSet<Author>().Any(x => x.authorID == authorID);
        }
    }
}