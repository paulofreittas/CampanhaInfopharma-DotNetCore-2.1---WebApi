using System;
using System.Collections.Generic;
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
        public IEnumerable<ContatoDrogaria> GetWithParams([FromQuery(Name = "drogariaId")] int drogariaId, [FromQuery(Name = "funcionarioId")] int funcionarioId)
        {
            if (drogariaId > 0)
                return _contatoDrogariaRepository.FindByDrogariaId(drogariaId);
            else if (funcionarioId > 0)
                return _contatoDrogariaRepository.FindByFuncionarioId(funcionarioId);

            return _contatoDrogariaRepository.GetAll();
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
    }
}