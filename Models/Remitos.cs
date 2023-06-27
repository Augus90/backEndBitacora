using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_bitadora.Models
{
    public class Remitos
    {
        public long Id { get; set; }
        public int numero { get; set; }
        public int E4 { get; set; }
        public int E4T { get; set; }
        public int GPS { get; set; }
        public int Tx860 { get; set; }
        public int Tx700 { get; set; }
        public int Tx840 { get; set; }
        public string? accesorios { get; set; }
        public string? createdAt { get; set; }
        public string? recivedAt { get; set; }
        public string? compromisedAt { get; set; }
        public string? estado { get; set; }
        public string? agencia { get; set; }
        public string? detalle { get; set; }
        public string? retira { get; set; }

        
    }
}