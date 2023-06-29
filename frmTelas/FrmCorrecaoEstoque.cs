using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro.frmTelas
{
    public partial class FrmCorrecaoEstoque : Form
    {
        public FrmCorrecaoEstoque()
        {
            InitializeComponent();
        }
        private void FrmCorrecaoEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuárioDataSet.ESTOQUE' table. You can move, or remove it, as needed.
            this.eSTOQUETableAdapter.Fill(this.cadastroUsuárioDataSet.ESTOQUE);
        }
        private void IncluirEstoque(object sender, EventArgs e)
        {
            try
            {
                IncluirEstoque incluirEstoque = new IncluirEstoque(Convert.ToInt32(texbIdInclusao.Text), Convert.ToInt32(txbIdProduto.Text), Convert.ToInt32(texbQtde.Text), Convert.ToDateTime(dATA_ESTOQUEDateTimePicker.Text), Convert.ToDateTime(dATA_VENCIMENTODateTimePicker.Text));
                texbIdInclusao.Text = "";
                txbIdProduto.Text = "";
                txbNomeProduto.Text = "";
                texbQtde.Text = "";
                CarregarDadosEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível incluir produto no estoque");
                texbIdInclusao.Text = "";
                txbIdProduto.Text = "";
                txbNomeProduto.Text = "";
                texbQtde.Text = "";
            }
        }
        private void txbNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbIdProduto_TextChanged(object sender, EventArgs e)
        {
            string codigoProduto = txbIdProduto.Text;

            if (!string.IsNullOrWhiteSpace(codigoProduto))
            {
             
                string nomeProduto = BuscarNomeProduto(codigoProduto);

                txbNomeProduto.Text = nomeProduto;
            }
            else          
        
                txbNomeProduto.Text = string.Empty;            
        }

        private string BuscarNomeProduto(string codigoProduto)
        {
            string nomeProduto = string.Empty;


            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();
             
                string sqlQuery = "SELECT Nome FROM Produtos WHERE ID_PRODUTOS = @PRODUTO_ID";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@PRODUTO_ID", codigoProduto);
           
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())                    
                     
                        nomeProduto = reader["NOME"].ToString();                                   
                }
            }

            return nomeProduto;
        }

        private void texbQtde_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridViewEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dATA_ESTOQUEDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void CarregarDadosEstoque()
        {
            string connectionString = "Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"; 
            string query = "SELECT * FROM ESTOQUE"; 

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
