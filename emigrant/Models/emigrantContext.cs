using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace emigrant.Models
{
    public class emigrantContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public emigrantContext() : base("name=emigrantContext")
        {
        }

        public System.Data.Entity.DbSet<emigrant.Models.servicio> servicios { get; set; }

        public System.Data.Entity.DbSet<emigrant.Models.Emergencia> Emergencias { get; set; }

      //  public System.Data.Entity.DbSet<emigrant.Models.Calificacion> Calificacions { get; set; }

    }
}
