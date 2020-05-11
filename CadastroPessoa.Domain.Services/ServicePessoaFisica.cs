using CadastroPessoa.Domain.Core.Interfaces.Repositories;
using CadastroPessoa.Domain.Core.Interfaces.Services;
using CadastroPessoa.Domain.Entities;

namespace CadastroPessoa.Domain.Services
{
    public class ServicePessoaFisica : ServiceBase<PessoaFisica>, IServicePessoaFisica
    {
        private readonly IRepositoryPessoaFisica repositoryPessoaFisica;

        public ServicePessoaFisica(IRepositoryPessoaFisica repositoryPessoaFisica) : base(repositoryPessoaFisica)
        {
            this.repositoryPessoaFisica = repositoryPessoaFisica;
        }
    }
}