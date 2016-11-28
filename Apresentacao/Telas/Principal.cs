﻿using Entidade;
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
        frmLogin frmLogin;
    
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(Usuario usu,frmLogin frmlogin)
        {
            InitializeComponent();
            Principal.usuario = usu;
            frmLogin = frmlogin;
        }
        private void tipoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoMaterial tipoMaterial = new frmTipoMaterial();
            tipoMaterial.MdiParent = this;
            tipoMaterial.StartPosition = FormStartPosition.CenterScreen;
            tipoMaterial.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           

        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.Close();

        }
        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterial material = new frmMaterial();

            material.MdiParent = this;
            material.StartPosition = FormStartPosition.CenterScreen;
            material.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();

            cliente.MdiParent = this;
            cliente.StartPosition = FormStartPosition.CenterScreen;
            cliente.Show();
        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMotorista motorista = new frmMotorista();
            
            motorista.MdiParent = this;
            motorista.StartPosition = FormStartPosition.CenterScreen;
            motorista.Show();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculo veiculo = new frmVeiculo();
            
            veiculo.MdiParent = this;
            veiculo.StartPosition = FormStartPosition.CenterScreen;
            veiculo.Show();
        }

        private void registroDePesagemEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesagem pesagem = new frmPesagem();
            
            pesagem.MdiParent = this;
            pesagem.StartPosition = FormStartPosition.CenterScreen;
            pesagem.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();

            sobre.MdiParent = this;
            sobre.StartPosition = FormStartPosition.CenterScreen;
            sobre.Show();
        }

        private void registroDePesagemSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioDeEntradaESaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioPesagem relatorioPesagem = new frmRelatorioPesagem();

            relatorioPesagem.MdiParent = this;
            relatorioPesagem.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
    }
}
