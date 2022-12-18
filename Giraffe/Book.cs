using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {

        }

        #region Constructors
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle; //Titel wird von der Klasse genommen und gleichgesetzt
            author = aAuthor;
            pages = aPages;
        }
        #endregion
    }
}
