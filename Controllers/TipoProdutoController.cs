using Microsoft.AspNetCore.Mvc;
using ApiCadastro.Models;
using System.ComponentModel.Design;
using ApiCadastro.Interfaces;
using ApiCadastro.DTO;

namespace ApiCadastro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoProdutoController : ControllerBase
    {
        private readonly ITipoProdutoService _service;
        public TipoProdutoController(ITipoProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<TipoProduto>> Get()
        {
            var tipoProdutos = await _service.GetTiposProdutoAsync();
            return Ok(tipoProdutos);
        }       
  
    }
}
