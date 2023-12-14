
using Data.Banco;
using Data.Domain;
using Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<Produto> ObterId(Guid Id)
        {
            var produto = await Dbset.Where(p => p.Id == Id).FirstOrDefaultAsync();

            return produto;
        }
    }
}
