using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace back_bitadora.Models
{
    public class RegistroResponse
    {
        public int pageNumber { get; set; }
        public List<Registro>? Registros { get; set; }
        public double PageMax { get; set; }

        // public RegistroResponse(int pageNumber, List<Registro> Regist , double PageMax){

        // }
    }
}