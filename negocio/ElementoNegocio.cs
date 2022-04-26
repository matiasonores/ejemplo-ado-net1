using System;
using System.Collections.Generic;
using System.Text;
using dominio;

namespace negocio
{
   public class ElementoNegocio
   {
      public List<Elemento> listar()//Implementamos el uso de la clase AccesoDatos
      {
         List<Elemento> lista = new List<Elemento>();
         AccesoDatos datos = new AccesoDatos();
         try //Hacemos uso de los métodos para hacer una consulta a la BD
         {
            datos.setearConsulta("Select Id, Descripcion From ELEMENTOS");
            datos.ejecutarLectura();
            
            while (datos.Lector.Read())//Hacemos uso de la propiedad Lector para recorrer la lectura
            {
               Elemento aux = new Elemento();
               aux.Id = (int)datos.Lector["Id"];
               aux.Descripcion = (string)datos.Lector["Descripcion"];

               lista.Add(aux);
            }

            return lista;
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
   }
}
