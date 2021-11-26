using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace emigrant.Models
{
    public class ConexionDB
    {
       static private string stringConexion = @"Data Source =(LocalDB)\scorpion;AttachDbFilena= |DataDirectory|\emigrant.mdf;Integrated Security=True";

        private SqlConnection conexion = new SqlConnection(stringConexion);

        public SqlConnection abrirConexion()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                Console.WriteLine("Conexion Abierta");
                conexion.Open();
            }

            return conexion;
        }



        
       
    }
}