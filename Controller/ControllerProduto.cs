using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerProduto
    {
        public int Cadastrar(Produto produto)
        {
            // Resgata a conexão com o banco de dados.
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
            try
            {
                string instrucao = "INSERT INTO Produto (codigobarras, descricao, unidademedida, qtdminima, qtdmaxima, qtdatual, custounitario, percentuallucro, precovenda, ativo) VALUES (@codigobarras, @descricao, @unidademedida, @qtdminima, @qtdmaxima, @qtdatual, @custounitario, @percentuallucro, @precovenda, @ativo); SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(instrucao, acessoDados.Conectar());
                command.Parameters.AddWithValue("@codigobarras", produto.CodigoBarras);
                command.Parameters.AddWithValue("@descricao", produto.Descricao);
                command.Parameters.AddWithValue("@unidademedida", produto.UnidadeMedida);
                command.Parameters.AddWithValue("@qtdminima", produto.QtdMinima);
                command.Parameters.AddWithValue("@qtdmaxima", produto.QtdMaxima);
                command.Parameters.AddWithValue("@qtdatual", produto.QtdAtual);
                command.Parameters.AddWithValue("@custounitario", produto.CustoUnitario);
                command.Parameters.AddWithValue("@percentuallucro", produto.PercentualLucro);
                command.Parameters.AddWithValue("@precovenda", produto.PrecoVenda);
                command.Parameters.AddWithValue("@ativo", produto.Ativo);

                // Recupera o código do produto cadastrado.
                return Convert.ToInt32(command.ExecuteNonQuery());
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                acessoDados.Fechar();
            }
        }
    }
}
