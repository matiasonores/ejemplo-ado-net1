﻿
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
         ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvPokemons
         // 
         this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvPokemons.Location = new System.Drawing.Point(12, 12);
         this.dgvPokemons.Name = "dgvPokemons";
         this.dgvPokemons.RowHeadersWidth = 51;
         this.dgvPokemons.RowTemplate.Height = 29;
         this.dgvPokemons.Size = new System.Drawing.Size(840, 300);
         this.dgvPokemons.TabIndex = 0;
         this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
         // 
         // pbxPokemon
         // 
         this.pbxPokemon.Location = new System.Drawing.Point(870, 12);
         this.pbxPokemon.Name = "pbxPokemon";
         this.pbxPokemon.Size = new System.Drawing.Size(300, 300);
         this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pbxPokemon.TabIndex = 1;
         this.pbxPokemon.TabStop = false;
         // 
         // btnAgregar
         // 
         this.btnAgregar.Location = new System.Drawing.Point(41, 380);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(94, 29);
         this.btnAgregar.TabIndex = 2;
         this.btnAgregar.Text = "Agregar";
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // frmPokemons
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1182, 453);
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

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvPokemons;
      private System.Windows.Forms.PictureBox pbxPokemon;
      private System.Windows.Forms.Button btnAgregar;
   }
}

