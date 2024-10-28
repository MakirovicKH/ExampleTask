using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class LibrarianService : ILibrarianService
    {
        public void CreateLibrarian(Librarian librarian)
        {
            
        }

        public void DeleteLibrarian(Librarian librarian, bool isSoftDelete)
        {
            throw new NotImplementedException();
        }

        public List<Librarian> GetAllLibrarians()
        {
            throw new NotImplementedException();
        }

        public Librarian GetLibrarianById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
