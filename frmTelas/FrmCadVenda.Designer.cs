namespace Cadastro
{
    partial class FrmCadVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxItensBipados = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GridViewCadastro = new System.Windows.Forms.DataGridView();
            this.iDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_VENDEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuárioDataSet = new Cadastro.CadastroUsuárioDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.labtotal = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.Label();
            this.btnClienteCad = new System.Windows.Forms.Button();
            this.BtnProdutoCad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxValorVenda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBipar = new System.Windows.Forms.Label();
            this.tbxCodigoProduto = new System.Windows.Forms.TextBox();
            this.tbxCodigoVendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.npgsqlDataAdapter2 = new Npgsql.NpgsqlDataAdapter();
            this.vENDASTableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.VENDASTableAdapter();
            this.eSTOQUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTOQUETableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.ESTOQUETableAdapter();
            this.fKITENSVENDIDVE756D6ECBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSVENDATableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.ITENSVENDATableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listBoxItensBipados);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GridViewCadastro);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labtotal);
            this.groupBox1.Controls.Add(this.Cadastro);
            this.groupBox1.Controls.Add(this.btnClienteCad);
            this.groupBox1.Controls.Add(this.BtnProdutoCad);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbxValorVenda);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnBipar);
            this.groupBox1.Controls.Add(this.tbxCodigoProduto);
            this.groupBox1.Controls.Add(this.tbxCodigoVendedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbCodigoCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1341, 646);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1202, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 27);
            this.button4.TabIndex = 86;
            this.button4.Text = "Bipar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnBiparItem);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 85;
            this.label8.Text = "R$";
            // 
            // listBoxItensBipados
            // 
            this.listBoxItensBipados.FormattingEnabled = true;
            this.listBoxItensBipados.ItemHeight = 16;
            this.listBoxItensBipados.Location = new System.Drawing.Point(987, 157);
            this.listBoxItensBipados.Name = "listBoxItensBipados";
            this.listBoxItensBipados.Size = new System.Drawing.Size(258, 484);
            this.listBoxItensBipados.TabIndex = 83;
            this.listBoxItensBipados.SelectedIndexChanged += new System.EventHandler(this.listBoxItensBipados_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "Código Cliente:";
            // 
            // GridViewCadastro
            // 
            this.GridViewCadastro.AutoGenerateColumns = false;
            this.GridViewCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVENDADataGridViewTextBoxColumn,
            this.iDPRODUTOSDataGridViewTextBoxColumn,
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.ID_VENDEDOR,
            this.QUANTIDADE,
            this.PRECO_TOTAL,
            this.DATA_VENDA});
            this.GridViewCadastro.DataSource = this.vENDASBindingSource;
            this.GridViewCadastro.Location = new System.Drawing.Point(24, 321);
            this.GridViewCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewCadastro.Name = "GridViewCadastro";
            this.GridViewCadastro.RowHeadersWidth = 51;
            this.GridViewCadastro.RowTemplate.Height = 24;
            this.GridViewCadastro.Size = new System.Drawing.Size(930, 318);
            this.GridViewCadastro.TabIndex = 80;
            this.GridViewCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCadastro_CellContentClick);
            // 
            // iDVENDADataGridViewTextBoxColumn
            // 
            this.iDVENDADataGridViewTextBoxColumn.DataPropertyName = "ID_VENDA";
            this.iDVENDADataGridViewTextBoxColumn.HeaderText = "ID_VENDA";
            this.iDVENDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDVENDADataGridViewTextBoxColumn.Name = "iDVENDADataGridViewTextBoxColumn";
            this.iDVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVENDADataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPRODUTOSDataGridViewTextBoxColumn
            // 
            this.iDPRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.HeaderText = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPRODUTOSDataGridViewTextBoxColumn.Name = "iDPRODUTOSDataGridViewTextBoxColumn";
            this.iDPRODUTOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            this.iDCLIENTEDataGridViewTextBoxColumn.Width = 125;
            // 
            // ID_VENDEDOR
            // 
            this.ID_VENDEDOR.DataPropertyName = "ID_VENDEDOR";
            this.ID_VENDEDOR.HeaderText = "ID_VENDEDOR";
            this.ID_VENDEDOR.MinimumWidth = 6;
            this.ID_VENDEDOR.Name = "ID_VENDEDOR";
            this.ID_VENDEDOR.Width = 125;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.MinimumWidth = 6;
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.Width = 125;
            // 
            // PRECO_TOTAL
            // 
            this.PRECO_TOTAL.DataPropertyName = "PRECO_TOTAL";
            this.PRECO_TOTAL.HeaderText = "PRECO_TOTAL";
            this.PRECO_TOTAL.MinimumWidth = 6;
            this.PRECO_TOTAL.Name = "PRECO_TOTAL";
            this.PRECO_TOTAL.Width = 125;
            // 
            // DATA_VENDA
            // 
            this.DATA_VENDA.DataPropertyName = "DATA_VENDA";
            this.DATA_VENDA.HeaderText = "DATA_VENDA";
            this.DATA_VENDA.MinimumWidth = 6;
            this.DATA_VENDA.Name = "DATA_VENDA";
            this.DATA_VENDA.Width = 125;
            // 
            // vENDASBindingSource
            // 
            this.vENDASBindingSource.DataMember = "VENDAS";
            this.vENDASBindingSource.DataSource = this.cadastroUsuárioDataSet;
            // 
            // cadastroUsuárioDataSet
            // 
            this.cadastroUsuárioDataSet.DataSetName = "CadastroUsuárioDataSet";
            this.cadastroUsuárioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(630, 266);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 31);
            this.button3.TabIndex = 79;
            this.button3.Text = "Total Venda:";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.TotalizadorVenda);
            // 
            // labtotal
            // 
            this.labtotal.AutoSize = true;
            this.labtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtotal.Location = new System.Drawing.Point(789, 277);
            this.labtotal.Name = "labtotal";
            this.labtotal.Size = new System.Drawing.Size(19, 20);
            this.labtotal.TabIndex = 78;
            this.labtotal.Text = "0";
            // 
            // Cadastro
            // 
            this.Cadastro.AutoEllipsis = true;
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cadastro.Location = new System.Drawing.Point(13, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(236, 29);
            this.Cadastro.TabIndex = 76;
            this.Cadastro.Text = "Cadastro de Venda";
            this.Cadastro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClienteCad
            // 
            this.btnClienteCad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClienteCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteCad.Location = new System.Drawing.Point(371, 105);
            this.btnClienteCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteCad.Name = "btnClienteCad";
            this.btnClienteCad.Size = new System.Drawing.Size(133, 25);
            this.btnClienteCad.TabIndex = 75;
            this.btnClienteCad.Text = "Busc.Cliente";
            this.btnClienteCad.UseVisualStyleBackColor = false;
            this.btnClienteCad.Click += new System.EventHandler(this.btnClienteCad_Click);
            // 
            // BtnProdutoCad
            // 
            this.BtnProdutoCad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnProdutoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutoCad.Location = new System.Drawing.Point(770, 120);
            this.BtnProdutoCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProdutoCad.Name = "BtnProdutoCad";
            this.BtnProdutoCad.Size = new System.Drawing.Size(119, 26);
            this.BtnProdutoCad.TabIndex = 74;
            this.BtnProdutoCad.Text = "Busc.Produto";
            this.BtnProdutoCad.UseVisualStyleBackColor = false;
            this.BtnProdutoCad.Click += new System.EventHandler(this.BtnProdutoCad_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(48, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 31);
            this.button2.TabIndex = 72;
            this.button2.Text = "Itens Vendas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxValorVenda
            // 
            this.tbxValorVenda.Location = new System.Drawing.Point(224, 183);
            this.tbxValorVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxValorVenda.Name = "tbxValorVenda";
            this.tbxValorVenda.Size = new System.Drawing.Size(132, 22);
            this.tbxValorVenda.TabIndex = 71;
            this.tbxValorVenda.TextChanged += new System.EventHandler(this.tbxValorVenda_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(828, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 68;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CadVenda);
            // 
            // BtnBipar
            // 
            this.BtnBipar.AutoSize = true;
            this.BtnBipar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBipar.Location = new System.Drawing.Point(912, 124);
            this.BtnBipar.Name = "BtnBipar";
            this.BtnBipar.Size = new System.Drawing.Size(155, 22);
            this.BtnBipar.TabIndex = 67;
            this.BtnBipar.Text = "Código Produto:";
            // 
            // tbxCodigoProduto
            // 
            this.tbxCodigoProduto.Location = new System.Drawing.Point(1093, 124);
            this.tbxCodigoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCodigoProduto.Name = "tbxCodigoProduto";
            this.tbxCodigoProduto.Size = new System.Drawing.Size(89, 22);
            this.tbxCodigoProduto.TabIndex = 66;
            this.tbxCodigoProduto.TextChanged += new System.EventHandler(this.TbxCodigoProduto_TextChanged);
            // 
            // tbxCodigoVendedor
            // 
            this.tbxCodigoVendedor.Location = new System.Drawing.Point(197, 140);
            this.tbxCodigoVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCodigoVendedor.Name = "tbxCodigoVendedor";
            this.tbxCodigoVendedor.Size = new System.Drawing.Size(151, 22);
            this.tbxCodigoVendedor.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Valor Total Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Código Vendedor:";
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.Location = new System.Drawing.Point(197, 105);
            this.txbCodigoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(151, 22);
            this.txbCodigoCliente.TabIndex = 60;
            this.txbCodigoCliente.TextChanged += new System.EventHandler(this.txbCodigoCliente_TextChanged);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlDataAdapter2
            // 
            this.npgsqlDataAdapter2.DeleteCommand = null;
            this.npgsqlDataAdapter2.InsertCommand = null;
            this.npgsqlDataAdapter2.SelectCommand = null;
            this.npgsqlDataAdapter2.UpdateCommand = null;
            // 
            // vENDASTableAdapter
            // 
            this.vENDASTableAdapter.ClearBeforeFill = true;
            // 
            // eSTOQUEBindingSource
            // 
            this.eSTOQUEBindingSource.DataMember = "ESTOQUE";
            this.eSTOQUEBindingSource.DataSource = this.cadastroUsuárioDataSet;
            // 
            // eSTOQUETableAdapter
            // 
            this.eSTOQUETableAdapter.ClearBeforeFill = true;
            // 
            // fKITENSVENDIDVE756D6ECBBindingSource
            // 
            this.fKITENSVENDIDVE756D6ECBBindingSource.DataMember = "FK__ITENSVEND__ID_VE__756D6ECB";
            this.fKITENSVENDIDVE756D6ECBBindingSource.DataSource = this.vENDASBindingSource;
            // 
            // iTENSVENDATableAdapter
            // 
            this.iTENSVENDATableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 669);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCadVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Venda";
            this.Load += new System.EventHandler(this.FrmCadVenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridViewCadastro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labtotal;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Button btnClienteCad;
        private System.Windows.Forms.Button BtnProdutoCad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxValorVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BtnBipar;
        private System.Windows.Forms.TextBox tbxCodigoProduto;
        private System.Windows.Forms.TextBox tbxCodigoVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCodigoCliente;
        private CadastroUsuárioDataSet cadastroUsuárioDataSet;
        private System.Windows.Forms.BindingSource vENDASBindingSource;
        private CadastroUsuárioDataSetTableAdapters.VENDASTableAdapter vENDASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VENDEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_VENDA;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter2;
        private System.Windows.Forms.BindingSource eSTOQUEBindingSource;
        private CadastroUsuárioDataSetTableAdapters.ESTOQUETableAdapter eSTOQUETableAdapter;
        private System.Windows.Forms.ListBox listBoxItensBipados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource fKITENSVENDIDVE756D6ECBBindingSource;
        private CadastroUsuárioDataSetTableAdapters.ITENSVENDATableAdapter iTENSVENDATableAdapter;
    }
}