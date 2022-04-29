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
            cargarImagen(listaPokemon[0].UrlImagen);
            ocultarColumnas();
         }
         catch (Exception ex)
         {

            MessageBox.Show(ex.ToString());
         }
      }
      private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
      {
         //Error SelectedIndexChanged 
         //Esto se puede generar al querer llevar adelante una funcionalidad programada para el evento de cargar la imagen
         //de una fila seleccionada, agregando una condición if se puede hacer:

         if (dgvPokemons.CurrentRow != null)//Si hay algo en la fila
         {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
         }
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

      private void btnEliminarFisico_Click(object sender, EventArgs e)
      {
         eliminar();
      }
      private void btnEliminarLogico_Click(object sender, EventArgs e)
      {
         eliminar(true);
      }

      private void eliminar(bool logico = false)
      {
         PokemonNegocio negocio = new PokemonNegocio();
         Pokemon seleccionado;

         try
         {
            DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Validación de la funcionalidad de eliminación física

            if (respuesta == DialogResult.Yes)
            {
               seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

               if (logico)
                  negocio.eliminarLogico(seleccionado.Id);
               else
               negocio.eliminarPokemon(seleccionado.Id);
               MessageBox.Show("Eliminado éxitosamente");
               cargar();
            }
         }

         catch (Exception ex)
         {
            throw ex;
         }
      }

      private void btnFiltro_Click(object sender, EventArgs e)
      {
         List<Pokemon> listaFiltrada;
         string filtro = txtFiltro.Text;
         if (filtro != "")//Generamos una condición para que muestre la lista completa si no hay filtros aplicados.
         {
            //Como la expresión de busqueda es una expresión lógica, podemos agregar otras condiciones lógicas:

            //listaFiltrada = listaPokemon.FindAll(x => x.Nombre == txtFiltro.Text);
            listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

         }
         else
         {
            listaFiltrada = listaPokemon;
         }
         //Expresión lambda:Esto es una suerte de foreach, que va a recorrer la colección comparando el nombre del objeto
         //y si existe una coincidencia los va a agregar a la nueva colección: listaFiltrada
         dgvPokemons.DataSource = null; //Limpiamos la grilla primero y luego la cargamos con el nuevo origen.
         dgvPokemons.DataSource = listaFiltrada;
         ocultarColumnas();
      }
      private void ocultarColumnas()//Encapsulamos tambien el método de ocultar las columnas en una función private para evitar repetir el código
      {
         dgvPokemons.Columns["UrlImagen"].Visible= false;
         dgvPokemons.Columns["Id"].Visible= false;
      }
}
}
