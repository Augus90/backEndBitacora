using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_bitadora.Models;
using Microsoft.EntityFrameworkCore;


namespace back_bitadora.Context
{
    public class ListadoDeRemitosContext : DbContext
    {
        public ListadoDeRemitosContext()
        {
        }

        public ListadoDeRemitosContext(DbContextOptions<ListadoDeRemitosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agencias> Agencias { get; set; } = null!;
        public virtual DbSet<Remitos> Remitos { get; set; } = null!;       
        public virtual DbSet<Registro> Registros { get; set; } = null!;       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}
    }
}