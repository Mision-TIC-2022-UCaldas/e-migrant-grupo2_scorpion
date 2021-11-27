using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace emigrant.Models
{
    public class appCalificasion
    {
        [Key]
        public int id { get; set; }
        private String calificacion { set; get; }
    }
}