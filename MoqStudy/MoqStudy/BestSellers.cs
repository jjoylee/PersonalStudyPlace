using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqStudy
{
    public class BestSellers
    {
        private IBookRepository bookRepo;
        public BestSellers(IBookRepository bookRepository)
        {
            bookRepo = bookRepository;
        }

        public Result AddBook(Book book)
        {
            if (book.Name.Contains("<") || book.Name.Contains(">"))
                return Result.XssAlert;

            bool added = bookRepo.AddBook(book);

            if (added == false) return Result.AlreadyExist;
            return Result.Success;
        }
    }
}
