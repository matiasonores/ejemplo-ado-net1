using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ejemplo_ado_net
{
   static class Program
   {
      /// <summary>
      ///  The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.SetHighDpiMode(HighDpiMode.SystemAware);
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new frmPokemons());
      }
   }
}
