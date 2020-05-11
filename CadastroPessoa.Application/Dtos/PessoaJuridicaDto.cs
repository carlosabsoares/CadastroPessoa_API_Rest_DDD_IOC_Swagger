namespace CadastroPessoa.Application.Dtos
{
    public class PessoaJuridicaDto
    {
        

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int CNPJ { get; set; }
        public string Email { get; set; }
    }
}