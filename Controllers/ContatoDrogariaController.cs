using System;
using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    [Authorize()]
    [Route("api/[Controller]")]
    [DisableCors]
    public class ContatoDrogariaController : Controller
    {
        private readonly IContatoDrogariaRepository _contatoDrogariaRepository;
        private readonly IDrogariaRepository _drogariaRepository;
        public ContatoDrogariaController(IContatoDrogariaRepository contatoDrogariaRepository, IDrogariaRepository drogariaRepository)
        {
            _contatoDrogariaRepository = contatoDrogariaRepository;
            _drogariaRepository = drogariaRepository;
        }

        [HttpGet]
        public ContatoDrogariaDTO GetWithParams([FromQuery(Name = "drogariaId")] int drogariaId, [FromQuery(Name = "funcionarioId")] int funcionarioId, [FromQuery(Name = "search")] string search, [FromQuery(Name = "page")] int page)
        {
            if (drogariaId > 0)
            {
                var result = _contatoDrogariaRepository.FindByDrogariaId(drogariaId);

                return new ContatoDrogariaDTO {
                    NumeroResultados = 15,
                    Pagina = 1,
                    Resultado = result
                };
            }
            else if (funcionarioId > 0)
            {
                var result = _contatoDrogariaRepository.FindByFuncionarioId(funcionarioId, search, page);

                return new ContatoDrogariaDTO {
                    NumeroResultados = result.Key,
                    Pagina = page,
                    Resultado = result.Value
                };
            }

            return null;
        }

        [HttpGet("{id}", Name="GetContatoDrogaria")]
        public IActionResult FindById(int id)
        {
            var conatoDrog = _contatoDrogariaRepository.Find(id);

            if (conatoDrog == null)
                return NotFound();

            return new ObjectResult(conatoDrog);
        }

        [HttpPost]
        public IActionResult Add([FromBody]ContatoDrogaria contatoDrogaria)
        {
            if (contatoDrogaria == null || contatoDrogaria.Drogaria?.Funcionario == null)
                return BadRequest();

            _drogariaRepository.Update(contatoDrogaria.Drogaria);
            
            contatoDrogaria.DataAlteracao = DateTime.Now;

            _contatoDrogariaRepository.Add(contatoDrogaria);

            return CreatedAtRoute("GetContatoDrogaria", new {Id = contatoDrogaria.Id}, contatoDrogaria);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contatoDrog = _contatoDrogariaRepository.Find(id);
                var numeroDeContatos = _contatoDrogariaRepository.FindByDrogariaId(contatoDrog.Drogaria.Id).ToList().Count;

                if (numeroDeContatos == 1)
                {
                    _contatoDrogariaRepository.Remove(id);

                    var drog = contatoDrog.Drogaria;

                    drog.Funcionario = null;

                    _drogariaRepository.Update(drog);
                }
                else {
                    _contatoDrogariaRepository.Remove(id);
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }

            return new NoContentResult();
        }
    }
}