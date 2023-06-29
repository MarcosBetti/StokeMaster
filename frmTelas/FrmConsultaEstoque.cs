using Microsoft.Reporting.Map.WebForms.BingMaps;
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

namespace Cadastro.frmTelas
{
    public partial class FrmConsultaEstoque : Form
    {
        public FrmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuárioDataSet.ESTOQUE' table. You can move, or remove it, as needed.
            this.eSTOQUETableAdapter.Fill(this.cadastroUsuárioDataSet.ESTOQUE);
            // Percorre as linhas da DataGridView em ordem reversa
            for (int i = GridViewEstoque.Rows.Count - 2; i >= 0; i--)
            {
                DataGridViewRow row = GridViewEstoque.Rows[i];

                // Verifica se todas as células da linha estão vazias
                bool todasVazias = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        todasVazias = false;
                        break;
                    }
                }

                // Remove a linha se todas as células estiverem vazias
                if (todasVazias)
                {
                    GridViewEstoque.Rows.RemoveAt(i);
                }
            }


        }
        private void GridViewEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique ocorreu na coluna desejada
            if (e.ColumnIndex == GridViewEstoque.Columns["ID_PRODUTO"].Index && e.RowIndex >= 0)
            {
                // Obtém os valores das células correspondentes ao produto clicado
                object produtoId = GridViewEstoque.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value;
                object nomeProduto = GridViewEstoque.Rows[e.RowIndex].Cells["NOME_PRODUTO"].Value;
                object quantidade = GridViewEstoque.Rows[e.RowIndex].Cells["QUANTIDADE"].Value;

                // Exibe os valores em uma MessageBox (ou faça qualquer outra operação desejada)
                MessageBox.Show($"ID Produto: {produtoId}\nNome do Produto: {nomeProduto}\nQuantidade: {quantidade}");
            }
        }

        private void Btn_ConsultaEstoque(object sender, EventArgs e)
        {
            string codigo = txbCodigo.Text;


            using (SqlConnection connection = new SqlConnection("Data Source=TRON_SENIOR_23;Initial Catalog=CadastroUsuário;Integrated Security=True"))
            {
                connection.Open();
                string query = $"SELECT E.PRODUTO_ID AS ID_PRODUTO, P.NOME AS NOME_PRODUTO, " +
               $"(SELECT SUM(QUANTIDADE) FROM ESTOQUE WHERE PRODUTO_ID = E.PRODUTO_ID GROUP BY PRODUTO_ID) AS QUANTIDADE_TOTAL " +
               $"FROM ESTOQUE E " +
               $"JOIN PRODUTOS P ON E.PRODUTO_ID = P.ID_PRODUTOS " +
               $"WHERE E.PRODUTO_ID = '{codigo}'";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtEstoque = new DataTable();

                adapter.Fill(dtEstoque);
                connection.Close();


                // Percorre as linhas do DataTable e adiciona os valores à GridView
                foreach (DataRow row in dtEstoque.Rows)
                {
                    if (row["ID_PRODUTO"] == DBNull.Value)
                    {
                        continue; // Pula para a próxima iteração do loop
                    }

                    // Obtém os valores das colunas específicas
                    string produtoId = row["ID_PRODUTO"].ToString();
                    string nomeProduto = row["NOME_PRODUTO"].ToString();
                    string quantidade = row["QUANTIDADE_TOTAL"].ToString();

                    // Atualiza os valores das células correspondentes na GridView
                    int newRowIdx = GridViewEstoque.Rows.Count - 1;
                    GridViewEstoque.Rows[newRowIdx].Cells["ID_PRODUTO"].Value = produtoId;
                    GridViewEstoque.Rows[newRowIdx].Cells["NOME_PRODUTO"].Value = nomeProduto;
                    GridViewEstoque.Rows[newRowIdx].Cells["QUANTIDADE"].Value = quantidade;
                }
            }
        }

        private void txbCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

