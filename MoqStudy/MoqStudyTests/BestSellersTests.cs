using Moq;
using MoqStudy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqStudy.Tests
{
    [TestFixture]
    public class BestSellersTests
    {
        Book book;
        Mock<IBookRepository> mock;
        BestSellers bestSellers;

        [SetUp]
        public void setUp()
        {
            mock = new Mock<IBookRepository>();
        }

        [Test]
        public void AddBook_ContainsTag_IBookRepositoryAddBookIsNotCalled()
        {
            book = new Book() { Name = "<iframe></iframe>" };
            mock.Setup(r => r.AddBook(book)).Verifiable();
            bestSellers = new BestSellers(mock.Object);
            bestSellers.AddBook(book);
            mock.Verify(r => r.AddBook(book), Times.Never());
        }

        [Test]
        public void AddBook_AddSameBookAgain_ReturnsAlreadyExist()
        {
            book = new Book() { ISBN = "1234",Name = "abc" };
            int count = 0;
            mock.Setup(r => r.AddBook(book)).Callback(() => count++).Returns(() => count <= 1);
            bestSellers = new BestSellers(mock.Object);
            Result result1 = bestSellers.AddBook(book);
            Result result2 = bestSellers.AddBook(book);
            Assert.That(result1, Is.EqualTo(Result.Success));
            Assert.That(result2, Is.EqualTo(Result.AlreadyExist));
        }
    }
}