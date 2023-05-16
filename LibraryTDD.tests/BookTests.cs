using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTDD.tests
{
    public class BookTests
    {
        [Fact]
        public void Book_Constructor_InitializesPropertyValues()
        {
            Book book = new Book("The Hobbit", "JRR Tolkien");

            Assert.Equal("The Hobbit", book.Title);
            Assert.Equal("JRR Tolkien", book.Author);
            //Assert.Null(book.Patron);
        }

        [Fact]
        public void Book_IsCheckedOut_ReturnsIfBookHasAPatronAssigned()
        {
            Book book = new Book("The Hobbit", "JRR Tolkien");

            //Assert.False(book.IsCheckedOut());
        }
    }
}
