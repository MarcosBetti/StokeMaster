using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Cadastro
{
    public partial class FrmCadProduto : Form
    {

        private bool _exclusaoVenda;

        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter.Fill(this.cadastroUsuárioDataSet.PRODUTOS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txbNomeProdutos.Text))
                {
                    CadastroProdutos cadastro = new CadastroProdutos(
                        txbNomeProdutos.Text,
                        Convert.ToSingle(txbValorProduto.Text.Trim(), CultureInfo.GetCultureInfo("en-US")),
                        txbDescricaoItem.Text,
                        Convert.ToInt32(txbQtde.Text)
                     
                    );
                    CarregarDadosEstoque();
                    txbNomeProdutos.Text = "";
                    txbValorProduto.Text = "";
                    txbDescricaoItem.Text = "";
                    txbQtde.Text = "";
                }
                else
                {

                    MessageBox.Show("Obrigatório adicionar nome para cadastrar Produto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar o Produto");
                txbNomeProdutos.Text = "";
                txbValorProduto.Text = "";
                txbDescricaoItem.Text = "";
                txbQtde.Text = "";

            }
        }
        private void GridViewProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridViewProduto.Rows[e.RowIndex];

            int idProduto = Convert.ToInt32(row.Cells["iDPRODUTOSDataGridViewTextBoxColumn"].Value);

            if (GridViewProduto.Columns[e.ColumnIndex].Index == 3)
            {
                string descricaoAtual = row.Cells[3].Value.ToString();

                string novaDescricao = PromptInputBox("Digite a nova descrição:", "Editar Descrição", descricaoAtual);

                if (!string.IsNullOrWhiteSpace(novaDescricao) && novaDescricao != descricaoAtual)
                {
                    row.Cells["dESCRICAODataGridViewTextBoxColumn"].Value = novaDescricao;
         
                    if (AtualizarDescricaoProduto(idProduto, novaDescricao))
                    {
                        MessageBox.Show("Produto atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o produto.");
                 
                        row.Cells["dESCRICAODataGridViewTextBoxColumn"].Value = descricaoAtual;
                    }
                }
            }

            string precoAtual = row.Cells[2].Value.ToString();

            if (GridViewProduto.Columns[e.ColumnIndex].Index == 2)
            {
                if (GridViewProduto.Columns[e.ColumnIndex].Index == 2)
                {

                    string novoPreco = PromptInputBox("Digite o novo Preço:", "Editar Preço", precoAtual);

                    if (!string.IsNullOrWhiteSpace(novoPreco) && novoPreco != precoAtual)
                    {
                        row.Cells["pRECODataGridViewTextBoxColumn"].Value = novoPreco;
                   
                        if (AtualizarPrecoProduto(idProduto, novoPreco))
                        {
                            MessageBox.Show("Produto atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar o produto.");
                       
                            row.Cells["pRECODataGridViewTextBoxColumn"].Value = precoAtual;
                        }
                    }

                }
            }

            string nomeAtual = row.Cells[1].Value.ToString();

            if (GridViewProduto.Columns[e.ColumnIndex].Index == 1)
            {
                if (GridViewProduto.Columns[e.ColumnIndex].Index == 1)
                {

                    string novoNome = PromptInputBox("Digite o novo Nome:", "Editar Nome", nomeAtual);

                    if (!string.IsNullOrWhiteSpace(novoNome) && novoNome != nomeAtual)
                    {
                        row.Cells["nOMEDataGridViewTextBoxColumn"].Value = novoNome;

                        if (AtualizarNomeProduto(idProduto, novoNome))
                        {
                            MessageBox.Show("Produto atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar o produto.");
                        
                            row.Cells["nOMEDataGridViewTextBoxColumn"].Value = nomeAtual;
                        }
                    }

                }
            }

        }

        private bool AtualizarNomeProduto(int idProduto, string novoNome)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                string query = "UPDATE PRODUTOS SET NOME = @NOME WHERE ID_PRODUTOS = @ID_PRODUTOS";
                SqlCommand command = new SqlCommand(query, connection);
           
                command.Parameters.Add("@NOME", novoNome);
                command.Parameters.AddWithValue("@ID_PRODUTOS", idProduto);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }
        }

        private bool AtualizarPrecoProduto(int idProduto, string novoPreco)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                string query = "UPDATE PRODUTOS SET PRECO = @PRECO WHERE ID_PRODUTOS = @ID_PRODUTOS";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add("@PRECO", SqlDbType.Float).Value = novoPreco;
                command.Parameters.AddWithValue("@ID_PRODUTOS", idProduto);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }
        }

        private bool AtualizarDescricaoProduto(int idProduto, string novaDescricao)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                string query = "UPDATE produtos SET DESCRICAO = @DESCRICAO WHERE ID_PRODUTOS = @ID_PRODUTOS";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DESCRICAO", novaDescricao);
                command.Parameters.AddWithValue("@ID_PRODUTOS", idProduto);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }
        }

        private string PromptInputBox(string prompt, string title, string defaultValue)
        {
            return MessageBox.Show(prompt, title, MessageBoxButtons.OKCancel) == DialogResult.OK
                ? InputBox.Show(title, prompt, defaultValue)
                : defaultValue;
        }

        public static class InputBox
        {
            public static string Show(string title, string prompt, string defaultValue = "")
            {
                Form inputBox = new Form()
                {
                    Width = 300,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = title,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label label = new Label() { Left = 50, Top = 20, Text = prompt };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200, Text = defaultValue };
                Button buttonOk = new Button() { Text = "OK", Left = 50, Width = 75, Top = 80, DialogResult = DialogResult.OK };
                Button buttonCancel = new Button() { Text = "Cancel", Left = 150, Width = 75, Top = 80, DialogResult = DialogResult.Cancel };

                textBox.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                        inputBox.DialogResult = DialogResult.OK;
                };

                textBox.Leave += (sender, e) =>
                {
                    inputBox.DialogResult = DialogResult.OK;
                };

                inputBox.Controls.Add(label);
                inputBox.Controls.Add(textBox);
                inputBox.Controls.Add(buttonOk);
                inputBox.Controls.Add(buttonCancel);

                inputBox.AcceptButton = buttonOk;
                inputBox.CancelButton = buttonCancel;

                return inputBox.ShowDialog() == DialogResult.OK ? textBox.Text : defaultValue;
            }
        }

        private void CarregarDadosEstoque()
        {
            string connectionString = "Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"; 
            string query = "SELECT * FROM PRODUTOS"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {              
                connection.Open();
             
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    GridViewProduto.DataSource = dataTable;
                }
            }
        }

    }
}
