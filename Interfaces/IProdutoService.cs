using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.DTO;
using ApiCadastro.Models;

namespace ApiCadastro.Interfaces
{
    public interface IProdutoService
    {
        Task<Produto> CreateProdutoAsync(CreateProdutoRequestDTO request);
    }
}