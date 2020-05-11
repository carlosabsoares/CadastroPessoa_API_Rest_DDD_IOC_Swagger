using CadastroPessoa.Domain.Core.Interfaces.Repositories;
using CadastroPessoa.Domain.Entities;

namespace CadastroPessoa.Infra.Data.Repositories
{
    public class RepositoryPessoaJuridica : RepositoryBase<PessoaJuridica>, IRepositoryPessoaJuridica
    {
        private readonly SqlContext sqlContext;

        public RepositoryPessoaJuridica(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}