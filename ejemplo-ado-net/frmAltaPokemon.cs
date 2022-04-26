using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ejemplo_ado_net
{
   public partial class frmAltaPokemon : Form
   {
      public frmAltaPokemon()
      {
         InitializeComponent();
      }

      private void btnCancelar_Click(object sender, EventArgs e)//Funcionalidad del botón Cancelar
      {
         this.Close();
      }

      private void btnAceptar_Click(object sender, EventArgs e)//1) Funcionalidad del botón Aceptar. Cargamos el pokemon nuevo
      {
         Pokemon poke = new Pokemon();
         // (2)La idea es capturas los datos del formulario. Ahora hay que cargar la consulta a la base de datos
         PokemonNegocio negocio = new PokemonNegocio();

         try
         {
            poke.Numero = int.Parse(txtNumero.Text);//Casteamos a número
            poke.Nombre = txtNombre.Text;
            poke.Descripcion = txtDescripcion.Text;

            negocio.agregarPokemon(poke);//(3)Mandamos el nuevo pokemon como argumento
            MessageBox.Show("Agregado exitosamente");
            Close();
         }
         catch (Exception ex)
         {

            MessageBox.Show(ex.ToString());
         }
      }
     

   }
}
