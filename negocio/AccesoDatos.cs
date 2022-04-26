using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace negocio
{
   public class AccesoDatos//El destino de esta clase es centralizar la conexión a la base de datos
   {
      private SqlConnection conexion;
      private SqlCommand comando;
      private SqlDataReader lector;
      public SqlDataReader Lector//Nos brinda la posibilidad de leer el lector
      {
         get { return lector; }
      }
      public AccesoDatos()//En vez de pasar la cadena como argumento del constructor...
      {
         conexion = new SqlConnection("server=STAR-DESTROYER\\SQLEXPRESS; database=POKEDEX_DB; integrated security = true"); //...Lo declaramos como valor para el atributo privado.
         comando = new SqlCommand();
      }

      public void setearConsulta(string consulta)//Esto encapsula la acción de darle un tipo y la query
      {
         comando.CommandType = System.Data.CommandType.Text;
         comando.CommandText = consulta;
      }
      public void ejecutarLectura()//Realiza la lectura y almacena el valor en el lector
      {
         comando.Connection = conexion;
         
         try
         {
            conexion.Open();
            lector = comando.ExecuteReader();
         }
         catch (Exception ex)
         {

            throw ex;
         }
      }

      public void cerrarConexion()//Cierra la conexión. Si el lector es distinto de nulo, cierra conexión.
      {
         if (lector != null)
            lector.Close();
         conexion.Close();
      }
      public void ejecutarAccion()//NonQuery
      {
         comando.Connection = conexion;
         try
         {
            conexion.Open();
            comando.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
   }
}
