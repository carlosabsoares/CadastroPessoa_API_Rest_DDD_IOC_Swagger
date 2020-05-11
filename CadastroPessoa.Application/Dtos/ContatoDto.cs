using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Dtos
{
    public class ContatoDto
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public IEnumerable<PessoaFisica> PessoasFisicas { get; set; }
    }
}