using CadastroPessoa.Domain.Core.Interfaces.Repositories;
using CadastroPessoa.Domain.Core.Interfaces.Services;
using CadastroPessoa.Domain.Entities;

namespace CadastroPessoa.Domain.Services
{
    public class ServicePessoaJuridica : ServiceBase<PessoaJuridica>, IServicePessoaJuridica
    {
        private readonly IRepositoryPessoaJuridica repositoryPessoaJuridica;

        public ServicePessoaJuridica(IRepositoryPessoaJuridica repositoryPessoaJuridica) : base(repositoryPessoaJuridica)
        {
            this.repositoryPessoaJuridica = repositoryPessoaJuridica;
        }
    }
}