
using Data.Domain;

namespace Data.Interface
{
    public interface IProdutoRepository:IRepository<Produto>
    {
        Task<Produto> ObterId(Guid Id);
        
    }
}
