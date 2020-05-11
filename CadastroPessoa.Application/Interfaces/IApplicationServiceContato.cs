using CadastroPessoa.Application.Dtos;
using System.Collections.Generic;

namespace CadastroPessoa.Application.Interfaces
{
    public interface IApplicationServiceContato
    {
        void Add(ContatoDto contatoDto);

        void Update(ContatoDto contatoDto);

        void Remove(ContatoDto contatoDto);

        IEnumerable<ContatoDto> GetAll();

        ContatoDto GetById(int id);
    }
}