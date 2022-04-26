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

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         Pokemon poke = new Pokemon();
         PokemonNegocio negocio = new PokemonNegocio();

         try
         {
            poke.Numero = int.Parse(txtNumero.Text);
            poke.Nombre = txtNombre.Text;
            poke.Descripcion = txtDescripcion.Text;
            //Capturamos en la carga los tipos de los desplegables
            poke.Tipo = (Elemento)cboTipo.SelectedItem;//Casteamos el object a tipo Elemento.
            poke.Debilidad = (Elemento)cboDebilidad.SelectedItem;
            negocio.agregarPokemon(poke);
            MessageBox.Show("Agregado exitosamente");
            Close();
         }
         catch (Exception ex)
         {

            MessageBox.Show(ex.ToString());
         }
      }

      private void frmAltaPokemon_Load(object sender, EventArgs e)//Cargamos los desplegables en el evento de Load del formulario
      {
         ElementoNegocio elementoNegocio = new ElementoNegocio();

         try
         {
            cboTipo.DataSource = elementoNegocio.listar();
            cboDebilidad.DataSource = elementoNegocio.listar();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }
   }
}
