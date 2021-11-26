using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace emigrant.Models
{
    public class Emigrante
    {   

        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]

        public string apellidos { get; set; }
        [Required]

        public string tipoIdentificacion { get; set; }
        [Required]

        public string numeroIdentificacion { get; set; }
        [Required]

        public string pais { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correoElectronico { get; set; }
        public string numeroTelefonico { get; set; }
        public string direccionActual { get; set; }
        public string ciudad { get; set; }
        public string situacionLaboral { get; set; }
    }
}