using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public class IncluirEstoque
    {
        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public IncluirEstoque(int ID_ESTOQUE, int PRODUTO_ID, int QUANTIDADE, DateTime DATA_VENCIMENTO, DateTime DATA_ESTOQUE)
        {

            c.CommandText = "Insert Into ESTOQUE(ID_ESTOQUE,PRODUTO_ID,QUANTIDADE, DATA_VENCIMENTO,DATA_ESTOQUE) Values(@ID_ESTOQUE,@PRODUTO_ID,@QUANTIDADE,@DATA_VENCIMENTO, @DATA_ESTOQUE)";
            c.Parameters.Add(new SqlParameter("@ID_ESTOQUE", ID_ESTOQUE));
            c.Parameters.Add(new SqlParameter("@PRODUTO_ID", PRODUTO_ID));
            c.Parameters.Add(new SqlParameter("@QUANTIDADE", QUANTIDADE));
            c.Parameters.Add(new SqlParameter("@DATA_VENCIMENTO", DATA_VENCIMENTO));
            c.Parameters.Add(new SqlParameter("@DATA_ESTOQUE", DATA_ESTOQUE));

            try
            {
                c.Connection = conn.conectar();
                int ok = c.ExecuteNonQuery();
                if (ok == 1)
                {
                    MessageBox.Show(" Incluído quantidade no estoque com sucesso");
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
