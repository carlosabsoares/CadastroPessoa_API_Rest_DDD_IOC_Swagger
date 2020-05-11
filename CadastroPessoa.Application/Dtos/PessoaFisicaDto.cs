using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Dtos
{
    public class PessoaFisicaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }

        public IEnumerable<Contato> Contato { get; set; }
        
    }
}