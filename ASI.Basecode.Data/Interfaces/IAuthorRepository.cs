using System;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAllAuthors();
        Task<Author> GetAuthorById(string authorId);
        void AddAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(int authorID);
        bool AuthorExists(int authorID);
    }
}
