using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao.Telas;

namespace Apresentacao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // Usuario usu = new Usuario();
           // usu.Codigo = 1;
           // Application.Run(new Principal(usu));
           Application.Run(new frmLogin());

        }
        
            
    }
}
