using Microsoft.AspNetCore.Mvc;
using ApiCadastro.Models;
using ApiCadastro.DTO;
using ApiCadastro.Interfaces;



namespace ApiCadastro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeneficiariosController : ControllerBase
    {
        private readonly IBeneficiarioService _service;
        public BeneficiariosController(IBeneficiarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Beneficiario>> Get()
        {
            var beneficiarios = new List<Beneficiario>
            {
                new Beneficiario { Id = 1, BeneficiaryCode = "BEN001", Name = "José da Silva", Email = "jose@email.com", Phone = "(11) 98765-4321", Cpf = "11122233344", Street = "Rua das Flores", Number = "123", City = "São Paulo", State = "SP", Cep = "05421-001" },
                new Beneficiario { Id = 2, BeneficiaryCode = "BEN002", Name = "Ana Costa", Email = "ana@email.com", Phone = "(11) 97777-1234", Cpf = "22233344455", Street = "Av. Paulista", Number = "500", City = "São Paulo", State = "SP", Cep = "01310-000" }
            };

            return Ok(beneficiarios);
        }

        [HttpPost]
        public async Task<ActionResult<Beneficiario>> CreateBeneficiario(CreateBeneficiarioRequestDTO request)
        {
            Beneficiario beneficiario = await _service.CreateBeneficiarioAsync(request);
                   
            return Ok(beneficiario);
        }
    }
}
