using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoriesSpecificFactory
{
    public static class GetRepository
    {
        public static RepositoryAbstractFactories.RepositoryFactory GetEF6Factory()
        {
            return new EF_6_Repository.Repositories.EF6Repository();
        }
    }
}
