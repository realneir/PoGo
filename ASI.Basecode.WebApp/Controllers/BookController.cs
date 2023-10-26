using ASI.Basecode.Services.Services;
using ASI.Basecode.WebApp.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using ASI.Basecode.Services.ServiceModels; 

namespace ASI.Basecode.WebApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        public BookController(IMapper mapper, IBookService bookService, IAuthorService authorService)
        {
            _mapper = mapper;
            _bookService = bookService;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            var bookViewModels = _bookService.GetAllBooks();
            return View(bookViewModels);
        }

        public IActionResult Details(int bookID)
        {
            var viewModel = _bookService.GetBookById(bookID);
            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var authors = _authorService.GetAllAuthors()
                                   .Select(a => new
                                   {
                                       Id = a.Id,
                                       FullName = a.FirstName + " " + a.LastName
                                   })
                                   .ToList();
            ViewBag.AuthorList = new SelectList(authors, "Id", "FullName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = _mapper.Map<BookViewModel, Book>(model);
                _bookService.AddBook(book);
                return RedirectToAction(nameof(Index));
            }
            var authors = _authorService.GetAllAuthors()
                                   .Select(a => new
                                   {
                                       Id = a.Id,
                                       FullName = a.FirstName + " " + a.LastName
                                   })
                                   .ToList();
            ViewBag.AuthorList = new SelectList(authors, "Id", "FullName");
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = _bookService.GetBookById(id);
            if (viewModel == null)
            {
                return NotFound();
            }
            var authors = _authorService.GetAllAuthors()
                                   .Select(a => new
                                   {
                                       Id = a.Id,
                                       FullName = a.FirstName + " " + a.LastName
                                   })
                                   .ToList();
            ViewBag.AuthorList = new SelectList(authors, "Id", "FullName");

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = _mapper.Map<BookViewModel, Book>(model);
                _bookService.UpdateBook(book);
                return RedirectToAction(nameof(Index));
            }
            var authors = _authorService.GetAllAuthors()
                                   .Select(a => new
                                   {
                                       Id = a.Id,
                                       FullName = a.FirstName + " " + a.LastName
                                   })
                                   .ToList();
            ViewBag.AuthorList = new SelectList(authors, "Id", "FullName");
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _bookService.DeleteBook(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
