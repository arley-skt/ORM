namespace Api.ViewModel
{
    public class ProdutoViewModel
    {
        public Guid id { get; set; }
        public Guid FornecedorId { get; set; }
        public string nome { get; set; }       
        public FornecedorViewModel? fornecedor { get; set; }

    }
}
