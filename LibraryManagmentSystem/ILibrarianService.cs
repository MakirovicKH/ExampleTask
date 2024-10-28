using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal interface ILibrarianService
    {
        Librarian GetLibrarianById(int id);
        List<Librarian> GetAllLibrarians();
        void CreateLibrarian(Librarian librarian);
        void DeleteLibrarian(Librarian librarian, bool isSoftDelete);
    }
}
