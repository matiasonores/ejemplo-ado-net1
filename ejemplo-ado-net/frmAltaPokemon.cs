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
      private Pokemon pokemon = null;//3)declaramos tambien la variable privada
      public frmAltaPokemon()
      {
         InitializeComponent();
      }
      public frmAltaPokemon(Pokemon pokemon)//2)Es preciso ahora construir un constructor sobrecargado para el formulario del alta de pokemon
      {
         InitializeComponent();
         this.pokemon = pokemon;//4)Cuando pasamos un pokemon como parametro, lo guardamos ahora en esa variable.
         Text = "Modificar Pokemon";
      }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         //Pokemon poke = new Pokemon();
         //Comentamos la variable poke y pasamos el uso de esos campos a pokemon (variable privada)
         PokemonNegocio negocio = new PokemonNegocio();

         /*try
         {
            //En este punto si quisiesemos hacer uso de esa variable, nos arrojaría el error de compilación de que el objeto está nulo. (Porque así fue declarado)

            //Agregamos un if para validar esto:

            if (pokemon == null) //Si llegamos hasta este punto y el pokemon es nulo significa que hay que declarar un nuevo pokemon
               pokemon = new Pokemon(); //Entonces damos la instrucción de crear un nuevo pokemon.

            pokemon.Numero = int.Parse(txtNumero.Text);
            pokemon.Nombre = txtNombre.Text;
            pokemon.Descripcion = txtDescripcion.Text;
            pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
            pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;
            pokemon.UrlImagen = txtUrlImagen.Text;

            //Para poder elegir adecuadmaente entre estos dos pokemon, el valor de referencia que tenemos entre un pokemon nuevo y uno existente es la presencia de Id.
            //Agregamos la propiedad de Id en la clase Pokemon

            if (pokemon.Id != 0)
            {
               negocio.modificarPokemon(pokemon);
               MessageBox.Show("Modificado exitosamente");
            }
            else
            {
               negocio.agregarPokemon(pokemon);
               MessageBox.Show("Agregado exitosamente");
            }
            Close();
         }
         catch (Exception ex)
         {
            //MessageBox.Show(ex.ToString());
            throw ex;
         }*/
         try
         {
            if (pokemon == null)
               pokemon = new Pokemon();

            pokemon.Numero = int.Parse(txtNumero.Text);
            pokemon.Nombre = txtNombre.Text;
            pokemon.Descripcion = txtDescripcion.Text;
            pokemon.UrlImagen = txtUrlImagen.Text;
            pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
            pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

            if (pokemon.Id != 0)
            {
               negocio.modificarPokemon(pokemon);
               MessageBox.Show("Modificado exitosamente");
            }
            else
            {
               negocio.agregarPokemon(pokemon);
               MessageBox.Show("Agregado exitosamente");
            }

            Close();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }
      

      private void frmAltaPokemon_Load(object sender, EventArgs e)
      {
         ElementoNegocio elementoNegocio = new ElementoNegocio();

         try
         {
            cboTipo.DataSource = elementoNegocio.listar();
            cboTipo.ValueMember = "Id";//6)Asignamos un value
            cboTipo.DisplayMember = "Descripcion";//7)Asignamos un display
            cboDebilidad.DataSource = elementoNegocio.listar();
            cboDebilidad.ValueMember = "Id";
            cboDebilidad.DisplayMember = "Descripcion";


            if (pokemon != null) //5)Agregamos la validación para la carga de un pokemon
            {
               txtNumero.Text = pokemon.Numero.ToString();
               txtNombre.Text = pokemon.Nombre;
               txtDescripcion.Text = pokemon.Descripcion;
               txtUrlImagen.Text = pokemon.UrlImagen;
               cargarImagen(pokemon.UrlImagen);
               cboTipo.SelectedValue = pokemon.Tipo.Id;//8)
               cboDebilidad.SelectedValue = pokemon.Debilidad.Id;//9)
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }

      private void txtUrlImagen_Leave(object sender, EventArgs e)
      {
         cargarImagen(txtUrlImagen.Text);
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
   }   
}

