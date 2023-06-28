using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using back_bitadora.Services;
using back_bitadora.Models;

namespace back_bitadora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListadoRemitosController : ControllerBase
    {
        private IRemitoService _remitoService;

        public ListadoRemitosController(IRemitoService remitoService){
            _remitoService = remitoService;
        }

        [HttpGet]
        public IActionResult getAllRemitos(){
            var listRemitos = _remitoService.ListarTodos();

            return Ok(listRemitos);
        }

        [HttpPost]
        public IActionResult addRemito([FromBody] Remitos nuevoRemito){

            var result = _remitoService.CrearRemito( nuevoRemito );
            // var result = nuevoRemito.Length;
            Console.WriteLine("--------------------" + nuevoRemito.agencia + "--------------------");

            if(result > 0){
                return StatusCode(201);
            }else{
                return StatusCode(400);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult deleteRemito(int id){

            var result = _remitoService.EliminarRemito( id );
            
            if(result > 0){
                return StatusCode(200);
            }else{
                return StatusCode(404);
            }
        }
    }
}