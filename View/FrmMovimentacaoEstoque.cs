using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class FrmMovimentacaoEstoque : Form
    {
        public FrmMovimentacaoEstoque()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            ControllerMovimentacaoEstoque controllerMovimentacao = new ControllerMovimentacaoEstoque();
            try
            {
                Produto produto = controllerMovimentacao.CarregarProduto(txtCodigoBarras.Text.Trim());
                if(produto.Codigo <= 0)
                {
                    MessageBox.Show("Nenhum produto encontrado com esse código de barras!");
                }
                else
                {
                    txtCodigo.Text = produto.Codigo.ToString();
                    txtDescricao.Text = produto.Descricao;
                    txtUnidadeMedida.Text = produto.UnidadeMedida;
                    nudQtdeMinima.Value = produto.QtdMinima;
                    nudQtdeMaxima.Value = produto.QtdMaxima;
                    nudQtdeAtual.Value = produto.QtdAtual;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
