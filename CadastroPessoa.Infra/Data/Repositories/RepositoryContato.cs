using CadastroPessoa.Domain.Core.Interfaces.Repositories;
using CadastroPessoa.Domain.Entities;

namespace CadastroPessoa.Infra.Data.Repositories
{
    public class RepositoryContato : RepositoryBase<Contato>, IRepositoryContato
    {
        private readonly SqlContext sqlContext;

        public RepositoryContato(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}