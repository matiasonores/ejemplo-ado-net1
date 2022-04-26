using System;
using System.Collections.Generic;
using System.Text;

namespace dominio
{
   public class Elemento//Agregamos el public
   {
      public int Id { get; set; }
      public string Descripcion { get; set; }

      public override string ToString()
      {
         return Descripcion;
      }
   }
}
