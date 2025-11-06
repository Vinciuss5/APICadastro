using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.Models;


namespace ApiCadastro.Interfaces
{
    public interface IBeneficiarioRepository
    {
        Task AddBeneficiarioAsync(Beneficiario beneficiario);
        
    }
}
