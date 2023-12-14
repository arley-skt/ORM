

using Data.Domain;

namespace Data.Interface
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterId(Guid Id);
    }
}
