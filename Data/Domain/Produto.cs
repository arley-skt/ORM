
namespace Data.Domain
{
    public class Produto : Entity
    {

        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public Fornecedor? fornecedor { get; set; }
    }
}
