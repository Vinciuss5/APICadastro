using Microsoft.AspNetCore.Mvc;
using ApiCadastro.Models;
using System.ComponentModel.Design;
using ApiCadastro.Interfaces;
using ApiCadastro.DTO;

namespace ApiCadastro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoadoresController : ControllerBase
    {
        private readonly IDoadorService _service;
        public DoadoresController(IDoadorService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Doador>> Get()
        {
            var doadores = new List<Doador>
            {
                new Doador { Id = 1, DonorCode = "DOA001", Name = "Maria Silva", Email = "maria@email.com", Phone = "(11) 99999-1234", Cpf = "12345678901" },
                new Doador { Id = 2, DonorCode = "DOA002", Name = "João Santos", Email = "joao@email.com", Phone = "(11) 98888-5678", Cpf = "98765432109" }
            };

            return Ok(doadores);
        }
        
        [HttpPost]
        public async Task<ActionResult<Doador>> CreateDoador(CreateDoadorRequestDTO request)
        {
            Doador doador = await _service.CreateDoadorAsync(request);
                   
            return Ok(doador);
        }
        
    }
}
