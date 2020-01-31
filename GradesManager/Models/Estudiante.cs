using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GradesManager.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        [Required]
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}