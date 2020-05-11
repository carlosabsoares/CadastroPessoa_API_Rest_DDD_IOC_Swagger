using CadastroPessoa.Application.Dtos;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Interfaces
{
    public interface IApplicationServicePessoaFisica
    {
        void Add(PessoaFisicaDto pessoaFisicaDto);

        void Update(PessoaFisicaDto pessoaFisicaDto);

        void Remove(PessoaFisicaDto pessoaFisicaDto);

        IEnumerable<PessoaFisicaDto> GetAll();

        PessoaFisicaDto GetById(int id);
    }
}