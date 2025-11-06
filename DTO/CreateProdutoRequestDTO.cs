using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace ApiCadastro.DTO
{
    public class CreateProdutoRequestDTO
    {
        [Required(ErrorMessage = "O tipo do produto é obrigatório.")]
        public string Tipo { get; set; } = string.Empty;

        [Required(ErrorMessage = "A cor do produto é obrigatoria.")]
        public string Cor { get; set; } = string.Empty;

        [Required(ErrorMessage = "O tamanho do produto é obrigatório.")]
        public string Tamanho { get; set; } = string.Empty;

        [Required(ErrorMessage = "A qualidade do produto é obrigatória.")]
        public string Qualidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "A quantidade do produto é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser pelo menos 1.")]
        public int Quantidade { get; set; } = 0;

        [Required(ErrorMessage = "O código do produto é obrigatório.")]
        public string CodigoProduto { get; set; } = string.Empty;
    }
}