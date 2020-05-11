using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces;
using CadastroPessoa.Application.Interfaces.Mappers;
using CadastroPessoa.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroPessoa.Application
{
    public class ApplicationServicePessoaFisica : IApplicationServicePessoaFisica
    {
        private readonly IServicePessoaFisica servicePessoaFisica;
        private readonly IMapperPessoaFisica mapperPessoaFisica;

        public ApplicationServicePessoaFisica(IServicePessoaFisica servicePessoaFisica,
                                              IMapperPessoaFisica mapperPessoaFisica)
        {
            this.servicePessoaFisica = servicePessoaFisica;
            this.mapperPessoaFisica = mapperPessoaFisica;
        }

        public void Add(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = mapperPessoaFisica.MapperDtoToEntity(pessoaFisicaDto);
            servicePessoaFisica.Add(pessoaFisica);
        }

        public IEnumerable<PessoaFisicaDto> GetAll()
        {
            var pessoasFisicas = servicePessoaFisica.GetAll();
            return mapperPessoaFisica.MapperListPessoaFisicaDto(pessoasFisicas);
        }

        public PessoaFisicaDto GetById(int id)
        {
            var pessoasFisicas = servicePessoaFisica.GetById(id);
            return mapperPessoaFisica.MapperEntityToDto(pessoasFisicas);
        }

        public void Remove(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = mapperPessoaFisica.MapperDtoToEntity(pessoaFisicaDto);
            servicePessoaFisica.Remove(pessoaFisica);
        }

        public void Update(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = mapperPessoaFisica.MapperDtoToEntity(pessoaFisicaDto);
            servicePessoaFisica.Update(pessoaFisica);
        }
    }
}