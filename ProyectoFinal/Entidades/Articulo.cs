using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Color { get; set; }
        public int Precio { get; set; }

        public Articulo()
        {
            ArticuloId = 0;
            Color = string.Empty;
            Precio = 0;
        }
    }
}
