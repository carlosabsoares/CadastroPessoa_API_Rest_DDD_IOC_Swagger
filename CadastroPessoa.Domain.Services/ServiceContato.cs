using CadastroPessoa.Domain.Core.Interfaces.Repositories;
using CadastroPessoa.Domain.Core.Interfaces.Services;
using CadastroPessoa.Domain.Entities;

namespace CadastroPessoa.Domain.Services
{
    public class ServiceContato : ServiceBase<Contato>, IServiceContato
    {
        private readonly IRepositoryContato repositoryContato;

        public ServiceContato(IRepositoryContato repositoryContato) : base(repositoryContato)
        {
            this.repositoryContato = repositoryContato;
        }
    }
}