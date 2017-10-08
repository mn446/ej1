using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ej1.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Key]
        public string mail { get; set; }
        public bool activo { get; set; }
    
    // Relaciones
        public Telefono tel { get; set; }
        public Evento evento { get; set; }
    
    }
}