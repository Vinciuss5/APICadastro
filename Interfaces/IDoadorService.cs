using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCadastro.DTO;
using ApiCadastro.Models;

namespace ApiCadastro.Interfaces
{
    public interface IDoadorService
    {
        Task<Doador> CreateDoadorAsync(CreateDoadorRequestDTO request);
    }
}