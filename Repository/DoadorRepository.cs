using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Interfaces;
using ApiCadastro.Models;
using ApiCadastro.Data;

namespace ApiCadastro.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        private readonly AppDbContext _context;
        public DoadorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddDoadorAsync(Doador doador)
        {
            await _context.Doadores.AddAsync(doador);
            await _context.SaveChangesAsync();
        }
    }
}