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
        private readonly IRemitoService _remitoService;
        public RegistroController(IRegistroService service, IRemitoService remitoService){
            _registroService = service;
            _remitoService = remitoService;
        }

        [HttpGet("{pagina}")]
        public IActionResult getListaRegistroPaginado(int pagina, [FromQuery(Name = "page-size")] float pageSize=20f){
            var response = _registroService.getListaCompaginada(pageSize, pagina);
            
            return Ok(response);
        }

        [HttpPost]
        public IActionResult saveRemitoAlRegistro([FromBody]Remitos remito){
            
            if(remito == null){
                return BadRequest();
            }

            var result = _registroService.addRemitoALaListaRegistro(remito);

            if(result < 1){
                return BadRequest();
            }

            return Ok(); 
        }

        [HttpDelete("{id}")]
        public ActionResult<Remitos> deleteRegistro(int id){
            var registroBorrado = _registroService.deleteRegistro(id);
            var respuesta = new Remitos(registroBorrado);

            if(registroBorrado.Id < 1){ 
                return BadRequest();
            }
             
            respuesta.estado = "A DETERMINAR";

            var remitoSeGuardado = _remitoService.CrearRemito(respuesta);

            if(remitoSeGuardado < 1){
                return BadRequest();
            }

            return Ok(respuesta);
        }
    }
}