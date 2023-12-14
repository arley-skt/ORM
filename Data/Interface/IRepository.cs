
using Data.Domain;

namespace Data.Interface
{
    public interface IRepository<TEntity>:IDisposable where TEntity : Entity
    {
        Task<TEntity> Adicionar(TEntity entity);
    }
}
