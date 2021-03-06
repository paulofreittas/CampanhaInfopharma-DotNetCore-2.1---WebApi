using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace CampanhaInfopharma.Controllers
{
    [Route("api/[Controller]")]
    [EnableCors("AllowAll")]
    public class AuthorizationController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IFuncionarioRepository _funcionarioRepository;

        public AuthorizationController(IConfiguration configuration, IFuncionarioRepository funcionarioRepository)
        {
            _configuration = configuration;
            _funcionarioRepository = funcionarioRepository;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] Usuario request)
        {
            var func = _funcionarioRepository.GetAll().Where(c => c.Username == request.Username && c.Password == request.Password).FirstOrDefault();

            if (func != null)
            {
                var claims = new[]{
                    new Claim("nome", func?.Nome)
                };

                // recebe uma instância da classe SymmetricSecurityKey
                // armazendando a chave de criptografia usada na criação do token
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));

                // recebe um objeto do tipo SigninCredentials contendo a chave de criptografia e o algoritmo de segurança
                // empregados na geração de assinaturas digitais para tokens
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // gerando o token
                var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddHours(10),
                    signingCredentials: creds
                );

                return Ok (new {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    idPk = func.IdPk,
                    username = func.Username,
                    password = func.Password,
                    nome = func.Nome,
                    cor = func.Cor
                });
            }

            return BadRequest("Dados inválidos!");
        }
    }
}