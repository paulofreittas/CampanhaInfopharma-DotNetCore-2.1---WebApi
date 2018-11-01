using System.Collections.Generic;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    [Authorize()]
    [Route("api/[Controller]")]
    public class ContatoDrogariaController : Controller
    {
        private readonly IContatoDrogariaRepository _contatoDrogariaRepository;
        public ContatoDrogariaController(IContatoDrogariaRepository contatoDrogariaRepository)
        {
            _contatoDrogariaRepository = contatoDrogariaRepository;
        }

        [HttpGet]
        public IEnumerable<ContatoDrogaria> GetAll()
        {
            return _contatoDrogariaRepository.GetAll();
        }
    }
}