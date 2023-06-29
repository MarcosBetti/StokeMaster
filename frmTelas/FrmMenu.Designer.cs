namespace Cadastro
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);

        //    btnCadVenda.Visible = true;
        //}

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadVendaRelVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreçãoEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadVenda = new System.Windows.Forms.Button();
            this.BtnCadProduto = new System.Windows.Forms.Button();
            this.BtnCorrecaoEstoques = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.relatórioToolStripMenuItem,
            this.movimentoToolStripMenuItem});
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Name = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.vendedorToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Click += new System.EventHandler(this.CadCliente);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            resources.ApplyResources(this.vendedorToolStripMenuItem, "vendedorToolStripMenuItem");
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadVendaRelVendaToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            resources.ApplyResources(this.relatórioToolStripMenuItem, "relatórioToolStripMenuItem");
            // 
            // cadVendaRelVendaToolStripMenuItem
            // 
            this.cadVendaRelVendaToolStripMenuItem.Name = "cadVendaRelVendaToolStripMenuItem";
            resources.ApplyResources(this.cadVendaRelVendaToolStripMenuItem, "cadVendaRelVendaToolStripMenuItem");
            this.cadVendaRelVendaToolStripMenuItem.Click += new System.EventHandler(this.cadVendaRelVendaToolStripMenuItem_Click);
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.carreçãoEstoqueToolStripMenuItem});
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            resources.ApplyResources(this.movimentoToolStripMenuItem, "movimentoToolStripMenuItem");
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            resources.ApplyResources(this.estoqueToolStripMenuItem, "estoqueToolStripMenuItem");
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.Estoque_Click);
            // 
            // carreçãoEstoqueToolStripMenuItem
            // 
            this.carreçãoEstoqueToolStripMenuItem.Name = "carreçãoEstoqueToolStripMenuItem";
            resources.ApplyResources(this.carreçãoEstoqueToolStripMenuItem, "carreçãoEstoqueToolStripMenuItem");
            this.carreçãoEstoqueToolStripMenuItem.Click += new System.EventHandler(this.CorrecaoEstoque_Click);
            // 
            // btnCadVenda
            // 
            this.btnCadVenda.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCadVenda, "btnCadVenda");
            this.btnCadVenda.CausesValidation = false;
            this.btnCadVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVenda.ForeColor = System.Drawing.Color.DimGray;
            this.btnCadVenda.Name = "btnCadVenda";
            this.btnCadVenda.UseVisualStyleBackColor = false;
            this.btnCadVenda.Click += new System.EventHandler(this.CadVenda);
            // 
            // BtnCadProduto
            // 
            this.BtnCadProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadProduto.BackgroundImage = global::Cadastro.Properties.Resources.CadProduto1;
            resources.ApplyResources(this.BtnCadProduto, "BtnCadProduto");
            this.BtnCadProduto.CausesValidation = false;
            this.BtnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadProduto.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCadProduto.Name = "BtnCadProduto";
            this.BtnCadProduto.UseVisualStyleBackColor = false;
            this.BtnCadProduto.Click += new System.EventHandler(this.CadProdutos);
            // 
            // BtnCorrecaoEstoques
            // 
            this.BtnCorrecaoEstoques.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnCorrecaoEstoques, "BtnCorrecaoEstoques");
            this.BtnCorrecaoEstoques.CausesValidation = false;
            this.BtnCorrecaoEstoques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCorrecaoEstoques.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCorrecaoEstoques.Name = "BtnCorrecaoEstoques";
            this.BtnCorrecaoEstoques.UseVisualStyleBackColor = false;
            this.BtnCorrecaoEstoques.Click += new System.EventHandler(this.BtnCorrecaoEstoques_Click);
            // 
            // FrmMenu
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CausesValidation = false;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.BtnCorrecaoEstoques);
            this.Controls.Add(this.btnCadVenda);
            this.Controls.Add(this.BtnCadProduto);
            this.Controls.Add(this.Menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "FrmMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadVendaRelVendaToolStripMenuItem;
        private System.Windows.Forms.Button BtnCadProduto;
        private System.Windows.Forms.Button btnCadVenda;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreçãoEstoqueToolStripMenuItem;
        private System.Windows.Forms.Button BtnCorrecaoEstoques;
    }
}

