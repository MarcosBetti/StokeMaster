using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cadastro.FrmCadVenda;

namespace Cadastro
{
    public partial class FrmCadVenda : Form
    {
        RetornoItemQuantidade retorno = new RetornoItemQuantidade();
        bool exclusaoVenda;
        public int quantidadeTotalItem = 0;
        private bool itemNovo = false;
        public float precoTotal;
        public int codigoUltimaVenda;
        public int Quantidade;
        private bool biparItem = false;
        public FrmCadVenda()
        {
            InitializeComponent();          
            
        }

        private void FrmCadVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuárioDataSet.ITENSVENDA' table. You can move, or remove it, as needed.
            this.iTENSVENDATableAdapter.Fill(this.cadastroUsuárioDataSet.ITENSVENDA);
            // TODO: This line of code loads data into the 'cadastroUsuárioDataSet.ESTOQUE' table. You can move, or remove it, as needed.
            this.eSTOQUETableAdapter.Fill(this.cadastroUsuárioDataSet.ESTOQUE);
            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDASTableAdapter.Fill(this.cadastroUsuárioDataSet.VENDAS);

            DataGridViewButtonColumn botaoColuna = new DataGridViewButtonColumn();
            botaoColuna.Name = "Excluir";
            botaoColuna.HeaderText = "Excluir Venda";
            botaoColuna.Text = "Excluir";
            botaoColuna.UseColumnTextForButtonValue = true;
            GridViewCadastro.Columns.Add(botaoColuna);

        }
        private void CadVenda(object sender, EventArgs e)
        {
            try
            {               
                Dictionary<int, int> quantidadePorCodigo = new Dictionary<int, int>();
             
                foreach (ItemBipado itemBipado in itensBipados)
                {
                    int codigoProduto = itemBipado.Codigo;
                   
                    if (quantidadePorCodigo.ContainsKey(codigoProduto))
                    {
                     
                        quantidadePorCodigo[codigoProduto] += itemBipado.Quantidade;
                    }
                    else
                    {
                        quantidadePorCodigo[codigoProduto] = itemBipado.Quantidade;
                    }
                }
              
                int codigoCliente = Convert.ToInt32(txbCodigoCliente.Text);
                int codigoVendedor = Convert.ToInt32(tbxCodigoVendedor.Text);
                decimal valorVenda = Convert.ToDecimal(tbxValorVenda.Text);

                foreach (KeyValuePair<int, int> entry in quantidadePorCodigo)
                {
                    int codigoProduto = entry.Key;
                    int quantidade = entry.Value;
                 
                    CadastroVenda cadVenda = new CadastroVenda(codigoProduto, codigoCliente, codigoVendedor, quantidade, valorVenda);
                }

                foreach (ItemBipado itemBipado in itensBipados)
                {
                    RetornaCodigoVenda();
                    int idVenda = codigoUltimaVenda; 
                    int idProduto = itemBipado.Codigo;
                    int quantidade = 1; 
                    decimal precoUnitario = itemBipado.Preco;

                    GravarItemVenda(idVenda, idProduto, quantidade, precoUnitario);

                    SubtrairEstoque(idProduto, quantidade);                  

                }

                CarregarDadosEstoque();
                txbCodigoCliente.Text = "";
                tbxCodigoVendedor.Text = "";
                tbxValorVenda.Text = "";
                listBoxItensBipados.Items.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível cadastrar a venda");
                txbCodigoCliente.Text = "";
                tbxCodigoVendedor.Text = "";
                tbxValorVenda.Text = "";
                listBoxItensBipados.Items.Clear();
            }

        }
        public void RetornaCodigoVenda()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();

                string selectQuery = "SELECT TOP 1 ID_VENDA FROM VENDAS ORDER BY ID_VENDA DESC";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        codigoUltimaVenda = Convert.ToInt32(result);
                       
                    }
                    else
                    {                       
                        MessageBox.Show("Nenhuma venda encontrada.");
                    }
                }
            }            
        }
        public void SubtrairEstoque(int idProduto, int quantidade)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();
              
                string updateEstoqueQuery = "UPDATE ESTOQUE " +
                                            "SET QUANTIDADE = QUANTIDADE - @QUANTIDADE " +
                                            "WHERE PRODUTO_ID = @ID_PRODUTO";
                using (SqlCommand updateEstoqueCommand = new SqlCommand(updateEstoqueQuery, connection))
                {
                    updateEstoqueCommand.Parameters.AddWithValue("@QUANTIDADE", quantidade);
                    updateEstoqueCommand.Parameters.AddWithValue("@ID_PRODUTO", idProduto);

                    updateEstoqueCommand.ExecuteNonQuery();
                }
            }
        }

        public void GravarItemVenda(int idVenda, int idProduto, int quantidade, decimal precoUnitario)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();

                string query = "INSERT INTO ItensVenda (ID_ITEM, ID_VENDA, ID_PRODUTO, QUANTIDADE, PRECO_UNITARIO) VALUES (@ID_ITEM, @ID_VENDA, @ID_PRODUTO, @QUANTIDADE, @PRECO_UNITARIO)";

                int idItem = GerarIDUnico();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_ITEM", idItem);
                    command.Parameters.AddWithValue("@ID_VENDA", idVenda);
                    command.Parameters.AddWithValue("@ID_PRODUTO", idProduto);
                    command.Parameters.AddWithValue("@QUANTIDADE", quantidade);
                    command.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);

                    command.ExecuteNonQuery();
                }
            }
        }
        public int GerarIDUnico()
        {        
            int id = 0;
        
            SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True");
            connection.Open();
            string query = "SELECT MAX(ID_ITEM) FROM ItensVenda";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    id = Convert.ToInt32(result) + 1;
                }
                else
                {
                    id = 1; 
                }
            }          

            return id;
        }
        private void TotalizadorVenda(object sender, EventArgs e)
        {
            try
            {
                if (GridViewCadastro != null && GridViewCadastro.Rows.Count > 0)
                {
                     float total = 0;

                    for (int i = 0; i < GridViewCadastro.Rows.Count; i++)
                    {
                        if (GridViewCadastro.Rows[i].Cells.Count > 5 && GridViewCadastro.Rows[i].Cells[5].Value != null)
                        {
                            float venda = 0;
                            if (float.TryParse(GridViewCadastro.Rows[i].Cells[5].Value.ToString(), out venda))
                            {
                                total += venda;
                            }
                        }
                    }

                    labtotal.Text = "R$ " + total.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao calcular o total: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void BtnProdutoCad_Click(object sender, EventArgs e)
        {
            FrmCadProduto frmCadProduto = new FrmCadProduto();
            frmCadProduto.Show();
        }

        private void btnClienteCad_Click(object sender, EventArgs e)
        {
            FrmCadCliente frmCadCliente = new FrmCadCliente();
            frmCadCliente.Show();
        }

        private void GridViewCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == GridViewCadastro.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
               
                int idVenda = Convert.ToInt32(GridViewCadastro.Rows[e.RowIndex].Cells["iDVENDADataGridViewTextBoxColumn"].Value);               

                ExcluirVenda(idVenda);
                if (exclusaoVenda)
                   
                    GridViewCadastro.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void ExcluirVenda(int idVenda)
        {           

            
            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                string query = "DELETE FROM VENDAS WHERE ID_VENDA = @ID_VENDA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_VENDA", idVenda);

                connection.Open();
                int linhasAfetadas = command.ExecuteNonQuery();
                connection.Close();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Venda excluída com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir a venda.");
                    exclusaoVenda = false;
                    return;
                }
            }
        }
     
        private List<ItemBipado> itensBipados = new List<ItemBipado>(); 
      
        private void TbxCodigoProduto_TextChanged(object sender, EventArgs e)
        {
            if (biparItem)
            {

                biparItem = false;

                Produto produto = new Produto();
                string codigoProduto = tbxCodigoProduto.Text;

                if (!string.IsNullOrEmpty(tbxCodigoProduto.Text))
                {
                   
                    int quantidadeDisponivel = VerificarEstoqueDisponivel(codigoProduto, itensBipados, produto);

                    if (quantidadeDisponivel > 0)
                    {
                       
                        produto = ObterProdutoDoBancoDeDados(codigoProduto);

                        if (produto != null)
                        {
                        
                            ItemBipado itemBipado = new ItemBipado
                            {
                                Codigo = Convert.ToInt32(codigoProduto),
                                Nome = produto.Nome,
                                Preco = produto.Preco
                            };

                            if (retorno.QuantidadeTotalItem <= retorno.QuantidadeDisponivel)
                            {
                                itensBipados.Add(itemBipado);
                                quantidadeTotalItem = 0;
                                retorno.QuantidadeDisponivel = 0;
                            }
                            else
                            {
                                return;
                            }                        
                            AtualizarExibicaoListBox();

                            CalcularPrecoTotal();
                        }
                        else
                        {                          
                            MessageBox.Show("O produto não foi encontrado.", "Aviso");
                        }
                    }
                    else if (quantidadeDisponivel != 0)
                    {                        
                        MessageBox.Show("O produto não está mais em estoque.", "Aviso");
                    }                   
                    tbxCodigoProduto.Text = "";
                }
            }
        }

        private void AtualizarExibicaoListBox()
        {            
            listBoxItensBipados.Items.Clear();
           
            foreach (ItemBipado itemBipado in itensBipados)
            {

                listBoxItensBipados.Items.Add(itemBipado);
            }
        }

        private int VerificarEstoqueDisponivel(string codigoProduto, List<ItemBipado> itensBipados, Produto produto)
        {

            int quantidadeDisponivel = 0;

            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();
             
                string query = "SELECT SUM(QUANTIDADE) FROM ESTOQUE WHERE PRODUTO_ID = @ID_PRODUTO GROUP BY PRODUTO_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_PRODUTO", codigoProduto);
                   
                    object result = command.ExecuteScalar();
                   
                    if (result != null && result != DBNull.Value)
                    {
                        quantidadeDisponivel = Convert.ToInt32(result);
                    }
                }
            }   

            int quantidadeBipada = 0;

            if (quantidadeDisponivel > 0)
            {
                int quantidadeTotalItem = 0; 
                foreach (ItemBipado itemBipado in itensBipados)
                {
                    if (itemBipado.Codigo == Convert.ToInt32(codigoProduto))
                    {
                        int qtdeItem = 1;
                        int valorTotalItens = qtdeItem;
                        quantidadeTotalItem += valorTotalItens;
                        if (quantidadeTotalItem == 1)
                        {
                            quantidadeTotalItem += qtdeItem;
                        }
                    }
                }
                
                if (quantidadeTotalItem > quantidadeDisponivel)
                {
                    MessageBox.Show("Quantidade de itens bipados excede a quantidade disponível em estoque.", "Aviso");
      
                    retorno.QuantidadeDisponivel = quantidadeDisponivel;
                    retorno.QuantidadeTotalItem = quantidadeTotalItem;
                    tbxCodigoProduto.Text = "";
                }
                retorno.QuantidadeDisponivel = quantidadeDisponivel;
                retorno.QuantidadeTotalItem = quantidadeTotalItem;
                tbxCodigoProduto.Text = "";
            }
          
            return quantidadeDisponivel;
        }
        private void CalcularPrecoTotal()
        {
            decimal precoTotal = 0;

            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();
                
                System.Collections.IList list = itensBipados;
                for (int i = 0; i < list.Count; i++)
                {
                    ItemBipado item = (ItemBipado)list[i];
                    string codigoProduto = item.Codigo.ToString();
                  
                    string query = "SELECT PRECO FROM PRODUTOS WHERE ID_PRODUTOS = @ID_PRODUTOS";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_PRODUTOS", codigoProduto);

                        object result = command.ExecuteScalar();

                    
                        if (result != null && result != DBNull.Value)
                        {
                            decimal precoProduto = Convert.ToDecimal(result);
                            precoTotal += precoProduto;

                        }
                    }
                }
            }       
            tbxValorVenda.Text = precoTotal.ToString();
        }

        private class ItemBipado
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }

            public int Codigo { get; set; }
            public int Quantidade { get; set; }

            public override string ToString()
            {
                return $"{Nome} - R${Preco.ToString("0.00")}";
            }
        }
        public class Produto
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

        private Produto ObterProdutoDoBancoDeDados(string codigoProduto)
        {
            Produto produto = null;

            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();
       
                string query = "SELECT NOME, PRECO FROM PRODUTOS WHERE ID_PRODUTOS = @ID_PRODUTOS";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_PRODUTOS", codigoProduto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            string nome = reader.GetString(reader.GetOrdinal("NOME"));
                            decimal preco = reader.GetDecimal(reader.GetOrdinal("PRECO"));
                            
                            produto = new Produto
                            {
                                Codigo = codigoProduto,
                                Nome = nome,
                                Preco = preco
                            };
                        }
                    }
                }
            }

            return produto;
        }

        private void tbxValorVenda_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbxQuantidade_TextChanged(object sender, EventArgs e)
        {
            //Quantidade = Convert.ToInt32(tbxQuantidade.Text);
        }

        private void listBoxItensBipados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxCodigoVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBiparItem(object sender, EventArgs e)
        {          
            biparItem = true;
            TbxCodigoProduto_TextChanged(sender, e);
        }

        private void txbCodigoCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void CarregarDadosEstoque()
        {
            string connectionString = "Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True";
            string query = "SELECT * FROM VENDAS"; 

          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                
                    adapter.Fill(dataTable);
                   
                    GridViewCadastro.DataSource = dataTable;
                }
            }
        }
    }
}
