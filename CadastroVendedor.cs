using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public class CadastroVendedor
    {
        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public CadastroVendedor(string NOME_VENDEDOR, string EMAIL, string TELEFONE)
        {

            c.CommandText = "Insert Into VENDEDOR(NOME_VENDEDOR,EMAIL,TELEFONE) Values(@NOME_VENDEDOR,@EMAIL,@TELEFONE)";
            c.Parameters.Add(new SqlParameter("@NOME_VENDEDOR", NOME_VENDEDOR));
            c.Parameters.Add(new SqlParameter("@EMAIL", EMAIL));
            c.Parameters.Add(new SqlParameter("@TELEFONE", TELEFONE));

            try
            {
                c.Connection = conn.conectar();
                int ok = c.ExecuteNonQuery();
                if (ok == 1)
                {
                    MessageBox.Show(" Vendedor cadastrado com sucesso");
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
