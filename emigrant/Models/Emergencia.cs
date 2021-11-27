using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace emigrant.Models
{
    public class Emergencia
    {
        [Key]
        public int id { get; set; }
        public String descripcion { get; set; }
        public String solicitud { get; set; }
    }
}