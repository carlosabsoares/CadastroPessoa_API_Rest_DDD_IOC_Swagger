using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Interfaces.Mappers
{
    public interface IMapperPessoaJuridica
    {
        PessoaJuridica MapperDtoToEntity(PessoaJuridicaDto pessoaJuridicaDto);

        IEnumerable<PessoaJuridicaDto> MapperListPessoaJuridicaDto(IEnumerable<PessoaJuridica> pessoaJuridica);

        PessoaJuridicaDto MapperEntityToDto(PessoaJuridica pessoaJuridica);
    }
}