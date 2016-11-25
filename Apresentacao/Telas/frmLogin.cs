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
            txtLogin.Text = "admin";
            txtSenha.Text = "123";
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
                Principal principal = new Principal(usu,this);
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtTemp = (TextBox)sender;
            //Verifica se já há uma vígula e se a tecla precionada for uma virgula impede a operação
            if (txtTemp.Text.Contains(",") && e.KeyChar == (char)44)
                {
                    e.Handled = true;
                }
            //Se não for número, vírgula ou backspace trava a tecla
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) &&
            !(e.KeyChar == (char)44))
            {
                e.Handled = true;
             }
        }
    }
}
