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
    public partial class frmCadVendedor : Form
    {
        public frmCadVendedor()
        {
            InitializeComponent();
        }           

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cadastrar(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txbNomeVendedor.Text))
                {
                    CadastroVendedor cadastro = new CadastroVendedor(txbNomeVendedor.Text, txbEmailVendedor.Text, txbTelefoneVendedor.Text);
                    txbNomeVendedor.Text = "";
                    txbEmailVendedor.Text = "";
                    txbTelefoneVendedor.Text = "";
                    CarregarDadosEstoque();
                }
                else
                {
                    MessageBox.Show("Digite o nome do Vendedor para cadastrar");
                    return;
                }
            }
            catch (Exception ex)
            {
                txbNomeVendedor.Text = "";
                txbEmailVendedor.Text = "";
                txbTelefoneVendedor.Text = "";
                return;
            }
        }

        private void frmCadVendedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuárioDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            this.vENDEDORTableAdapter.Fill(this.cadastroUsuárioDataSet.VENDEDOR);

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarDadosEstoque()
        {
            string connectionString = "Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"; 
            string query = "SELECT * FROM VENDEDOR";
        
            using (SqlConnection connection = new SqlConnection(connectionString))
            {             
                connection.Open();
               
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                  
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
                }
            }
        }
    }
}
