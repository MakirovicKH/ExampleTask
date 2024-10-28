using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            return item.PublicationYear.HasValue ? DateTime.Now.Year - item.PublicationYear.Value : -1;
        }

        public static string ToTitleCase(this LibraryItem item)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.Title);
        }
    }
}
