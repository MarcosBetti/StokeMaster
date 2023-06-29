using System.Windows.Forms;

namespace Cadastro.frmTelas
{
    partial class FrmConsultaEstoque
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
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewEstoque = new System.Windows.Forms.DataGridView();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVENCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTOQUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuárioDataSet = new Cadastro.CadastroUsuárioDataSet();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.Label();
            this.eSTOQUETableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.ESTOQUETableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GridViewEstoque);
            this.groupBox1.Controls.Add(this.Btn_Consulta);
            this.groupBox1.Controls.Add(this.txbCodigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(608, 248);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Código:";
            // 
            // GridViewEstoque
            // 
            this.GridViewEstoque.AutoGenerateColumns = false;
            this.GridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO,
            this.NOME_PRODUTO,
            this.QUANTIDADE,
            this.iDESTOQUEDataGridViewTextBoxColumn,
            this.pRODUTOIDDataGridViewTextBoxColumn,
            this.qUANTIDADEDataGridViewTextBoxColumn,
            this.dATAESTOQUEDataGridViewTextBoxColumn,
            this.dATAVENCIMENTODataGridViewTextBoxColumn});
            this.GridViewEstoque.DataSource = this.eSTOQUEBindingSource;
            this.GridViewEstoque.Location = new System.Drawing.Point(17, 76);
            this.GridViewEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewEstoque.Name = "GridViewEstoque";
            this.GridViewEstoque.RowHeadersWidth = 51;
            this.GridViewEstoque.RowTemplate.Height = 24;
            this.GridViewEstoque.Size = new System.Drawing.Size(552, 116);
            this.GridViewEstoque.TabIndex = 21;
            this.GridViewEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewEstoque_CellContentClick);
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.HeaderText = "ID_PRODUTO";
            this.ID_PRODUTO.MinimumWidth = 6;
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            this.ID_PRODUTO.Width = 125;
            // 
            // NOME_PRODUTO
            // 
            this.NOME_PRODUTO.HeaderText = "NOME_PRODUTO";
            this.NOME_PRODUTO.MinimumWidth = 6;
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.Width = 125;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.MinimumWidth = 6;
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.Width = 125;
            // 
            // iDESTOQUEDataGridViewTextBoxColumn
            // 
            this.iDESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "ID_ESTOQUE";
            this.iDESTOQUEDataGridViewTextBoxColumn.HeaderText = "ID_ESTOQUE";
            this.iDESTOQUEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDESTOQUEDataGridViewTextBoxColumn.Name = "iDESTOQUEDataGridViewTextBoxColumn";
            this.iDESTOQUEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUTOIDDataGridViewTextBoxColumn
            // 
            this.pRODUTOIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUTO_ID";
            this.pRODUTOIDDataGridViewTextBoxColumn.HeaderText = "PRODUTO_ID";
            this.pRODUTOIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUTOIDDataGridViewTextBoxColumn.Name = "pRODUTOIDDataGridViewTextBoxColumn";
            this.pRODUTOIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // qUANTIDADEDataGridViewTextBoxColumn
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUANTIDADEDataGridViewTextBoxColumn.Name = "qUANTIDADEDataGridViewTextBoxColumn";
            this.qUANTIDADEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dATAESTOQUEDataGridViewTextBoxColumn
            // 
            this.dATAESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "DATA_ESTOQUE";
            this.dATAESTOQUEDataGridViewTextBoxColumn.HeaderText = "DATA_ESTOQUE";
            this.dATAESTOQUEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATAESTOQUEDataGridViewTextBoxColumn.Name = "dATAESTOQUEDataGridViewTextBoxColumn";
            this.dATAESTOQUEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dATAVENCIMENTODataGridViewTextBoxColumn
            // 
            this.dATAVENCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_VENCIMENTO";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA_VENCIMENTO";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATAVENCIMENTODataGridViewTextBoxColumn.Name = "dATAVENCIMENTODataGridViewTextBoxColumn";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.Width = 125;
            // 
            // eSTOQUEBindingSource
            // 
            this.eSTOQUEBindingSource.DataMember = "ESTOQUE";
            this.eSTOQUEBindingSource.DataSource = this.cadastroUsuárioDataSet;
            // 
            // cadastroUsuárioDataSet
            // 
            this.cadastroUsuárioDataSet.DataSetName = "CadastroUsuárioDataSet";
            this.cadastroUsuárioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta.Location = new System.Drawing.Point(466, 23);
            this.Btn_Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(103, 31);
            this.Btn_Consulta.TabIndex = 20;
            this.Btn_Consulta.Text = "Consultar";
            this.Btn_Consulta.UseVisualStyleBackColor = true;
            this.Btn_Consulta.Click += new System.EventHandler(this.Btn_ConsultaEstoque);
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(120, 23);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(114, 22);
            this.txbCodigo.TabIndex = 25;
            this.txbCodigo.TextChanged += new System.EventHandler(this.txbCodigo_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            // 
            // Cadastro
            // 
            this.Cadastro.AutoEllipsis = true;
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cadastro.Location = new System.Drawing.Point(12, 9);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(255, 29);
            this.Cadastro.TabIndex = 8;
            this.Cadastro.Text = "Consulta de Estoque";
            this.Cadastro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // eSTOQUETableAdapter
            // 
            this.eSTOQUETableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 310);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaEstoque";
            this.Text = "Consulta Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridViewEstoque;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cadastro;
        private CadastroUsuárioDataSet cadastroUsuárioDataSet;
        private System.Windows.Forms.BindingSource eSTOQUEBindingSource;
        private CadastroUsuárioDataSetTableAdapters.ESTOQUETableAdapter eSTOQUETableAdapter;
        private System.Windows.Forms.Label label2;
        private DataGridViewTextBoxColumn ID_PRODUTO;
        private DataGridViewTextBoxColumn NOME_PRODUTO;
        private DataGridViewTextBoxColumn QUANTIDADE;
        private DataGridViewTextBoxColumn iDESTOQUEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRODUTOIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATAESTOQUEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATAVENCIMENTODataGridViewTextBoxColumn;
    }
}