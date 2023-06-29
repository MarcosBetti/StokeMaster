using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Cadastro
{
    internal class CadastroVenda
    {
        Conexao conn = new Conexao();
        SqlCommand c = new SqlCommand();

        public CadastroVenda(int? ID_PRODUTOS, int? ID_CLIENTE, int? ID_VENDEDOR, int? QUANTIDADE, decimal PRECO_TOTAL)
        {
            c.CommandText = "INSERT INTO VENDAS (ID_PRODUTOS, ID_CLIENTE, ID_VENDEDOR, QUANTIDADE, PRECO_TOTAL) VALUES (@ID_PRODUTOS, @ID_CLIENTE, @ID_VENDEDOR, @QUANTIDADE, @PRECO_TOTAL)";
            c.Parameters.AddWithValue("@ID_PRODUTOS", ID_PRODUTOS.HasValue ? (object)ID_PRODUTOS.Value : DBNull.Value);
            c.Parameters.AddWithValue("@ID_CLIENTE", ID_CLIENTE.HasValue ? (object)ID_CLIENTE.Value : DBNull.Value);
            c.Parameters.AddWithValue("@ID_VENDEDOR", ID_VENDEDOR.HasValue ? (object)ID_VENDEDOR.Value : DBNull.Value);
            c.Parameters.AddWithValue("@QUANTIDADE", QUANTIDADE.HasValue ? (object)QUANTIDADE.Value : DBNull.Value);
            c.Parameters.AddWithValue("@PRECO_TOTAL", PRECO_TOTAL.ToString("F2", CultureInfo.InvariantCulture));

            try
            {
                c.Connection = conn.conectar();
                int ok = c.ExecuteNonQuery();
                if (ok == 1)
                {
                    MessageBox.Show(" Venda cadastrado com sucesso");
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a venda: " + erro.Message, "Erro");
            }
            finally
            {
                conn.desconectar();
            }
        }
    }
}
