using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidade;

namespace Apresentacao.Telas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Codigo = 1;
            Principal principal = new Principal(usu);
            this.Visible = false;
            principal.Show();
        }
    }
}
