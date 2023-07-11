using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_bitadora.Models
{
    public class Registro
    {
        public Registro(){}
        public Registro(Remitos remito){
            this.numero = remito.numero;
            this.E4 = remito.E4;
            this.E4T = remito.E4T;
            this.GPS = remito.GPS;
            this.Tx860 = remito.Tx860;
            this.Tx700 = remito.Tx700;
            this.Tx840 = remito.Tx840;
            this.MRD = remito.MRD;
            this.createdAt = remito.createdAt;
            this.recivedAt = remito.recivedAt;
            this.compromisedAt = remito.compromisedAt;
            this.detalle = remito.detalle;
            this.agencia = remito.agencia;
            this.accesorios = remito.accesorios; 
            this.retira = remito.retira;
            this.estado = "GUARDADO";
            this.completedAt = DateTime.Now.ToString("dd/MM/yyyy");
            this.active = true;

        }

        public long Id { get; set; }
        public int? numero { get; set; }
        public int E4 { get; set; }
        public int E4T { get; set; }
        public int GPS { get; set; }
        public int Tx860 { get; set; }
        public int Tx700 { get; set; }
        public int Tx840 { get; set; }
        public int MRD { get; set; }
        public string? accesorios { get; set; }
        public string? createdAt { get; set; }
        public string? recivedAt { get; set; }
        public string? compromisedAt { get; set; }
        public string? estado { get; set; }
        public string? agencia { get; set; }
        public string? detalle { get; set; }
        public string? retira { get; set; }
        public string? completedAt { get; set; }
        public bool active {get; set;}
    }
}