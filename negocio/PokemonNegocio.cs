using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.SqlClient;
using dominio;

namespace negocio
{
   public class PokemonNegocio
   {
      public List<Pokemon> listar()
      {
         List<Pokemon> lista = new List<Pokemon>();
         SqlConnection conexion = new SqlConnection(); 
         SqlCommand comando = new SqlCommand(); 
         SqlDataReader lector; 


         try
         {
            conexion.ConnectionString = "server=STAR-DESTROYER\\SQLEXPRESS; database=POKEDEX_DB; integrated security = true";
            comando.CommandType = System.Data.CommandType.Text;
            //comando.CommandText = "Select Numero, Nombre, Descripcion, UrlImagen from POKEMONS";//Agregamos la solicitud a la instruccion de consulta a la base de datos.
            comando.CommandText = "Select Numero, Nombre, P.Descripcion, E.Descripcion Tipo, D.Descripcion Debilidad, UrlImagen from POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";//Modificamos la consulta a la base de datos:
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
               Pokemon aux = new Pokemon();
               aux.Numero = lector.GetInt32(0);
               aux.Nombre = (string)lector["Nombre"];
               aux.Descripcion = (string)lector["Descripcion"];
               aux.UrlImagen = (string)lector["UrlImagen"];//Agregamos el mapeo al lector.
               aux.Tipo = new Elemento();
               aux.Tipo.Descripcion = (string)lector["Tipo"];//En el lector cargamos el Tipo obtenido de la consulta. Indicamos el indice de la columna Tipo
               aux.Debilidad = new Elemento();
               aux.Debilidad.Descripcion = (string)lector["Debilidad"];//En el lector cargamos la Debilidad obtenida de la consulta. Indicamos el indice de la columna Debilidad

               lista.Add(aux);
            }

            conexion.Close();

         return lista;

         }
         catch (Exception ex)
         {

            throw ex;
         }
      }
      public void agregarPokemon(Pokemon nuevo)
      {
         AccesoDatos datos = new AccesoDatos();

         try
         {
            datos.setearConsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo)values(" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "',1)");
            //Super artesanal pero es una manera de hacerlo.
            //Necesitamos crear ahora un método NonQuery.
            datos.ejecutarAccion();
         }
         catch (Exception ex)
         {
            throw ex;
         }
         finally
         {
            datos.cerrarConexion();
         }
      }

      public void modificarPokemon(Pokemon modificar)
      {
      
      }
   }
}
