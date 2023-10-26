﻿using Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBookRepository
    {
        IQueryable<Book> GetAllBooks();
        Task<Book> GetBookById(int bookID);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int bookID);
        bool BookExists(int bookID);
    }
}