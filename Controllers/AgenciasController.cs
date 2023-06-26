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
    public class AgenciasController : ControllerBase
    {
        private IAgenciaService _agenciaService;

        public AgenciasController(IAgenciaService agenciaService){
            _agenciaService = agenciaService;
        }

        [HttpGet]
        public IActionResult getAgencias(){
            var listAgencias = _agenciaService.Listar();

            return Ok(listAgencias);
        }

        [HttpPost]
        public IActionResult addAgencia([FromBody] Agencias nuevaAgencia){

            var result = _agenciaService.Agregar( nuevaAgencia );

            if(result > 0){
                return StatusCode(201);
            }else{
                return StatusCode(400);
            }
        }
    }
}