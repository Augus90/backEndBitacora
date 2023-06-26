using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_bitadora.Models;
using back_bitadora.Context;

namespace back_bitadora.Services
{

    public interface IAgenciaService{
        List<Agencias> Listar();
        int Agregar(Agencias agencias);
    }

    public class AgenciaServices : IAgenciaService
    {
        private readonly ListadoDeRemitosContext _context;

        public AgenciaServices(ListadoDeRemitosContext context){
            _context = context;
        }

        public int Agregar(Agencias agencias)
        {
            _context.Agencias.Add(agencias);
            return _context.SaveChanges();
        }

        public List<Agencias> Listar()
        {
            return _context.Agencias.ToList();
        }
    }
}