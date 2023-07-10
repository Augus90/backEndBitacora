using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using back_bitadora.Services;
using back_bitadora.Models;

namespace backEndBitacora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroController : ControllerBase
    {

        // private readonly  float CANTIDAD_DE_REMITOS_POR_PAGINA = 10f;

        private readonly IRegistroService _registroService;
        public RegistroController(IRegistroService service){
            _registroService = service;
        }

        [HttpGet("{pagina}")]
        public IActionResult getListaRegistroPaginado(int pagina, float CANTIDAD_DE_REMITOS_POR_PAGINA = 20f){
            var response = _registroService.getListaCompaginada(CANTIDAD_DE_REMITOS_POR_PAGINA, pagina);
            
            return Ok(response);
        }
    }
}