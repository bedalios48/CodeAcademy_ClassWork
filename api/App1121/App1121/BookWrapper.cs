﻿using App1121.Enums;
using App1121.Interfaces;
using App1121.Models;
using App1121.Models.Dto;

namespace App1121
{
    public class BookWrapper : IBookWrapper
    {
        private readonly IBookSet _bookSet;
        public BookWrapper(IBookSet bookSet)
        {
            _bookSet = bookSet;
        }

        public GetBookDto Bind(Book book)
        {
            return new GetBookDto
            {
                PavadinimasIrAutorius = book.Title + ' ' + book.Author,
                Id = book.Id,
                LeidybosMetai = book.PublishYear
            };
        }

        public Book Bind(CreateBookDto createBook)
        {
            return new Book
            {
                Id = _bookSet.Books.Max(b => b.Id) + 1,
                Author = createBook.Autorius,
                Cover = Enum.Parse<CoverType>(createBook.KnygosTipas),
                PublishYear = createBook.Isleista.Year,
                Title = createBook.Pavadinimas
            };
        }

        public Book Bind(UpdateBookDto updateBook)
        {
            return new Book
            {
                Id = updateBook.Id,
                Author = updateBook.Autorius,
                Cover = Enum.Parse<CoverType>(updateBook.KnygosTipas),
                PublishYear = updateBook.Isleista.Year,
                Title = updateBook.Pavadinimas
            };
        }
    }
}
