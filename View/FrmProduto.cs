using System;
using System.Windows.Forms;
using Model;
using Controller;
using System.Data;

namespace View
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
            //Carrega o filtro todos por padrão.
            cbxFiltro.SelectedItem = "Todos";

            CarregarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "Novo")
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
                produto.UnidadeMedida = cbxUnidadeMedida.SelectedItem.ToString();
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

        void CarregarProdutos()
        {
            try
            {
                ControllerProduto controllerProduto = new ControllerProduto();
                DataTable dt = new DataTable();
                dt = controllerProduto.Carregar(txtPesquisa.Text, cbxFiltro.SelectedItem.ToString());
                dgvDados.DataSource = dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void dgvDados_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Você precisa selecionar um produto da lista!");
            }
            else
            {
                txtCodigo.Text = dgvDados.CurrentRow.Cells["codigo"].Value.ToString();
                txtCodigoBarras.Text = dgvDados.CurrentRow.Cells["codigobarras"].Value.ToString();
                txtDescricao.Text = dgvDados.CurrentRow.Cells["descricao"].Value.ToString();
                cbxUnidadeMedida.SelectedItem = dgvDados.CurrentRow.Cells["unidademedida"].Value.ToString();
                nudQtdeMinima.Value = (int)dgvDados.CurrentRow.Cells["qtdminima"].Value;
                nudQtdeAtual.Value = (int)dgvDados.CurrentRow.Cells["qtdatual"].Value;
                nudQtdeMaxima.Value = (int)dgvDados.CurrentRow.Cells["qtdmaxima"].Value;
                txtValorUnitario.Text = dgvDados.CurrentRow.Cells["custounitario"].Value.ToString();
                txtPercentualLucro.Text = dgvDados.CurrentRow.Cells["percentuallucro"].Value.ToString();
                txtPreco.Text = dgvDados.CurrentRow.Cells["precovenda"].Value.ToString();

                if (dgvDados.CurrentRow.Cells["ativo"].Value.ToString() == "Sim")
                    ckbAtivo.Checked = true;
                else
                    ckbAtivo.Checked = false;
            }
        }
    }
}
