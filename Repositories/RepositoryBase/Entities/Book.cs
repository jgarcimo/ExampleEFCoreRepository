using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryBase.Entities
{
    public class Book
    {
        public Book()
        {
            Authors = new HashSet<Author>();
        }

        public int BookID { get; set; }

        public long ISBN { get; set; }

        public string Title { get; set; }

        public DateTime PublishingDate { get; set; }

        public int? NumPages { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
