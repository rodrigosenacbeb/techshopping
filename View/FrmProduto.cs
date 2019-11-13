using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(btnNovo.Text == "Novo")
            {
                btnNovo.Text = "Salvar";
                btnNovo.Image = Properties.Resources.tick;
                gbxInformacoesProduto.Enabled = true;
                btnAtualizar.Enabled = false;
            }
            else
            {
                // Montamos o objeto Produto com as informações para enviar para a controller.
                Produto produto = new Produto();
                produto.CodigoBarras = txtCodigoBarras.Text;
                produto.Descricao = txtDescricao.Text;
                produto.UnidadeMedida = cbxUnidadeMedida.SelectedText;
                produto.QtdMinima = (int)nudQtdeMinima.Value;
                produto.QtdAtual = (int)nudQtdeAtual.Value;
                produto.QtdMaxima = (int)nudQtdeMaxima.Value;
                produto.CustoUnitario = Convert.ToDouble(txtValorUnitario.Text);
                produto.PercentualLucro = Convert.ToDouble(txtPercentualLucro.Text);
                produto.PrecoVenda = Convert.ToDouble(txtPreco.Text);
                //IF ternário.
                produto.Ativo = ckbAtivo.Checked ? "Sim" : "Não";

                // Enviar para a controller salvar no banco de dados.
                ControllerProduto controllerProduto = new ControllerProduto();
                int codigo = controllerProduto.Cadastrar(produto);

                if (codigo > 0)
                {
                    MessageBox.Show("PRODUTO CÓDIGO " + codigo + " CADASTRADO COM SUCESSO!");
                }
            }
        }
    }
}
