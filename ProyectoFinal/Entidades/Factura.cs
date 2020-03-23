using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Factura
    {
            [Key]
            public int FacturaId { get; set; }
            public DateTime Fecha { get; set; }
            public string Cajero { get; set; }
            public int Cantidad { get; set; }
            public int Precio { get; set; }
            public int Importe { get; set; }
            public int SubTotal { get; set; }
            public int Itbis { get; set; }
            public int Total { get; set; }
            public int Recibido { get; set; }
            public int Cambio { get; set; }
            [ForeignKey("FacturaId")]
             public virtual List<FacturasDetalles> Detalle { get; set; }
        public Factura()
            {
                FacturaId = 0;
                Fecha = DateTime.Now;              
                Cajero = string.Empty;
                Cantidad = 0;
                Precio = 0;
                Importe = 0;
                SubTotal = 0;
                Itbis = 0;
                Total = 0;
                Recibido = 0;
                Cambio = 0;
            }
        }
    }
