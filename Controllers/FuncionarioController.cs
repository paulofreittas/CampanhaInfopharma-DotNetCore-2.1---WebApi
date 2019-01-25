using System.Collections.Generic;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    // [Authorize()]
    [Route("api/[Controller]")]
    // [EnableCors("AllowAll")]
    [DisableCors]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IContatoDrogariaRepository _contatoDrogariaRepository;
        public FuncionarioController(IFuncionarioRepository funcionarioRepository, IContatoDrogariaRepository contatoDrogariaRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _contatoDrogariaRepository = contatoDrogariaRepository;
        }

        [HttpGet]
        public IEnumerable<Funcionario> GetAll([FromQuery(Name = "search")] string search)
        {
            if (string.IsNullOrEmpty(search))
                return _funcionarioRepository.GetAll();
            else 
                return _funcionarioRepository.GetWithParams(search);
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

            func.Nome = funcionario.Nome;
            func.Login = funcionario.Login;
            func.Senha = funcionario.Senha;
            func.CorMarcacao = funcionario.CorMarcacao;

            _funcionarioRepository.Update(func);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var func = _funcionarioRepository.Find(id);

            if (func == null)
                return NotFound();

            _contatoDrogariaRepository.DeleteAllByFuncionarioId(id);
            _funcionarioRepository.Remove(id);

            return new NoContentResult();
        }
    }
}