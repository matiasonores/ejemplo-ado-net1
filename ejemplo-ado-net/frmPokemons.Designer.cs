
namespace ejemplo_ado_net
{
   partial class frmPokemons
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dgvPokemons = new System.Windows.Forms.DataGridView();
         this.pbxPokemon = new System.Windows.Forms.PictureBox();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.btnModificar = new System.Windows.Forms.Button();
         this.btnEliminarFisico = new System.Windows.Forms.Button();
         this.btnEliminarLogico = new System.Windows.Forms.Button();
         this.lblFiltro = new System.Windows.Forms.Label();
         this.btnFiltro = new System.Windows.Forms.Button();
         this.txtFiltro = new System.Windows.Forms.TextBox();
         this.lblCriterio = new System.Windows.Forms.Label();
         this.cboCriterio = new System.Windows.Forms.ComboBox();
         this.cboCampo = new System.Windows.Forms.ComboBox();
         this.lblCampo = new System.Windows.Forms.Label();
         this.lblFiltroAvanzado = new System.Windows.Forms.Label();
         this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvPokemons
         // 
         this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
         this.dgvPokemons.Location = new System.Drawing.Point(12, 61);
         this.dgvPokemons.MultiSelect = false;
         this.dgvPokemons.Name = "dgvPokemons";
         this.dgvPokemons.RowHeadersWidth = 51;
         this.dgvPokemons.RowTemplate.Height = 29;
         this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvPokemons.Size = new System.Drawing.Size(840, 300);
         this.dgvPokemons.TabIndex = 0;
         this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
         // 
         // pbxPokemon
         // 
         this.pbxPokemon.Location = new System.Drawing.Point(870, 61);
         this.pbxPokemon.Name = "pbxPokemon";
         this.pbxPokemon.Size = new System.Drawing.Size(300, 300);
         this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbxPokemon.TabIndex = 1;
         this.pbxPokemon.TabStop = false;
         // 
         // btnAgregar
         // 
         this.btnAgregar.Location = new System.Drawing.Point(12, 367);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(94, 29);
         this.btnAgregar.TabIndex = 2;
         this.btnAgregar.Text = "Agregar";
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // btnModificar
         // 
         this.btnModificar.Location = new System.Drawing.Point(112, 367);
         this.btnModificar.Name = "btnModificar";
         this.btnModificar.Size = new System.Drawing.Size(94, 29);
         this.btnModificar.TabIndex = 3;
         this.btnModificar.Text = "Modificar";
         this.btnModificar.UseVisualStyleBackColor = true;
         this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
         // 
         // btnEliminarFisico
         // 
         this.btnEliminarFisico.Location = new System.Drawing.Point(212, 367);
         this.btnEliminarFisico.Name = "btnEliminarFisico";
         this.btnEliminarFisico.Size = new System.Drawing.Size(94, 29);
         this.btnEliminarFisico.TabIndex = 4;
         this.btnEliminarFisico.Text = "Eliminar";
         this.btnEliminarFisico.UseVisualStyleBackColor = true;
         this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
         // 
         // btnEliminarLogico
         // 
         this.btnEliminarLogico.Location = new System.Drawing.Point(312, 367);
         this.btnEliminarLogico.Name = "btnEliminarLogico";
         this.btnEliminarLogico.Size = new System.Drawing.Size(121, 29);
         this.btnEliminarLogico.TabIndex = 5;
         this.btnEliminarLogico.Text = "Eliminar Logico";
         this.btnEliminarLogico.UseVisualStyleBackColor = true;
         this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
         // 
         // lblFiltro
         // 
         this.lblFiltro.AutoSize = true;
         this.lblFiltro.Location = new System.Drawing.Point(12, 30);
         this.lblFiltro.Name = "lblFiltro";
         this.lblFiltro.Size = new System.Drawing.Size(46, 20);
         this.lblFiltro.TabIndex = 6;
         this.lblFiltro.Text = "Filtro:";
         // 
         // btnFiltro
         // 
         this.btnFiltro.Location = new System.Drawing.Point(751, 405);
         this.btnFiltro.Name = "btnFiltro";
         this.btnFiltro.Size = new System.Drawing.Size(94, 29);
         this.btnFiltro.TabIndex = 7;
         this.btnFiltro.Text = "Buscar";
         this.btnFiltro.UseVisualStyleBackColor = true;
         this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
         // 
         // txtFiltro
         // 
         this.txtFiltro.Location = new System.Drawing.Point(68, 27);
         this.txtFiltro.Name = "txtFiltro";
         this.txtFiltro.Size = new System.Drawing.Size(125, 27);
         this.txtFiltro.TabIndex = 8;
         this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
         // 
         // lblCriterio
         // 
         this.lblCriterio.AutoSize = true;
         this.lblCriterio.Location = new System.Drawing.Point(267, 409);
         this.lblCriterio.Name = "lblCriterio";
         this.lblCriterio.Size = new System.Drawing.Size(58, 20);
         this.lblCriterio.TabIndex = 9;
         this.lblCriterio.Text = "Criterio";
         // 
         // cboCriterio
         // 
         this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboCriterio.FormattingEnabled = true;
         this.cboCriterio.Location = new System.Drawing.Point(344, 405);
         this.cboCriterio.Name = "cboCriterio";
         this.cboCriterio.Size = new System.Drawing.Size(151, 28);
         this.cboCriterio.TabIndex = 10;
         // 
         // cboCampo
         // 
         this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboCampo.FormattingEnabled = true;
         this.cboCampo.Location = new System.Drawing.Point(89, 405);
         this.cboCampo.Name = "cboCampo";
         this.cboCampo.Size = new System.Drawing.Size(151, 28);
         this.cboCampo.TabIndex = 12;
         this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
         // 
         // lblCampo
         // 
         this.lblCampo.AutoSize = true;
         this.lblCampo.Location = new System.Drawing.Point(12, 409);
         this.lblCampo.Name = "lblCampo";
         this.lblCampo.Size = new System.Drawing.Size(57, 20);
         this.lblCampo.TabIndex = 11;
         this.lblCampo.Text = "Campo";
         // 
         // lblFiltroAvanzado
         // 
         this.lblFiltroAvanzado.AutoSize = true;
         this.lblFiltroAvanzado.Location = new System.Drawing.Point(522, 409);
         this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
         this.lblFiltroAvanzado.Size = new System.Drawing.Size(43, 20);
         this.lblFiltroAvanzado.TabIndex = 13;
         this.lblFiltroAvanzado.Text = "Filtro";
         // 
         // txtFiltroAvanzado
         // 
         this.txtFiltroAvanzado.Location = new System.Drawing.Point(599, 406);
         this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
         this.txtFiltroAvanzado.Size = new System.Drawing.Size(125, 27);
         this.txtFiltroAvanzado.TabIndex = 14;
         // 
         // frmPokemons
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1182, 453);
         this.Controls.Add(this.txtFiltroAvanzado);
         this.Controls.Add(this.lblFiltroAvanzado);
         this.Controls.Add(this.cboCampo);
         this.Controls.Add(this.lblCampo);
         this.Controls.Add(this.cboCriterio);
         this.Controls.Add(this.lblCriterio);
         this.Controls.Add(this.txtFiltro);
         this.Controls.Add(this.btnFiltro);
         this.Controls.Add(this.lblFiltro);
         this.Controls.Add(this.btnEliminarLogico);
         this.Controls.Add(this.btnEliminarFisico);
         this.Controls.Add(this.btnModificar);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.pbxPokemon);
         this.Controls.Add(this.dgvPokemons);
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(1200, 500);
         this.MinimumSize = new System.Drawing.Size(1200, 500);
         this.Name = "frmPokemons";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Pokemons";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.frmPokemons_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvPokemons;
      private System.Windows.Forms.PictureBox pbxPokemon;
      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.Button btnModificar;
      private System.Windows.Forms.Button btnEliminarFisico;
      private System.Windows.Forms.Button btnEliminarLogico;
      private System.Windows.Forms.Label lblFiltro;
      private System.Windows.Forms.Button btnFiltro;
      private System.Windows.Forms.TextBox txtFiltro;
      private System.Windows.Forms.Label lblCriterio;
      private System.Windows.Forms.ComboBox cboCriterio;
      private System.Windows.Forms.ComboBox cboCampo;
      private System.Windows.Forms.Label lblCampo;
      private System.Windows.Forms.Label lblFiltroAvanzado;
      private System.Windows.Forms.TextBox txtFiltroAvanzado;
   }
}

