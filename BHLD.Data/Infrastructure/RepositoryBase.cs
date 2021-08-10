using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private IDbFactory dbFactory;

        protected RepositoryBase(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
    }
}
