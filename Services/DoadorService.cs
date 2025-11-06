using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Interfaces;
using ApiCadastro.DTO;
using ApiCadastro.Models;

namespace ApiCadastro.Services
{
    public class DoadorService : IDoadorService
    {
        private readonly IDoadorRepository _repository;

        public DoadorService(IDoadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<Doador> CreateDoadorAsync(CreateDoadorRequestDTO request)
        {
            Doador doador = new Doador
            {
                Name = request.Nome,
                Email = request.Email,
                Phone = request.Telefone,
                Cpf = request.Cpf,
                DonorCode = $"DOA-{Guid.NewGuid().ToString()[..8].ToUpper()}"
            };

            await _repository.AddDoadorAsync(doador);
            return doador;
        }
    }
}