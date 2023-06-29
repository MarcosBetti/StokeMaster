using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    class Cadastros
    {
        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public Cadastros(int ID_CODIGO, string NOME, string EMAIL, string TELEFONE, string ENDERECO, DateTime DATANASC)
        {
            
            c.CommandText = "Insert Into CLIENTES(ID_CODIGO,NOME,EMAIL,TELEFONE,ENDERECO,DATANASC) Values(@ID_CODIGO,@NOME,@EMAIL,@TELEFONE,@ENDERECO,@DATANASC)";
            c.Parameters.Add(new SqlParameter("@ID_CODIGO", ID_CODIGO));
            c.Parameters.Add(new SqlParameter("@NOME", NOME));
            c.Parameters.Add(new SqlParameter("@EMAIL", EMAIL));
            c.Parameters.Add(new SqlParameter("@TELEFONE", TELEFONE));
            c.Parameters.Add(new SqlParameter("@ENDERECO", ENDERECO));
            c.Parameters.Add(new SqlParameter("@DATANASC", DATANASC));

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