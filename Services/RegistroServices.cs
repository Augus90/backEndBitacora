using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_bitadora.Models;
using back_bitadora.Context;

namespace back_bitadora.Services
{
    public interface IRegistroService{
        IEnumerable<Registro> getListaCompletaRegistros();
        RegistroResponse getListaCompaginada(float resultadosPorPagina, int pagina);
        IEnumerable<Registro> getListaCompaginada2(float resultadosPorPagina, int pagina);
        double getTotalDePaginas(float resultadosPorPagina);
        int addRegistroALaLista(Registro registro);
        int deleteRegistro(Registro registro);
    }

    public class RegistroServices : IRegistroService
    {
        private readonly ListadoDeRemitosContext _context;

        public RegistroServices(ListadoDeRemitosContext context) {
            _context = context;
        }

        public int addRegistroALaLista(Registro registro)
        {
            _context.Registros.Add(registro);
            return _context.SaveChanges();
        }

        public int deleteRegistro(Registro registro)
        {
            _context.Registros.Where( r => r.Id == registro.Id).First().active = false;
            return _context.SaveChanges();
        }

        public RegistroResponse getListaCompaginada(float resultadosPorPagina, int pagina)
        {
            var registrosPaginados = _context.Registros
                .OrderByDescending(r => r.Id)
                .Skip((pagina - 1) * (int)resultadosPorPagina)
                .Take((int) resultadosPorPagina)
                .ToList();

            // var response = registrosPaginados;

            var response = new RegistroResponse{
                pageNumber = pagina,
                PageMax = getTotalDePaginas(resultadosPorPagina),
                Registros = registrosPaginados,
            };
            return response;
        }

        public IEnumerable<Registro> getListaCompaginada2(float resultadosPorPagina, int pagina)
        {
            var registrosPaginados = _context.Registros
                .Skip((pagina - 1) * (int)resultadosPorPagina)
                .Take((int) resultadosPorPagina)
                .ToList();

            var response = registrosPaginados;

            // var response = new RegistroResponse{
            //     pageNumber = pagina,
            //     PageMax = getTotalDePaginas(resultadosPorPagina),
            //     Registros = registrosPaginados,
            // };
            return response;
        }

        public double getTotalDePaginas(float resultadosPorPagina){

            return Math.Ceiling(_context.Registros.Count() / resultadosPorPagina);
        }

        public IEnumerable<Registro> getListaCompletaRegistros()
        {
            return _context.Registros
                .Where(r => r.active == true)
                .ToList();
        }
    }
}