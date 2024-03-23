﻿using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IAuthorsService
    {
        IEnumerable<Author> GetAll();

        Author GetById(int id);
        void Add(Author author);

        Author Update(int id, Author newAuthor);

        void Delete(int id);
    }
}
