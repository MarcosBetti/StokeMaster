using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Cadastro
{
    public partial class FrmCadCliente : Form
    {   
        public FrmCadCliente()
        {          
            InitializeComponent();
        }
        private void CadCliente(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txbNome.Text))
                {
                    CadastrosClientes cadCliente = new CadastrosClientes(txbNome.Text, txbEmail.Text, txbTelefone.Text);
                    txbNome.Text = "";
                    txbEmail.Text = "";
                    txbTelefone.Text = "";
                    CarregarDadosEstoque();
                }
                else
                {
                    MessageBox.Show("Digite o nome do cliente para cadastrar");
                    return;
                }
            }
            catch (Exception ex)
            {
                txbNome.Text = "";
                txbEmail.Text = "";
                txbTelefone.Text = "";
                return;
            }
          
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTESTableAdapter.Fill(this.cadastroUsuárioDataSet.CLIENTES);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregarDadosEstoque()
        {
            string connectionString = "Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"; 
            string query = "SELECT * FROM CLIENTES";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                   
                    adapter.Fill(dataTable);
                   
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }

}

