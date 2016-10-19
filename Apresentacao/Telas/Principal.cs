using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Telas
{
    public partial class Principal : Form
    {
        public static Usuario usuario;
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(Usuario usu)
        {
            Principal.usuario = usu;

            InitializeComponent();
        }
        private void tipoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoMaterial tipoMaterial = new frmTipoMaterial();
            // Set the Parent Form of the Child window.
            tipoMaterial.MdiParent = this;
            // Display the new form.
            tipoMaterial.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterial material = new frmMaterial();
            // Set the Parent Form of the Child window.
            material.MdiParent = this;
            // Display the new form.
            material.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            // Set the Parent Form of the Child window.
            cliente.MdiParent = this;
            // Display the new form.
            cliente.Show();
        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMotorista motorista = new frmMotorista();
            // Set the Parent Form of the Child window.
            motorista.MdiParent = this;
            // Display the new form.
            motorista.Show();
        }
    }
}
