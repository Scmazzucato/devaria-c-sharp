using Microsoft.AspNetCore.Mvc;
using Minha_primeira_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minha_primeira_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Usuario_Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterUsuario()
        {
            var usuario = new Usuario()
            {
                Nome = "Teste",
                Email = "Teste@teste.com",
                Senha = "12345",
            };
            return Ok(usuario);
        }
    }
}
