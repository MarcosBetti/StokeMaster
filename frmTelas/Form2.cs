using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuárioDataSet.ITENSVENDA' table. You can move, or remove it, as needed.
            this.iTENSVENDATableAdapter.Fill(this.cadastroUsuárioDataSet.ITENSVENDA);
            // TODO: This line of code loads data into the 'cadastroUsuárioDataSet.VENDAS' table. You can move, or remove it, as needed.
            this.vENDASTableAdapter.Fill(this.cadastroUsuárioDataSet.VENDAS);
            CarregarDadosItensVenda();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarDadosItensVenda()
        {
            try
            {
                // Lógica para buscar os dados da tabela ITENSVENDA do banco de dados
                // e armazenar os dados em uma estrutura de dados adequada, como um DataTable

                // Exemplo de código para buscar os dados usando um SqlDataAdapter
                string connectionString = "Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True";
                string query = "SELECT * FROM ITENSVENDA";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTableItensVenda = new DataTable();
                        adapter.Fill(dataTableItensVenda);
                        connection.Close();

                        // Vincule os dados à grid
                        dataGridView2.DataSource = dataTableItensVenda;
                    }
                }
            }
            catch (Exception ex)
            {
                // Lidar com exceções ou exibir uma mensagem de erro adequada
                MessageBox.Show("Erro ao carregar os dados da tabela ITENSVENDA: " + ex.Message, "Erro");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
