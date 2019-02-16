using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqStudy
{
    public class PriceProcessor
    {
        private IBookRepository bookRepo;
        public PriceProcessor(IBookRepository bookRepository)
        {
            bookRepo = bookRepository;
        }
        
        public int GetTotalPrice()
        {
            int result = 0;
            foreach (Book b in bookRepo.GetBooks())
            {
                result += b.Price;
            }
            return result;
        }

        public void ReducePrice(float reductionRatio)
        {
            foreach(Book book in bookRepo.GetBooks())
            {
                book.Price = (int)(reductionRatio * book.Price);
                bookRepo.UpdateBook(book);
            }
        }
    }
}
