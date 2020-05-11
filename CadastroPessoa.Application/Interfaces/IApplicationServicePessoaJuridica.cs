using CadastroPessoa.Application.Dtos;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Interfaces
{
    public interface IApplicationServicePessoaJuridica
    {
        void Add(PessoaJuridicaDto pessoaJuridicaDto);

        void Update(PessoaJuridicaDto pessoaJuridicaDto);

        void Remove(PessoaJuridicaDto pessoaJuridicaDto);

        IEnumerable<PessoaJuridicaDto> GetAll();

        PessoaJuridicaDto GetById(int id);
    }
}