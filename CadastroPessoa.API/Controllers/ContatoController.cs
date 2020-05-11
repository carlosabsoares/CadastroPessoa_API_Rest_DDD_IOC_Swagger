using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CadastroPessoa.API.Controllers
{
    [Route("contato")]
    [ApiController]
    public class ContatoController : Controller
    {
        private readonly IApplicationServiceContato applicationServiceContato;

        public ContatoController(IApplicationServiceContato applicationServiceContato)
        {
            this.applicationServiceContato = applicationServiceContato;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceContato.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceContato.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ContatoDto contatoDTO)
        {
            try
            {
                if (contatoDTO == null)
                    return NotFound();

                applicationServiceContato.Add(contatoDTO);
                return Ok("Contato Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ContatoDto contatoDto)
        {
            try
            {
                if (contatoDto == null)
                    return NotFound();

                applicationServiceContato.Update(contatoDto);
                return Ok("Cadastro Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ContatoDto contatoDto)
        {
            try
            {
                if (contatoDto == null)
                    return NotFound();

                applicationServiceContato.Remove(contatoDto);
                return Ok("Cadastro Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}