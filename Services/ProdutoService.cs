using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Interfaces;
using ApiCadastro.DTO;
using ApiCadastro.Models;

namespace ApiCadastro.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Produto>CreateProdutoAsync(CreateProdutoRequestDTO request)
        {
            Produto produto = new Produto
            {
                Tipo = request.Tipo,
                Tamanho = request.Tamanho,
                Cor = request.Cor,
                Qualidade = request.Qualidade,
                Quantidade = request.Quantidade,
                CodigoProduto = $"PROD-{Guid.NewGuid().ToString()[..8].ToUpper()}"
            };

            await _repository.AddProdutoAsync(produto);
            return produto;
        }
    }
}