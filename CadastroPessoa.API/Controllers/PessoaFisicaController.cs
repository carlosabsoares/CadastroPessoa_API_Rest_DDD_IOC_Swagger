using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CadastroPessoa.API.Controllers
{
    [Route("pessoafisica")]
    [ApiController]
    public class PessoaFisicaController : Controller
    {
        private readonly IApplicationServicePessoaFisica applicationServicePessoaFisica;

        public PessoaFisicaController(IApplicationServicePessoaFisica applicationServicePessoaFisica)
        {
            this.applicationServicePessoaFisica = applicationServicePessoaFisica;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServicePessoaFisica.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServicePessoaFisica.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PessoaFisicaDto pessoaFisicaDTO)
        {
            try
            {
                if (pessoaFisicaDTO == null)
                    return NotFound();

                applicationServicePessoaFisica.Add(pessoaFisicaDTO);
                return Ok("Pessoa Fisica Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PessoaFisicaDto pessoaFisicaDTO)
        {
            try
            {
                if (pessoaFisicaDTO == null)
                    return NotFound();

                applicationServicePessoaFisica.Update(pessoaFisicaDTO);
                return Ok("Pessoa Fisica Atualizada com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PessoaFisicaDto pessoaFisicaDTO)
        {
            try
            {
                if (pessoaFisicaDTO == null)
                    return NotFound();

                applicationServicePessoaFisica.Remove(pessoaFisicaDTO);
                return Ok("Pessoa Fisica Removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}