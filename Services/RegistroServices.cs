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
        Registro? fetchRegistroById(long id);
        double getTotalDePaginas(float resultadosPorPagina);
        int addRegistroALaLista(Registro registro);
        Registro deleteRegistro(int id);
        int addRemitoALaListaRegistro(Remitos remito);
    }

    public class RegistroServices : IRegistroService
    {
        private readonly ListadoDeRemitosContext _context;

        public RegistroServices(ListadoDeRemitosContext context) {
            _context = context;
        }
        public Registro deleteRegistro(int id)
        {
            var registroBorrado = _context.Registros.Where( r => r.Id == id).First();
            registroBorrado.active = false;
            registroBorrado.estado = "BORRADO";

            var registroDeCambio = _context.SaveChanges();
            if(registroDeCambio >= 0){
                return registroBorrado;
            }else{
                return new Registro();
            }
        }

        public RegistroResponse getListaCompaginada(float resultadosPorPagina, int pagina)
        {
            var registrosPaginados = _context.Registros
                .Where(registro => registro.active == true)
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
                .Where(registro => registro.active == true)
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

        public int addRegistroALaLista(Registro registro)
        {
            var list = _context.Registros.Add(registro);
            return _context.SaveChanges();

        }

        public int addRemitoALaListaRegistro(Remitos remito)
        {
            var nuevoRegistro = new Registro(remito);

            return addRegistroALaLista(nuevoRegistro);

        }

        public Registro? fetchRegistroById(long id)
        {
            return _context.Registros.Where(r => r.Id == id && r.active == true).FirstOrDefault();
        }
    }
}