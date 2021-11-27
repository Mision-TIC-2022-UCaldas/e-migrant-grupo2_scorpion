using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace emigrant.Models
{
    public class servicio
    {
        [Key]
        public int id { get; set; }
        public String categoria { get; set; }
        public String descripcion { get; set; }
        public String prioridad { get; set; }
        public String estado { get; set; }
    }
}