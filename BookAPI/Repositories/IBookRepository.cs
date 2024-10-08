﻿using BookAPI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int Id);

        Task<Book> Create(Book book);

        Task<Book> Update(Book book);

        Task Delete(int Id);
    }
}
