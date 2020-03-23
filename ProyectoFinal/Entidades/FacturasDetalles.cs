using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class FacturasDetalles
    {
        [Key]
        public int FacturaId { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }
        public int SubTotal { get; set; }
        public int Itbis { get; set; }
        public int Total { get; set; }
        public int Recibido { get; set; }
        public int Cambio { get; set; }

        public FacturasDetalles()
        {
            FacturaId = 0;
            SubTotal = 0;
            Itbis = 0;
            Total = 0;
            Recibido = 0;
            Cambio = 0;
        }

        public FacturasDetalles( int subTotal, int itbis, int total, int recibido, int cambio)
        {
            FacturaId = 0;
            SubTotal = subTotal;
            Itbis = itbis;
            Total = total;
            Recibido = recibido;
            Cambio = cambio;
        }
    }
}
