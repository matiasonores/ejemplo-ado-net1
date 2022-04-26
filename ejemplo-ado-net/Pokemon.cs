using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo_ado_net
{
   class Pokemon
   {
      public int Numero { get; set; }
      public string Nombre { get; set; }
      public string Descripcion { get; set; }

      public string UrlImagen { get; set; }//Agregamos una propiedad nueva para guardar la URL de la imagen.

      public Elemento Tipo { get; set; }//Agregamos la propiedad Tipo de tipo Elemento
      public Elemento Debilidad { get; set; }//Agregamos la propiedad Debilidad de tipo Elemento


   }
}
