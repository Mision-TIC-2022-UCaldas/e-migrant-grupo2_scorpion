using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
namespace emigrant.Models
{
    public class Novedades
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int diasActivad { get; set; }

        [Required]
        public int TextoExplicativo { get; set; }
    }
}