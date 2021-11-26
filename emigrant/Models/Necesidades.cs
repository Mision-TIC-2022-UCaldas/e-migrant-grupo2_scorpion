using System;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace emigrant.Models
{
    public class Necesidades
    {
        [Key]
        public int IdNecesidad { get; set; }

        public string nombreNecesidad { get; set; }

        public string descipcion { get; set; }

        public string prioridad { get; set; }

        public String  Emigrante { get; set; }

    }
}