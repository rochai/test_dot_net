using System.Data.Entity;

namespace DBProject.DAL
{
    public interface IUnitOfWork
    {
        void Dispose();
        IRepository<TEntity> RepositoryFor<TEntity>() where TEntity : class;
        void Save();
    }
    

    public interface IUnitOfWork<TDbContext> : IUnitOfWork where TDbContext : DbContext, new()
    {
    }
}