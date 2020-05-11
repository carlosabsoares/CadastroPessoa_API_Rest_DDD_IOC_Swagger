using CadastroPessoa.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoa.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<PessoaFisica> PessoaFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Contato> Contato { get; set; }
    }
}