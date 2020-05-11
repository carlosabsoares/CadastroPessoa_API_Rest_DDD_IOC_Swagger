using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces;
using CadastroPessoa.Application.Interfaces.Mappers;
using CadastroPessoa.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroPessoa.Application
{
    public class ApplicationServicePessoaJuridica : IApplicationServicePessoaJuridica
    {
        private readonly IServicePessoaJuridica servicePessoaJuridica;
        private readonly IMapperPessoaJuridica mapperPessoaJuridica;

        public ApplicationServicePessoaJuridica(IServicePessoaJuridica servicePessoaJuridica,
                                              IMapperPessoaJuridica mapperPessoaJuridica)
        {
            this.servicePessoaJuridica = servicePessoaJuridica;
            this.mapperPessoaJuridica = mapperPessoaJuridica;
        }

        public void Add(PessoaJuridicaDto pessoaJuridicaDto)
        {
            var pessoaJuridica = mapperPessoaJuridica.MapperDtoToEntity(pessoaJuridicaDto);
            servicePessoaJuridica.Add(pessoaJuridica);
        }

        public IEnumerable<PessoaJuridicaDto> GetAll()
        {
            var pessoasJuridicas = servicePessoaJuridica.GetAll();
            return mapperPessoaJuridica.MapperListPessoaJuridicaDto(pessoasJuridicas);
        }

        public PessoaJuridicaDto GetById(int id)
        {
            var pessoasJuridicas = servicePessoaJuridica.GetById(id);
            return mapperPessoaJuridica.MapperEntityToDto(pessoasJuridicas);
        }

        public void Remove(PessoaJuridicaDto pessoaJuridicaDto)
        {
            var pessoaJuridica = mapperPessoaJuridica.MapperDtoToEntity(pessoaJuridicaDto);
            servicePessoaJuridica.Remove(pessoaJuridica);
        }

        public void Update(PessoaJuridicaDto pessoaJuridicaDto)
        {
            var pessoaJuridica = mapperPessoaJuridica.MapperDtoToEntity(pessoaJuridicaDto);
            servicePessoaJuridica.Update(pessoaJuridica);
        }
    }
}