using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace emigrant.Models
{
    public class EmigranteDB
    {

        private ConexionDB conexion = new ConexionDB();

        private SqlCommand comando = new SqlCommand();

        private SqlDataAdapter leer;

        public int registrarMigrante(Emigrante migrante)
        {
            comando.Connection = conexion.abrirConexion();


            return 0;
        }
    }
}