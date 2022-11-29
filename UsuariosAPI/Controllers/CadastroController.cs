using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Data.Requests;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private CadastroService _casdastroService;

        public CadastroController(CadastroService casdastroService)
        {
            _casdastroService = casdastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _casdastroService.CadastraUsuario(createDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes);
        }

        [HttpGet("/ativa")]

        public IActionResult AtivaContaUsuario([FromQuery] AtivaContaRequest request)
        {
            Result resultado = _casdastroService.AtivaContaUsuario(request);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes);
        
        }


    }
}
