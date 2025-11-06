using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Interfaces;
using ApiCadastro.DTO;
using ApiCadastro.Models;

namespace ApiCadastro.Services
{
    public class BeneficiarioService : IBeneficiarioService
{
    private readonly IBeneficiarioRepository _repository;

    public BeneficiarioService(IBeneficiarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<Beneficiario> CreateBeneficiarioAsync(CreateBeneficiarioRequestDTO request)
        {
            Beneficiario beneficiario = new Beneficiario
            {
                Name = request.Nome,
                Email = request.Email,
                Phone = request.Telefone,
                Cpf = request.Cpf,
                Cep = request.Cep,
                Street = request.Rua,
                Number = request.Numero,
                City = request.Cidade,
                State = request.Estado,
                Bairro = request.Bairro,
                BeneficiaryCode = $"BEN-{Guid.NewGuid().ToString()[..8].ToUpper()}"

            };

            await _repository.AddBeneficiarioAsync(beneficiario);
            return beneficiario;
        }

    }
}