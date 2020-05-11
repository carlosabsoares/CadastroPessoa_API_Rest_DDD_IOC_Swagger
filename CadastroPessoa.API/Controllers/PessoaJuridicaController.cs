using CadastroPessoa.Application.Dtos;
using CadastroPessoa.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CadastroPessoa.API.Controllers
{
    [Route("pessoajuridica")]
    [ApiController]
    public class PessoaJuridicaController : Controller
    {
        private readonly IApplicationServicePessoaJuridica applicationServicePessoaJuridica;

        public PessoaJuridicaController(IApplicationServicePessoaJuridica applicationServicePessoaJuridica)
        {
            this.applicationServicePessoaJuridica = applicationServicePessoaJuridica;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServicePessoaJuridica.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServicePessoaJuridica.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PessoaJuridicaDto pessoaJuridicaDTO)
        {
            try
            {
                if (pessoaJuridicaDTO == null)
                    return NotFound();

                applicationServicePessoaJuridica.Add(pessoaJuridicaDTO);
                return Ok("Pessoa Juridica Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PessoaJuridicaDto pessoaJuridicaDTO)
        {
            try
            {
                if (pessoaJuridicaDTO == null)
                    return NotFound();

                applicationServicePessoaJuridica.Update(pessoaJuridicaDTO);
                return Ok("Pessoa Juridica Atualizada com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PessoaJuridicaDto pessoaJuridicaDTO)
        {
            try
            {
                if (pessoaJuridicaDTO == null)
                    return NotFound();

                applicationServicePessoaJuridica.Remove(pessoaJuridicaDTO);
                return Ok("Pessoa Juridica Removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}