using System;
using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    [Authorize()]
    [Route("api/[Controller]")]
    [EnableCors("AllowAll")]
    public class ContatoDrogariaController : Controller
    {
        private readonly IContatoDrogariaRepository _contatoDrogariaRepository;
        // private readonly IDrogariaRepository _drogariaRepository;
        public ContatoDrogariaController(IContatoDrogariaRepository contatoDrogariaRepository)
        {
            _contatoDrogariaRepository = contatoDrogariaRepository;
            // _drogariaRepository = drogariaRepository;
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
            var contatoDrog = _contatoDrogariaRepository.Find(id);

            if (contatoDrog == null)
                return NotFound();

            return new ObjectResult(contatoDrog);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Contatousuariocampanha contatoDrogaria)
        {
            if (contatoDrogaria == null || contatoDrogaria.ClienteIdFk == 0)
                return BadRequest();

            if (contatoDrogaria?.Status != 2)
                contatoDrogaria.DataRetorno = null;
            
            contatoDrogaria.DataInclusao = DateTime.Now;
            contatoDrogaria.DataAlteracao = DateTime.Now;
            contatoDrogaria.CampanhaRenovacaoIdFk = 1; // hardcode

            _contatoDrogariaRepository.Add(contatoDrogaria);

            return CreatedAtRoute("GetContatoDrogaria", new {Id = contatoDrogaria.IdPk}, contatoDrogaria);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _contatoDrogariaRepository.Remove(id);
            }
            catch (Exception e)
            {
                return NotFound();
            }

            return new NoContentResult();
        }
    }
}