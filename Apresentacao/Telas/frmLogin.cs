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
using Negocio;
using Apresentacao.Util;


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

            UsuarioBus ubs = new UsuarioBus();
            
            String senhaCripto = Criptografia.GetMD5Hash(txtSenha.Text);
            usu = ubs.validaLogin(txtLogin.Text, senhaCripto);

            if (usu != null){
                Principal principal = new Principal(usu);
                this.Visible = false;
                principal.Show();
                
            } else {

                MessageBox.Show("Usuário ou senha incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
