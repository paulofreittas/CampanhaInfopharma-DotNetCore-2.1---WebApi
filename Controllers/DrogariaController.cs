using System.Collections.Generic;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    [Route("api/[Controller]")]
    public class DrogariaController : Controller
    {
        private readonly IDrogariaRepository _drogariaRepository;
        public DrogariaController(IDrogariaRepository drogariaRepository)
        {
            _drogariaRepository = drogariaRepository;
        }

        [HttpGet]
        public IEnumerable<Drogaria> GetAll()
        {
            return _drogariaRepository.GetAll();
        }

        [HttpGet("{id}", Name="GetDrogaria")]
        public IActionResult FindById(int id)
        {
            var drog = _drogariaRepository.Find(id);

            if (drog == null)
                return NotFound();

            return new ObjectResult(drog);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Drogaria drogaria)
        {
            if (drogaria == null)
                return BadRequest();
            
            _drogariaRepository.Add(drogaria);

            return CreatedAtRoute("GetFuncionario", new {Id = drogaria.Id}, drogaria);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Drogaria drogaria)
        {
            if (drogaria == null || drogaria.Id != id)
                return BadRequest();

            var func = _drogariaRepository.Find(id);

            if (func == null)
                return BadRequest();

            _drogariaRepository.Update(drogaria);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var func = _drogariaRepository.Find(id);

            if (func == null)
                return NotFound();

            _drogariaRepository.Remove(id);

            return new NoContentResult();
        }
    }
}