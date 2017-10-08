using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ej1.Models
{
    public class Evento
    {
        [Key]
        public string tipo { get; set; }
        [Key]
        public DateTime fecha { get; set; }

        // Relaciones
        public Usuario usuario { get; set; }

    }
}