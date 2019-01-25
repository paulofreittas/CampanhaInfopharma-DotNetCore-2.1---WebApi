using System.Collections.Generic;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    [Route("api/[Controller]")]
    [DisableCors]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        // [HttpGet]
        // public IEnumerable<Cliente> GetAll() {
        //     return _clienteRepository.GetAll();
        // }

        [HttpGet("{id}", Name="id")]
        public Cliente FindById(int id) {
            return _clienteRepository.Find(id);
        }

        [HttpGet]
        public DrogariaDTO GetWithParams([FromQuery(Name = "search")] string search, [FromQuery(Name = "semFuncVinculado")] bool semFuncVinculado, [FromQuery(Name = "page")] int page)
        {
            return _clienteRepository.GetWithParams(search, semFuncVinculado, page);
        }
    }
}