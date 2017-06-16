using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryBase.Entities
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
