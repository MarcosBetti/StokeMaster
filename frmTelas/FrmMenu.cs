using Cadastro.frmTelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FrmMenu : Form
    {

        private Form telaSecundaria;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Criar tela de login na hora que carrega a página
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void relatórioVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadCliente(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmCadCliente());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmCadProduto());
        }

        private void cadVendaRelVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmCadVenda());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void CadProdutos(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmCadProduto());
        }

        private void CadVenda(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmCadVenda());
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new frmCadVendedor());
        }
        private void OpenSecondaryForm(Form form)
        {
            // Desabilita os botões da tela principal
            btnCadVenda.Enabled = false;
            BtnCadProduto.Enabled = false;
            BtnCorrecaoEstoques.Enabled = false;
            Menu.Enabled = false;
            // Cria a instância da tela secundária
            telaSecundaria = form;
            telaSecundaria.FormClosed += TelaSecundaria_FormClosed;

            // Abre a tela secundária
            telaSecundaria.Show();
        }

        private void TelaSecundaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Habilita os botões da tela principal
            btnCadVenda.Enabled = true;
            BtnCadProduto.Enabled = true;
            BtnCorrecaoEstoques.Enabled = true;
            Menu.Enabled = true;

            // Define a referência da tela secundária como null
            telaSecundaria = null;
        }
        protected override void Dispose(bool disposing)
        {

            // Habilita os botões da tela principal se a tela secundária estiver aberta
            if (telaSecundaria != null && !telaSecundaria.IsDisposed)
            {
                btnCadVenda.Enabled = true;
                BtnCadProduto.Enabled = true;
                BtnCorrecaoEstoques.Enabled= true;      
            }

            base.Dispose(disposing);
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmConsultaEstoque());
        }

        private void CorrecaoEstoque_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmCorrecaoEstoque());
        }

        private void BtnCorrecaoEstoques_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new FrmCorrecaoEstoque());
        }
    }
}