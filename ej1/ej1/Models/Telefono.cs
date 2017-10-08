using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ej1.Models
{
    public class Telefono
    {
        [Key]
        public int numero { get; set; }
        public string tipo { get; set; }

        // Relaciones
        public Usuario usuario { get; set; }

    }
}