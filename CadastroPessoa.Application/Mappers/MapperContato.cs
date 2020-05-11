using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces.Mappers;
using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CadastroPessoa.Infra.CrossCutting.Mapper
{
    public class MapperContato : IMapperContato
    {
        private IEnumerable<ContatoDto> contatoDtos = new List<ContatoDto>();

        public Contato MapperDtoToEntity(ContatoDto contatoDto)
        {
            var contato = new Contato()
            {
                Id = contatoDto.Id,
                PessoaId = contatoDto.PessoaId,
                PessoasFisicas = contatoDto.PessoasFisicas
            };

            return contato;
        }

        public ContatoDto MapperEntityToDto(Contato contato)
        {
            var contatoDto = new ContatoDto()
            {
                Id = contato.Id,
                PessoaId = contato.PessoaId,
                PessoasFisicas = contato.PessoasFisicas
            };

            return contatoDto;
        }

        public IEnumerable<ContatoDto> MapperListContatoDto(IEnumerable<Contato> contato)
        {
            var dto = contato.Select(c => new ContatoDto()
            {
                Id = c.Id,
                PessoaId = c.PessoaId,
                PessoasFisicas = c.PessoasFisicas
            });

            return dto;
        }
    }
}