
using Data.Banco;
using Data.Domain;
using Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:Entity
    {
        protected readonly AppDbContext _Context;
        protected readonly DbSet<TEntity> Dbset;
        public Repository(AppDbContext appDbContext)
        {
            _Context = appDbContext;
            Dbset=appDbContext.Set<TEntity>();
        }
        public async Task<TEntity> Adicionar(TEntity entity)
        {
            Dbset.Add(entity);
            await _Context.SaveChangesAsync();

            return entity;
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
