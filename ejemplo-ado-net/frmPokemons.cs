using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ejemplo_ado_net
{
   public partial class frmPokemons : Form
   {
      private List<Pokemon> listaPokemon;//Dentro del código del formulario declaramos un atributo privado
      public frmPokemons()
      {
         InitializeComponent();
      }

      private void frmPokemons_Load(object sender, EventArgs e)
      {
         PokemonNegocio negocio = new PokemonNegocio();
         listaPokemon = negocio.listar();//En ella vamos a guardar el resultado de negocio.listar()

         dgvPokemons.DataSource = listaPokemon;//Ahora vamos a asignar el valor de la variable a dgvPokemon.DataSource.
         dgvPokemons.Columns["UrlImagen"].Visible = false;//Cambiamos la propiedad de visibilidad a falso para ocultarla.
         cargarImagen(listaPokemon[0].UrlImagen);//y ahora al picture box le pasamos el parametro de la lista. Encapsulamos despues reemplazando la instrucción pbxPokemon.Load por el método cargarImagen.
      }

      private void dgvPokemons_SelectionChanged(object sender, EventArgs e)//Agregamos evento en la grilla.
      {
         Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;//Nos devuelve un objeto de la fila seleccionada. Precisamos hacer un casteo explicito al tipo de objeto que estamos trabajando.
         cargarImagen(seleccionado.UrlImagen); //y ahora lo podemos almacenar en la pictureBox
      }
      private void cargarImagen(string imagen)//Modularizamos el codigo donde se repite la instrucción y agregamos el try catch.

      {
         try
         {
            pbxPokemon.Load(imagen);
         }
         catch (Exception ex)//Captura la excepcion de imagen faltante
         {
            pbxPokemon.Load("https://upload.wikimedia.org/wikipedia/commons/5/53/Pok%C3%A9_Ball_icon.svg");
         }
      }

   }
}
