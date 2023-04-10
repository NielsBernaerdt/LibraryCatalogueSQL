using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogueSQL
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NrPages { get; set; }
        public string Language { get; set; }
        public string TargetAudience { get; set; }
        public string Genre { get; set; }

        public string FullInfo
        {
            get {
                string BookDetailsFormat = "{0, -70} {1, -20} {2, -10} {3, -10} {4, -20} {5, -10}";
                return String.Format(BookDetailsFormat, Title, Author, NrPages, Language, TargetAudience, Genre); 
            }
        }
    }
}
