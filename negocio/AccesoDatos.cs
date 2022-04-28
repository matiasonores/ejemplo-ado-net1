﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace negocio
{
   public class AccesoDatos
   {
      private SqlConnection conexion;
      private SqlCommand comando;
      private SqlDataReader lector;
      public SqlDataReader Lector
      {
         get { return lector; }
      }
      public AccesoDatos()
      {
         conexion = new SqlConnection("server=STAR-DESTROYER\\SQLEXPRESS; database=POKEDEX_DB; integrated security = true"); //...Lo declaramos como valor para el atributo privado.
         comando = new SqlCommand();
      }

      public void setearConsulta(string consulta)
      {
         comando.CommandType = System.Data.CommandType.Text;
         comando.CommandText = consulta;
      }
      public void ejecutarLectura()
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

      public void cerrarConexion()
      {
         if (lector != null)
            lector.Close();
         conexion.Close();
      }
      public void ejecutarAccion()
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
      public void setearParametro(string nombre, object value)
      {
         comando.Parameters.AddWithValue(nombre, value);
      }
   }
}
