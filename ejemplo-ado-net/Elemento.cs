using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo_ado_net
{
   class Elemento//Modelamos la clase Elemento
   {
      public int Id { get; set; }
      public string Descripcion { get; set; }

      public override string ToString()//Sobreescribimos el método en la clase Elemento. 
      {
         return Descripcion;//Le indicamos que devuelva el valor de la property Descripcion.
      }
   }
}
