using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    class CadastrosClientes
    {
        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public CadastrosClientes(string NOME_CLIENTE, string EMAIL, string TELEFONE)
        {
            
            c.CommandText = "Insert Into CLIENTES(NOME_CLIENTE,EMAIL,TELEFONE) Values(@NOME_CLIENTE,@EMAIL,@TELEFONE)";
            c.Parameters.Add(new SqlParameter("@NOME_CLIENTE", NOME_CLIENTE));
            c.Parameters.Add(new SqlParameter("@EMAIL", EMAIL));
            c.Parameters.Add(new SqlParameter("@TELEFONE", TELEFONE));

            try
            {
                c.Connection = conn.conectar();
                int ok = c.ExecuteNonQuery();
                if(ok == 1)
                {
                    MessageBox.Show(" Cliente cadastrado com sucesso");
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