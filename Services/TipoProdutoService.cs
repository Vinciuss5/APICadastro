using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Interfaces;
using ApiCadastro.DTO;
using ApiCadastro.Models;

namespace ApiCadastro.Services
{
    public class TipoProdutoService : ITipoProdutoService
    {
        private readonly ITipoProdutoRepository _repository;
        public TipoProdutoService(ITipoProdutoRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<TipoProduto>> GetTiposProdutoAsync()
        {
           return await _repository.GetTiposProdutoAsync();
        }
    }
}