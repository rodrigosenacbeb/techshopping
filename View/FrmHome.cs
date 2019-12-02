using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnGerenciarProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void btnMovimentarEstoque_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frmMovimentacaoEstoque = new FrmMovimentacaoEstoque();
            frmMovimentacaoEstoque.ShowDialog();
        }

        private void btnHistoricoMovimentacoes_Click(object sender, EventArgs e)
        {
            FrmConsultaEstoque frmConsultaEstoque = new FrmConsultaEstoque();
            frmConsultaEstoque.ShowDialog();
        }

        private void btnHistoricoVendas_Click(object sender, EventArgs e)
        {
            FrmConsultaVendas frmConsultaVendas = new FrmConsultaVendas();
            frmConsultaVendas.ShowDialog();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            FrmVenda frmVenda = new FrmVenda();
            frmVenda.Show();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            FrmConfiguracoes frmConfiguracoes = new FrmConfiguracoes();
            frmConfiguracoes.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sair do Sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
