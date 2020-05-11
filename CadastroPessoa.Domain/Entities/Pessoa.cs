using System.ComponentModel.DataAnnotations;

namespace CadastroPessoa.Domain.Entities
{
    public class Pessoa : ChavePrimaria
    {
        [Required]
        public string Nome { get; set; }

        public string Endereco { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}