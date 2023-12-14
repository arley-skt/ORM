using Api.ViewModel;
using AutoMapper;
using Data.Domain;

namespace Api.Mapper
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();

            CreateMap<ProdutoViewModel, Produto>().ReverseMap();

            CreateMap<Produto, ProdutoViewModel>();

        }
    }
}
