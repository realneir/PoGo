using Services.Models; 
using AutoMapper;
using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using PogoAdmin.Services;
using Data.Repositories;
using System.IO;

namespace ASI.Basecode.Services.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public IEnumerable<AuthorViewModel> GetAllAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            return _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
        }

        public AuthorViewModel GetAuthorById(int authorID)
        {
            var author = _authorRepository.GetAuthorById(authorID);
            return _mapper.Map<AuthorViewModel>(author);
        }

        public void AddAuthor(AuthorViewModel model)
        {
            if (!_authorRepository.AuthorExists(model.authorID))
            {
                var author = _mapper.Map<Author>(model);
                _authorRepository.AddAuthor(author);
            }
            else
            {
                throw new InvalidDataException(Resources.Messages.Errors.UserExists);
            }
        }

        public void UpdateAuthor(AuthorViewModel model)
        {
            if (_authorRepository.AuthorExists(model.authorID))
            {
                var existingAuthor = _authorRepository.GetAuthorById(model.authorID);
                _mapper.Map(model, existingAuthor);
                _authorRepository.UpdateAuthor(existingAuthor);
            }
        }

        public void DeleteAuthor(int authorID)
        {
            _authorRepository.DeleteAuthor(authorID);
        }
    }
}