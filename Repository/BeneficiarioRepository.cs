using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Interfaces;
using ApiCadastro.Models;
using ApiCadastro.Data;

namespace ApiCadastro.Repository
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        private readonly AppDbContext _context;
        public BeneficiarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddBeneficiarioAsync(Beneficiario beneficiario)
        {
            await _context.Beneficiarios.AddAsync(beneficiario);
            await _context.SaveChangesAsync();
        }
    }
}