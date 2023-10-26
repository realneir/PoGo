using ASI.Basecode.Data.Interfaces;
using Basecode.Data.Repositories;
using Data.Interfaces;
using ASI.Basecode.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASI.Basecode.Data.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public BookRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Book> GetAllBooks()
        {
            return this.GetDbSet<Book>().Include(b => b.Author); ;
        }
        public Task<Book> GetBookById(int bookID)
        {
            var book = this.GetDbSet<Book>().FirstOrDefault(b => b.bookID == bookID);
            return Task.FromResult(book);
        }

        public bool BookExists(int bookID)
        {
            return this.GetDbSet<Book>().Any(x => x.Id == bookID);
        }

        public void AddBook(Book book)
        {
            this.GetDbSet<Book>().Add(book);
            UnitOfWork.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            this.SetEntityState(book, EntityState.Modified);
            UnitOfWork.SaveChanges();
        }

        public void DeleteBook(int bookID)
        {
            var book = this.GetDbSet<Book>().Find(bookID);
            if (book != null)
            {
                this.GetDbSet<Book>().Remove(book);
                UnitOfWork.SaveChanges();
            }
        }

    }
}