using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    class CadastrosProdutos
    {
        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public CadastrosProdutos(int ID_CODIGO, string NOME, float VALOR)
        {

            c.CommandText = "Insert Into PRODUTOS(ID_CODIGO,NOME,VALOR) Values(@ID_CODIGO,@NOME,@VALOR)";
            c.Parameters.Add(new SqlParameter("@ID_CODIGO", ID_CODIGO));
            c.Parameters.Add(new SqlParameter("@NOME", NOME));
            c.Parameters.Add(new SqlParameter("@VALOR", VALOR));

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

