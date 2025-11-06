using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Interfaces;
using ApiCadastro.Models;
using ApiCadastro.Data;
using Microsoft.EntityFrameworkCore;


namespace ApiCadastro.Repository
{
    public class TipoProdutoRepository : ITipoProdutoRepository
    {
        private readonly AppDbContext _context;
        public TipoProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TipoProduto>> GetTiposProdutoAsync()
        {
            return await _context.TiposProdutos.ToListAsync();
        }
    }
}