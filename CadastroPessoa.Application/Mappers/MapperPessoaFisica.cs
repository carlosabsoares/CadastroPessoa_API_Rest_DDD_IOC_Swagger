using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces.Mappers;
using CadastroPessoa.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CadastroPessoa.Infra.CrossCutting.Mapper
{
    public class MapperPessoaFisica : IMapperPessoaFisica
    {
        private IEnumerable<PessoaFisicaDto> pessoaFisicaDtos = new List<PessoaFisicaDto>();

        public PessoaFisica MapperDtoToEntity(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = new PessoaFisica()
            {
                Id = pessoaFisicaDto.Id,
                Nome = pessoaFisicaDto.Nome,
                Endereco = pessoaFisicaDto.Endereco,
                Email = pessoaFisicaDto.Email,
                Telefone = pessoaFisicaDto.Telefone,
                Contato = pessoaFisicaDto.Contato,
                CPF = pessoaFisicaDto.CPF
            };

            return pessoaFisica;
        }

        public PessoaFisicaDto MapperEntityToDto(PessoaFisica pessoaFisica)
        {
            var pessoaFisicaDto = new PessoaFisicaDto()
            {
                Id = pessoaFisica.Id,
                Nome = pessoaFisica.Nome,
                Endereco = pessoaFisica.Endereco,
                Email = pessoaFisica.Email,
                Telefone = pessoaFisica.Telefone,
                Contato = pessoaFisica.Contato,
                CPF = pessoaFisica.CPF
            };

            return pessoaFisicaDto;
        }

        public IEnumerable<PessoaFisicaDto> MapperListPessoaFisicaDto(IEnumerable<PessoaFisica> pessoaFisicas)
        {
            var dto = pessoaFisicas.Select(c => new PessoaFisicaDto()
            {
                Id = c.Id,
                Nome = c.Nome,
                Endereco = c.Endereco,
                Telefone = c.Telefone,
                Email = c.Email,
                CPF = c.CPF,
                Contato = c.Contato
            });

            return dto;
        }
    }
}