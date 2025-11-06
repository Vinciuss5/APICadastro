using Microsoft.AspNetCore.Mvc;
using ApiCadastro.Models;
using ApiCadastro.DTO;
using ApiCadastro.Interfaces;

namespace ApiCadastro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produto = new List<Produto>
            {
                new Produto { Id = 1, Tipo = "Camiseta", Tamanho = "M", Cor = "Azul", Qualidade = "Usado - Bom Estado", Quantidade = 5, DoadorId = "DOA001", DataDoacao = "2024-10-01" },
                new Produto { Id = 2, Tipo = "Calça", Tamanho = "G", Cor = "Preta", Qualidade = "Nova", Quantidade = 2, DoadorId = "DOA002", DataDoacao = "2024-10-05" }
            };

            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> CreateProduto(CreateProdutoRequestDTO request)
        {
            Produto produto = await _service.CreateProdutoAsync(request);
            return Ok(produto);
        }
    }
}
