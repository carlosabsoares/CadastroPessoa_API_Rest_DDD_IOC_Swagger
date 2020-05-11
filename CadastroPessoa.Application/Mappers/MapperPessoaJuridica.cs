using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces.Mappers;
using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CadastroPessoa.Infra.CrossCutting.Mapper
{
    public class MapperPessoaJuridica : IMapperPessoaJuridica
    {
        private IEnumerable<PessoaJuridicaDto> pessoaJuridicaDtos = new List<PessoaJuridicaDto>();

        public PessoaJuridica MapperDtoToEntity(PessoaJuridicaDto pessoaJuridicaDto)
        {
            var pessoaJuridica = new PessoaJuridica()
            {
                Id = pessoaJuridicaDto.Id,
                Nome = pessoaJuridicaDto.Nome,
                Endereco = pessoaJuridicaDto.Endereco,
                Telefone = pessoaJuridicaDto.Telefone,
                Email = pessoaJuridicaDto.Email,
                CNPJ = pessoaJuridicaDto.CNPJ
            };

            return pessoaJuridica;
        }

        public PessoaJuridicaDto MapperEntityToDto(PessoaJuridica pessoaJuridica)
        {
            var pessoaJuridicaDto = new PessoaJuridicaDto()
            {
                Id = pessoaJuridica.Id,
                Nome = pessoaJuridica.Nome,
                Endereco = pessoaJuridica.Endereco,
                Telefone = pessoaJuridica.Telefone,
                Email = pessoaJuridica.Email,
                CNPJ = pessoaJuridica.CNPJ
            };

            return pessoaJuridicaDto;
        }

        public IEnumerable<PessoaJuridicaDto> MapperListPessoaJuridicaDto(IEnumerable<PessoaJuridica> pessoaJuridica)
        {
            var dto = pessoaJuridica.Select(c => new PessoaJuridicaDto()
            {
                Id = c.Id,
                Nome = c.Nome,
                Email = c.Email,
                Endereco = c.Endereco,
                Telefone = c.Telefone,
                CNPJ = c.CNPJ
            });

            return dto;
        }
    }
}