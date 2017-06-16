using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryAbstractFactories
{
    public abstract class RepositoryFactory
    {
        public abstract RepositoryBase.Repositories.IBookRepository CreateBookRepository();
        public abstract RepositoryBase.Repositories.IAuthorRepository CreateAuthorRepository();
    }
}
