using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroPessoa.Domain.Entities
{
    public class PessoaFisica : Pessoa
    {
        [Required]
        public int CPF { get; set; }

        public IEnumerable<Contato> Contato { get; set; }
    }
}