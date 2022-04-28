
namespace ejemplo_ado_net
{
   partial class frmAltaPokemon
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblNumero = new System.Windows.Forms.Label();
         this.lblNombre = new System.Windows.Forms.Label();
         this.lblDescripcion = new System.Windows.Forms.Label();
         this.txtNumero = new System.Windows.Forms.TextBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.txtDescripcion = new System.Windows.Forms.TextBox();
         this.btnAceptar = new System.Windows.Forms.Button();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.cboTipo = new System.Windows.Forms.ComboBox();
         this.cboDebilidad = new System.Windows.Forms.ComboBox();
         this.lblTipo = new System.Windows.Forms.Label();
         this.lblDebilidad = new System.Windows.Forms.Label();
         this.txtUrlImagen = new System.Windows.Forms.TextBox();
         this.lblUrlImagen = new System.Windows.Forms.Label();
         this.pbxPokemon = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
         this.SuspendLayout();
         // 
         // lblNumero
         // 
         this.lblNumero.AutoSize = true;
         this.lblNumero.Location = new System.Drawing.Point(33, 23);
         this.lblNumero.Name = "lblNumero";
         this.lblNumero.Size = new System.Drawing.Size(63, 20);
         this.lblNumero.TabIndex = 0;
         this.lblNumero.Text = "Número";
         // 
         // lblNombre
         // 
         this.lblNombre.AutoSize = true;
         this.lblNombre.Location = new System.Drawing.Point(33, 56);
         this.lblNombre.Name = "lblNombre";
         this.lblNombre.Size = new System.Drawing.Size(64, 20);
         this.lblNombre.TabIndex = 1;
         this.lblNombre.Text = "Nombre";
         // 
         // lblDescripcion
         // 
         this.lblDescripcion.AutoSize = true;
         this.lblDescripcion.Location = new System.Drawing.Point(9, 92);
         this.lblDescripcion.Name = "lblDescripcion";
         this.lblDescripcion.Size = new System.Drawing.Size(87, 20);
         this.lblDescripcion.TabIndex = 2;
         this.lblDescripcion.Text = "Descripción";
         // 
         // txtNumero
         // 
         this.txtNumero.Location = new System.Drawing.Point(129, 16);
         this.txtNumero.Name = "txtNumero";
         this.txtNumero.Size = new System.Drawing.Size(125, 27);
         this.txtNumero.TabIndex = 3;
         // 
         // txtNombre
         // 
         this.txtNombre.Location = new System.Drawing.Point(129, 53);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(125, 27);
         this.txtNombre.TabIndex = 4;
         // 
         // txtDescripcion
         // 
         this.txtDescripcion.Location = new System.Drawing.Point(129, 92);
         this.txtDescripcion.Name = "txtDescripcion";
         this.txtDescripcion.Size = new System.Drawing.Size(125, 27);
         this.txtDescripcion.TabIndex = 5;
         // 
         // btnAceptar
         // 
         this.btnAceptar.Location = new System.Drawing.Point(21, 312);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(94, 29);
         this.btnAceptar.TabIndex = 6;
         this.btnAceptar.Text = "Aceptar";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.Location = new System.Drawing.Point(172, 312);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(94, 29);
         this.btnCancelar.TabIndex = 7;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // cboTipo
         // 
         this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboTipo.FormattingEnabled = true;
         this.cboTipo.Location = new System.Drawing.Point(129, 186);
         this.cboTipo.Name = "cboTipo";
         this.cboTipo.Size = new System.Drawing.Size(125, 28);
         this.cboTipo.TabIndex = 8;
         // 
         // cboDebilidad
         // 
         this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDebilidad.FormattingEnabled = true;
         this.cboDebilidad.Location = new System.Drawing.Point(129, 220);
         this.cboDebilidad.Name = "cboDebilidad";
         this.cboDebilidad.Size = new System.Drawing.Size(125, 28);
         this.cboDebilidad.TabIndex = 9;
         // 
         // lblTipo
         // 
         this.lblTipo.AutoSize = true;
         this.lblTipo.Location = new System.Drawing.Point(57, 186);
         this.lblTipo.Name = "lblTipo";
         this.lblTipo.Size = new System.Drawing.Size(39, 20);
         this.lblTipo.TabIndex = 10;
         this.lblTipo.Text = "Tipo";
         // 
         // lblDebilidad
         // 
         this.lblDebilidad.AutoSize = true;
         this.lblDebilidad.Location = new System.Drawing.Point(21, 220);
         this.lblDebilidad.Name = "lblDebilidad";
         this.lblDebilidad.Size = new System.Drawing.Size(75, 20);
         this.lblDebilidad.TabIndex = 11;
         this.lblDebilidad.Text = "Debilidad";
         // 
         // txtUrlImagen
         // 
         this.txtUrlImagen.Location = new System.Drawing.Point(129, 136);
         this.txtUrlImagen.Name = "txtUrlImagen";
         this.txtUrlImagen.Size = new System.Drawing.Size(125, 27);
         this.txtUrlImagen.TabIndex = 13;
         this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
         // 
         // lblUrlImagen
         // 
         this.lblUrlImagen.AutoSize = true;
         this.lblUrlImagen.Location = new System.Drawing.Point(9, 136);
         this.lblUrlImagen.Name = "lblUrlImagen";
         this.lblUrlImagen.Size = new System.Drawing.Size(78, 20);
         this.lblUrlImagen.TabIndex = 12;
         this.lblUrlImagen.Text = "UrlImagen";
         // 
         // pbxPokemon
         // 
         this.pbxPokemon.Location = new System.Drawing.Point(273, 16);
         this.pbxPokemon.Name = "pbxPokemon";
         this.pbxPokemon.Size = new System.Drawing.Size(260, 260);
         this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbxPokemon.TabIndex = 14;
         this.pbxPokemon.TabStop = false;
         // 
         // frmAltaPokemon
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(682, 353);
         this.Controls.Add(this.pbxPokemon);
         this.Controls.Add(this.txtUrlImagen);
         this.Controls.Add(this.lblUrlImagen);
         this.Controls.Add(this.lblDebilidad);
         this.Controls.Add(this.lblTipo);
         this.Controls.Add(this.cboDebilidad);
         this.Controls.Add(this.cboTipo);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.txtDescripcion);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.txtNumero);
         this.Controls.Add(this.lblDescripcion);
         this.Controls.Add(this.lblNombre);
         this.Controls.Add(this.lblNumero);
         this.MaximumSize = new System.Drawing.Size(700, 400);
         this.MinimumSize = new System.Drawing.Size(700, 400);
         this.Name = "frmAltaPokemon";
         this.Text = "Nuevo Pokemon";
         this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblNumero;
      private System.Windows.Forms.Label lblNombre;
      private System.Windows.Forms.Label lblDescripcion;
      private System.Windows.Forms.TextBox txtNumero;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.TextBox txtDescripcion;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.Button btnCancelar;
      private System.Windows.Forms.ComboBox cboTipo;
      private System.Windows.Forms.ComboBox cboDebilidad;
      private System.Windows.Forms.Label lblTipo;
      private System.Windows.Forms.Label lblDebilidad;
      private System.Windows.Forms.TextBox txtUrlImagen;
      private System.Windows.Forms.Label lblUrlImagen;
      private System.Windows.Forms.PictureBox pbxPokemon;
   }
}