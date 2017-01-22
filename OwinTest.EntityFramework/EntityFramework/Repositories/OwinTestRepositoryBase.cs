using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace OwinTest.EntityFramework.Repositories
{
    public abstract class OwinTestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<OwinTestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected OwinTestRepositoryBase(IDbContextProvider<OwinTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class OwinTestRepositoryBase<TEntity> : OwinTestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected OwinTestRepositoryBase(IDbContextProvider<OwinTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
