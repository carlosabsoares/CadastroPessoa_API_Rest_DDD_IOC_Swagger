using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Interfaces.Mappers
{
    public interface IMapperContato
    {
        Contato MapperDtoToEntity(ContatoDto ContatoDto);

        IEnumerable<ContatoDto> MapperListContatoDto(IEnumerable<Contato> contato);

        ContatoDto MapperEntityToDto(Contato contato);
    }
}