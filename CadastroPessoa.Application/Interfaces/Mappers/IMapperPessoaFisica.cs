using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Interfaces.Mappers
{
    public interface IMapperPessoaFisica
    {
        PessoaFisica MapperDtoToEntity(PessoaFisicaDto pessoaFisicaDto);

        IEnumerable<PessoaFisicaDto> MapperListPessoaFisicaDto(IEnumerable<PessoaFisica> pessoaFisicas);

        PessoaFisicaDto MapperEntityToDto(PessoaFisica pessoaFisica);
    }
}