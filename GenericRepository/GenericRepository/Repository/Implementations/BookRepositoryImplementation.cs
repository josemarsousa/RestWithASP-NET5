using GenericRepository.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {
        private MySQLContext _context;

        public BookRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
    }
}
