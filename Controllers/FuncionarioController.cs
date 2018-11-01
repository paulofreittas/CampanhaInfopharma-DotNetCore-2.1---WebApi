using System.Collections.Generic;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    [Authorize()]
    [Route("api/[Controller]")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpGet]
        public IEnumerable<Funcionario> GetAll()
        {
            return _funcionarioRepository.GetAll();
        }

        [HttpGet("{id}", Name="GetFuncionario")]
        public IActionResult FindById(int id)
        {
            var func = _funcionarioRepository.Find(id);

            if (func == null){
                return NotFound();
            }
            else {
                return new ObjectResult(func);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody]Funcionario funcionario)
        {
            if (funcionario == null)
                return BadRequest();
            
            _funcionarioRepository.Add(funcionario);

            return CreatedAtRoute("GetFuncionario", new {Id = funcionario.Id}, funcionario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Funcionario funcionario)
        {
            if (funcionario == null || funcionario.Id != id)
                return BadRequest();

            var func = _funcionarioRepository.Find(id);

            if (func == null)
                return BadRequest();

            _funcionarioRepository.Update(funcionario);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var func = _funcionarioRepository.Find(id);

            if (func == null)
                return NotFound();

            _funcionarioRepository.Remove(id);

            return new NoContentResult();
        }
    }
}