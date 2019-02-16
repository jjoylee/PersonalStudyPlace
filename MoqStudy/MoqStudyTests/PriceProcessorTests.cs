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
    public class PriceProcessorTests
    {
        List<Book> bookList;
        Mock<IBookRepository> bookRepoMock;
        PriceProcessor priceProcessor;

        [SetUp]
        public void SetUp()
        {
            bookList = new List<Book>(){
                new Book() {ISBN="1234", Price=10000, Name="C언어 입문"},
                new Book() {ISBN="1235", Price=20000, Name="C++ 입문"},
                new Book() {ISBN="1236", Price=30000, Name="ASP.NET MVC3 완성"}
            };

            bookRepoMock = new Mock<IBookRepository>();
            bookRepoMock.Setup(b => b.GetBooks()).Returns(bookList);
            priceProcessor = new PriceProcessor(bookRepoMock.Object);
        }

        [Test]
        public void GetTotalPrice_NoDiscount_ReturnCorrectPriceSum()
        {
            Assert.That(priceProcessor.GetTotalPrice(), Is.EqualTo(60000));
        }

        [Test]
        public void ReducePrice_ValueBetween0And1_IBookRepositoryUpdateBookCalled()
        {
            priceProcessor.ReducePrice(0.1f);
            bookRepoMock.Verify(r => r.UpdateBook(It.IsAny<Book>()), Times.Exactly(bookList.Count));
        }
    }
}