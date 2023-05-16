using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTDD
{
    public class Book
    {
        public string Title;
        public string Author;
        //public Patron Patron;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            //Patron = null;
        }
    }
}
