using System.ComponentModel.DataAnnotations;

namespace CadastroPessoa.Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {
        [Required]
        public int CNPJ { get; set; }
    }
}