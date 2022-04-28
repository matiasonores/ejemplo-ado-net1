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
      private List<Pokemon> listaPokemon;
      public frmPokemons()
      {
         InitializeComponent();
      }

      private void frmPokemons_Load(object sender, EventArgs e)
      {
         cargar();
      }
      private void cargar()//Encapsulamos el evento de cargar la pantalla principal en un método private.
      {
         PokemonNegocio negocio = new PokemonNegocio();
         try
         {
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaPokemon[0].UrlImagen);
            dgvPokemons.Columns["Id"].Visible = false;//Ocultamos la columna Id
         }
         catch (Exception ex)
         {

            MessageBox.Show(ex.ToString());
         }
      }
      private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
      {
         Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
         cargarImagen(seleccionado.UrlImagen);
      }
      private void cargarImagen(string imagen)

      {
         try
         {
            pbxPokemon.Load(imagen);
         }
         catch (Exception ex)
         {
            pbxPokemon.Load("https://i.ebayimg.com/images/g/JeIAAOSwMbRhbexb/s-l400.jpg");
         }
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         frmAltaPokemon alta = new frmAltaPokemon();
         alta.ShowDialog();
         cargar();
      }

      private void btnModificar_Click(object sender, EventArgs e)//Para tocar un pokemon de la lista y que al momento de tocar un boton Modificar me cargue los datos del pokemon y me permita guardar los cambios.
      {
         Pokemon seleccionado;
         seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
         frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
         modificar.ShowDialog();
         cargar();

      }
   }
}
