﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace dominio
{
   public class Pokemon
   {
      [DisplayName("Número")]
      public int Numero { get; set; }
      public string Nombre { get; set; }
      [DisplayName("Descripción")]
      public string Descripcion { get; set; }

      public string UrlImagen { get; set; }

      public Elemento Tipo { get; set; }
      public Elemento Debilidad { get; set; }
      public int Id { get; set; } //Agregamos la consulta en SQL server

   }
}
