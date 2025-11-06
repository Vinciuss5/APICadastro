namespace ApiCadastro.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = "";
        public string Tamanho { get; set; } = "";
        public string Cor { get; set; } = "";
        public string Qualidade { get; set; } = "";
        public int Quantidade { get; set; }
        public string CodigoProduto { get; set; } = "";
        public string DoadorId { get; set; } = "";
        public string DataDoacao { get; set; } = "";
        public string? BeneficiarioId { get; set; }
        public string? DataDistribuicao { get; set; }
    }
}
