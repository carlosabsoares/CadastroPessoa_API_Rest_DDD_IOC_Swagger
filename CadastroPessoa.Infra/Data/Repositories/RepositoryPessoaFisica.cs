using CadastroPessoa.Domain.Core.Interfaces.Repositories;
using CadastroPessoa.Domain.Entities;

namespace CadastroPessoa.Infra.Data.Repositories
{
    public class RepositoryPessoaFisica : RepositoryBase<PessoaFisica>, IRepositoryPessoaFisica
    {
        private readonly SqlContext sqlContext;

        public RepositoryPessoaFisica(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}