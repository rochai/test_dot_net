using System;
using System.Data.Entity;

namespace DBProject.DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public IRepository<TEntity> RepositoryFor<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(this.context);
        }

        public void Save()
        {
            context.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public class UnitOfWork<TDbContext> : UnitOfWork, IUnitOfWork<TDbContext> where TDbContext : DbContext, new()
    {
        public UnitOfWork()
            : base(new TDbContext())
        {
        }

    }
}
