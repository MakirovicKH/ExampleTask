using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Book : LibraryItem
    {
        public Book(string title, int publicationYear, BookGenreEnum genre, LibraryLocation location) : base(title, publicationYear)
        {
            Genre = genre;
            Location = location;
        }

        public BookGenreEnum Genre { get; set; }
        public LibraryLocation Location { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}, Year: {PublicationYear}");
        }
    }
}
