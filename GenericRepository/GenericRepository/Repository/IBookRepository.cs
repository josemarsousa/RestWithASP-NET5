using GenericRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repository
{
    interface IBookRepository
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
        bool Exists(long id);
    }
}
