using System;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Controller
{
    public class ControllerMovimentacaoEstoque
    {
        public Produto CarregarProduto(string codigoBarras)
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
            try
            {
                string instrucao = "SELECT * FROM Produto WHERE codigobarras = '" + codigoBarras + "'";

                SqlCommand command = new SqlCommand(instrucao, acessoDados.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Produto produto = new Produto();
                foreach (DataRow item in dt.Rows)
                {
                    produto.Codigo = Convert.ToInt32(item["codigo"].ToString());
                    produto.Descricao = item["descricao"].ToString();
                    produto.UnidadeMedida = item["unidademedida"].ToString();
                    produto.QtdMinima = Convert.ToInt32(item["qtdminima"].ToString());
                    produto.QtdMaxima = Convert.ToInt32(item["qtdmaxima"].ToString());
                    produto.QtdAtual = Convert.ToInt32(item["qtdatual"].ToString());
                }

                return produto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                acessoDados.Fechar();
            }
        }

        public int Movimentar(Movimentacao movimentacao)
        {            
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();           
            try
            {
                string instrucaoEstoque = "INSERT INTO Estoque (quantidade, codigoproduto, data, hora, motivo, acao) VALUES (@quantidade, @codigoproduto, @data, @hora, @motivo, @acao);";

                string instrucaoProduto = "";

                if (movimentacao.Acao == "Entrada")
                instrucaoProduto = "UPDATE Produto SET qtdatual = qtdatual + @quantidade WHERE codigo = @codigoproduto";
                else
                instrucaoProduto = "UPDATE Produto SET qtdatual = qtdatual - @quantidade WHERE codigo = @codigoproduto";
             
                SqlCommand command = new SqlCommand(instrucaoEstoque + instrucaoProduto, acessoDados.Conectar());
                command.Parameters.AddWithValue("@quantidade", movimentacao.Quantidade);
                command.Parameters.AddWithValue("@codigoproduto", movimentacao.CodigoProduto);
                command.Parameters.AddWithValue("@data", movimentacao.Data);
                command.Parameters.AddWithValue("@hora", movimentacao.Hora);
                command.Parameters.AddWithValue("@motivo", movimentacao.Motivo);
                command.Parameters.AddWithValue("@acao", movimentacao.Acao);

                return Convert.ToInt32(command.ExecuteNonQuery());
            }
            catch (Exception erro)
            {
                throw erro;
            }           
        }
    }
}
