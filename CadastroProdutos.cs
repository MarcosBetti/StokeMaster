using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Cadastro
{
    internal class CadastroProdutos
    {
        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public CadastroProdutos(string NOME, float PRECO, string DESCRICAO, int QUANTIDADE)
        {

            c.CommandText = "Insert Into PRODUTOS(NOME,PRECO,DESCRICAO, QUANTIDADE) Values(@NOME,@PRECO,@DESCRICAO, @QUANTIDADE)";
            c.Parameters.Add(new SqlParameter("@NOME", NOME));
            c.Parameters.Add(new SqlParameter("@PRECO", PRECO.ToString("F2", CultureInfo.InvariantCulture)));
            c.Parameters.Add(new SqlParameter("@DESCRICAO", DESCRICAO));
            c.Parameters.Add(new SqlParameter("@QUANTIDADE", QUANTIDADE));

            try
            {
                c.Connection = conn.conectar();
                int ok = c.ExecuteNonQuery();
                if (ok == 1)
                {
                    MessageBox.Show(" Produto cadastrado com sucesso");
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Ocorreu erro: " + erro.Message);
            }
            finally
            {
                conn.desconectar();
            }
        }
    }
}

