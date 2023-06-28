using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_bitadora.Models;
using back_bitadora.Context;

namespace back_bitadora.Services
{

    public interface IRemitoService{
        IEnumerable<Remitos> ListarTodos();
        int CrearRemito(Remitos remito);
        int EliminarRemito(int idABorrar);
    }

    public class RemitoServices : IRemitoService
    {
        private readonly ListadoDeRemitosContext _context;

        public RemitoServices(ListadoDeRemitosContext context){
            _context = context;
        }

        public IEnumerable<Remitos> ListarTodos()
        {
            return _context.Remitos.ToList();
        }

        public int CrearRemito(Remitos remito)
        {
            _context.Remitos.Add(remito);
            return _context.SaveChanges();
        }

        public int EliminarRemito(int idABorrar)
        {

            var remitoARemover = new Remitos();
            try{
                remitoARemover = _context.Remitos.Where(r => r.Id == idABorrar).First();
            }catch{
                return -1;
            }

            _context.Remitos.Remove(remitoARemover);
            return _context.SaveChanges();
        }
    }
}