﻿using System;
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
    public partial class frmPesagem : Form
    {
        public frmPesagem()
        {
            InitializeComponent();
        }

        private void frmPesagem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_PesagemConsulta_Grid' table. You can move, or remove it, as needed.
            this.vw_PesagemConsulta_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_PesagemConsulta_Grid);
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_PesagemConsulta_Grid' table. You can move, or remove it, as needed.
            this.vw_PesagemConsulta_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_PesagemConsulta_Grid);
            
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            frmPesagemEntrada pesagemEntrada = new frmPesagemEntrada();

            this.Enabled = false;
            pesagemEntrada.StartPosition = FormStartPosition.CenterScreen;
            pesagemEntrada.ShowDialog();
            this.Enabled = true;
        }
    }
}
