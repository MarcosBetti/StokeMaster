using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cadastro
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = "Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True ";
        }

        public SqlConnection conectar()
    {
        if (con.State == System.Data.ConnectionState.Closed)
        {
            con.Open();
        }
        return con;
    }
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
}
}
