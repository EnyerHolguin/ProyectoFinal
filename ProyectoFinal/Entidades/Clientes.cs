using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
    }
}
