using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqStudy
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        bool AddBook(Book book);
        void UpdateBook(Book book);
    }
}
