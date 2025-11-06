namespace ApiCadastro.Models
{
    public class Beneficiario
    {
        public int Id { get; set; }
        public string BeneficiaryCode { get; set; } = "";
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Cpf { get; set; } = "";
        public string Street { get; set; } = "";
        public string Number { get; set; } = "";
        public string Complement { get; set; } = "";
        public string Bairro { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string Cep { get; set; } = "";
    }
}





