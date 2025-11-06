namespace ApiCadastro.Models
{
    public class Doador
    {
        public int Id { get; set; }
        public string DonorCode { get; set; } = "";
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Cpf { get; set; } = "";
    }
}
