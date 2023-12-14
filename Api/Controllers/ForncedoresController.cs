using Api.ViewModel;
using AutoMapper;
using Data.Domain;
using Data.Interface;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForncedoresController : ControllerBase
    {

        private readonly IFornecedorRepository _FornecedorRepository;
            private readonly IMapper _mapper;

        public ForncedoresController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _FornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<FornecedorViewModel>> ObterPorId(Guid id)
        {
            //var fornecedor = _mapper.Map<FornecedorViewModel>(await _FornecedorRepository.ObterPorId(id));

            //if (fornecedor == null) return NotFound();

            return Ok();
        }

        [HttpGet("{Nome}")]
        public async Task<ActionResult<FornecedorViewModel>> ObterPorId(string Nome)
        {
            //var fornecedor = _mapper.Map<FornecedorViewModel>(await _FornecedorRepository.ObterPorNome(Nome));

            //if (fornecedor == null) return NotFound();

            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult<FornecedorViewModel>> Adicionar([FromBody] FornecedorViewModel fornecedorViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var fornecedor = _mapper.Map<FornecedorViewModel>(await _FornecedorRepository.Adicionar(_mapper.Map<Fornecedor>(fornecedorViewModel)));

            return fornecedor;
        }


    }
}
