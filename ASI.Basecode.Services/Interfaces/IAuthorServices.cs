using Services.Models;
using System.Collections.Generic;

namespace PogoAdmin.Services
{
    public interface IAuthorService
    {
        IEnumerable<AuthorViewModel> GetAllAuthors();
        AuthorViewModel GetAuthorById(int authorID);
        void AddAuthor(AuthorViewModel model);
        void UpdateAuthor(AuthorViewModel model);
        void DeleteAuthor(int authorID);
    }
}