using Autofac;
using CadastroPessoa.Application;
using CadastroPessoa.Application.Interfaces;
using CadastroPessoa.Application.Interfaces.Mappers;
using CadastroPessoa.Domain.Core.Interfaces.Repositories;
using CadastroPessoa.Domain.Core.Interfaces.Services;
using CadastroPessoa.Domain.Services;
using CadastroPessoa.Infra.CrossCutting.Mapper;
using CadastroPessoa.Infra.Data.Repositories;

namespace CadastroPessoa.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServicePessoaFisica>().As<IApplicationServicePessoaFisica>();
            builder.RegisterType<ApplicationServicePessoaJuridica>().As<IApplicationServicePessoaJuridica>();
            builder.RegisterType<ApplicationServiceContato>().As<IApplicationServiceContato>();

            builder.RegisterType<ServicePessoaFisica>().As<IServicePessoaFisica>();
            builder.RegisterType<ServicePessoaJuridica>().As<IServicePessoaJuridica>();
            builder.RegisterType<ServiceContato>().As<IServiceContato>();

            builder.RegisterType<RepositoryPessoaFisica>().As<IRepositoryPessoaFisica>();
            builder.RegisterType<RepositoryPessoaJuridica>().As<IRepositoryPessoaJuridica>();
            builder.RegisterType<RepositoryContato>().As<IRepositoryContato>();

            builder.RegisterType<MapperPessoaFisica>().As<IMapperPessoaFisica>();
            builder.RegisterType<MapperPessoaJuridica>().As<IMapperPessoaJuridica>();
            builder.RegisterType<MapperContato>().As<IMapperContato>();

            #endregion IOC
        }
    }
}