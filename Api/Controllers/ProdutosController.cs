using Api.ViewModel;
using AutoMapper;
using Data.Domain;
using Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository=produtoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoViewModel>> Adicionar([FromBody] ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var produtoBd = _mapper.Map<ProdutoViewModel>(await _produtoRepository.Adicionar(_mapper.Map<Produto>(produtoViewModel)));

            //var produtovm = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterPorIdComFornecedor(retorno.id));

            return Ok();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProdutoViewModel>> ObterPorId(Guid id)
        {
            var produtovm = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterId(id));

            return produtovm;
        }

    }


}
