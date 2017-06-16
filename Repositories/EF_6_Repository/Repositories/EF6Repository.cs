using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryBase.Repositories;

namespace EF_6_Repository.Repositories
{
    public class EF6Repository : RepositoryAbstractFactories.RepositoryFactory
    {
        public override IAuthorRepository CreateAuthorRepository()
        {
            return new AuthorRepository();
        }

        public override IBookRepository CreateBookRepository()
        {
            return new BookRepository();
        }
    }
}
