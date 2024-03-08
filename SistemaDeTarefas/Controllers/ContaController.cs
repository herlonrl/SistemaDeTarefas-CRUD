using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SistemaDeTarefas.Models;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login.Login == "admin" && login.Senha == "admin") 
            {
                var token = GerarTokenJWT();
                return Ok(new { token });
            }

            return BadRequest(new { mensagem = "Credencial inválida. Verifique usuário e senha."});
        }

        private string GerarTokenJWT()
        {
            string chaveSecreta = "6775749f-201d-4119-b46a-7502d87315e9";

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(chaveSecreta));
            var credencial = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("login", "admin"),
                new Claim("nome", "Administrador do Sistema")
            };

            var token = new JwtSecurityToken(
                 issuer: "sua_empresa",
                 audience: "sua_aplicacao",
                 claims: claims,
                 expires: DateTime.Now.AddHours(1),
                 signingCredentials: credencial
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
