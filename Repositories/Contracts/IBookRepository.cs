﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository :IRepositoryBase<Book> //Bu ifade repository altında Crudları buraya devralıyoruz 
    {
        IQueryable<Book> GetAllBooks(bool trackChanges);
        Book GetOneBookById(int id,bool trackChanges);

        void CreateOneBook(Book book);
        void UpdateOneBook(Book book);
        void DeleteOneBook(Book book);

    }
}
