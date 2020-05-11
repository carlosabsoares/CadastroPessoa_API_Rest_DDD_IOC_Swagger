using System.Collections.Generic;

namespace CadastroPessoa.Domain.Entities
{
    public class Contato : ChavePrimaria
    {
        public int PessoaId { get; set; }
        public IEnumerable<PessoaFisica> PessoasFisicas { get; set; }
    }
}