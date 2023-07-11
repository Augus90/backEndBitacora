using System.Net;
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

        [HttpPost]
        public IActionResult saveRemitoAlRegistro([FromBody]Remitos remito){
            
            if(remito == null){
                return BadRequest();
            }

            var result = _registroService.addRemitoAlRegistro(remito);

            if(result < 0){
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<Remitos> deleteRegistro(int id){
            var registroBorrado = _registroService.deleteRegistro(id);
            var respuesta = new Remitos(registroBorrado);

            if(registroBorrado.Id != 0){ 
                return Ok(respuesta);
            }else{
                return BadRequest();
            }
        }
    }
}