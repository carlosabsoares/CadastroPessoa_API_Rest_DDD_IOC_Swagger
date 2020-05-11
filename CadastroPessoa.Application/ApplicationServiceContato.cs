using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces;
using CadastroPessoa.Application.Interfaces.Mappers;
using CadastroPessoa.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace CadastroPessoa.Application
{
    public class ApplicationServiceContato : IApplicationServiceContato
    {

        private readonly IServiceContato serviceContato;
        private readonly IMapperContato mapperContato;

        public ApplicationServiceContato(IServiceContato serviceContato,
                                         IMapperContato mapperContato)
        {
            this.serviceContato = serviceContato;
            this.mapperContato = mapperContato;
        }

        public void Add(ContatoDto contatoDto)
        {
            var contatos = mapperContato.MapperDtoToEntity(contatoDto);
            serviceContato.Add(contatos);
        }

        public IEnumerable<ContatoDto> GetAll()
        {
            var contatos = serviceContato.GetAll();
            return mapperContato.MapperListContatoDto(contatos);
        }

        public ContatoDto GetById(int id)
        {
            var contato = serviceContato.GetById(id);
            return mapperContato.MapperEntityToDto(contato);
        }

        public void Remove(ContatoDto contatoDto)
        {
            var contatos = mapperContato.MapperDtoToEntity(contatoDto);
            serviceContato.Remove(contatos);
        }

        public void Update(ContatoDto contatoDto)
        {
            var contatos = mapperContato.MapperDtoToEntity(contatoDto);
            serviceContato.Update(contatos);
        }
    }
}