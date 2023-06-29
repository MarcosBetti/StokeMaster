using System;
using System.Windows.Forms;

namespace Cadastro
{
    partial class FrmCadProduto
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
            this.Cadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbNomeProdutos = new System.Windows.Forms.TextBox();
            this.txbQtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescricaoItem = new System.Windows.Forms.TextBox();
            this.GridViewProduto = new System.Windows.Forms.DataGridView();
            this.iDPRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuárioDataSet = new Cadastro.CadastroUsuárioDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbValorProduto = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pRODUTOSTableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.PRODUTOSTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.AutoEllipsis = true;
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cadastro.Location = new System.Drawing.Point(28, 12);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(267, 29);
            this.Cadastro.TabIndex = 1;
            this.Cadastro.Text = "Cadastro de Produtos";
            this.Cadastro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbNomeProdutos);
            this.groupBox1.Controls.Add(this.txbQtde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbDescricaoItem);
            this.groupBox1.Controls.Add(this.GridViewProduto);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbValorProduto);
            this.groupBox1.Controls.Add(this.txbNomeProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(596, 540);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txbNomeProdutos
            // 
            this.txbNomeProdutos.Location = new System.Drawing.Point(138, 27);
            this.txbNomeProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNomeProdutos.Name = "txbNomeProdutos";
            this.txbNomeProdutos.Size = new System.Drawing.Size(369, 22);
            this.txbNomeProdutos.TabIndex = 28;
            // 
            // txbQtde
            // 
            this.txbQtde.BackColor = System.Drawing.SystemColors.Window;
            this.txbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbQtde.Location = new System.Drawing.Point(138, 157);
            this.txbQtde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbQtde.Name = "txbQtde";
            this.txbQtde.Size = new System.Drawing.Size(65, 23);
            this.txbQtde.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descrição:";
            // 
            // txbDescricaoItem
            // 
            this.txbDescricaoItem.BackColor = System.Drawing.SystemColors.Window;
            this.txbDescricaoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbDescricaoItem.Location = new System.Drawing.Point(138, 105);
            this.txbDescricaoItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescricaoItem.Name = "txbDescricaoItem";
            this.txbDescricaoItem.Size = new System.Drawing.Size(188, 23);
            this.txbDescricaoItem.TabIndex = 23;
            // 
            // GridViewProduto
            // 
            this.GridViewProduto.AutoGenerateColumns = false;
            this.GridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUTOSDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.pRECODataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.QUANTIDADE});
            this.GridViewProduto.DataSource = this.pRODUTOSBindingSource;
            this.GridViewProduto.Location = new System.Drawing.Point(24, 208);
            this.GridViewProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewProduto.Name = "GridViewProduto";
            this.GridViewProduto.RowHeadersWidth = 51;
            this.GridViewProduto.RowTemplate.Height = 24;
            this.GridViewProduto.Size = new System.Drawing.Size(556, 290);
            this.GridViewProduto.TabIndex = 21;
            this.GridViewProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProduto_CellContentClick);
            // 
            // iDPRODUTOSDataGridViewTextBoxColumn
            // 
            this.iDPRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.HeaderText = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPRODUTOSDataGridViewTextBoxColumn.Name = "iDPRODUTOSDataGridViewTextBoxColumn";
            this.iDPRODUTOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUTOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECODataGridViewTextBoxColumn
            // 
            this.pRECODataGridViewTextBoxColumn.DataPropertyName = "PRECO";
            this.pRECODataGridViewTextBoxColumn.HeaderText = "PRECO";
            this.pRECODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECODataGridViewTextBoxColumn.Name = "pRECODataGridViewTextBoxColumn";
            this.pRECODataGridViewTextBoxColumn.Width = 125;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            this.dESCRICAODataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.cadastroUsuárioDataSet;
            // 
            // cadastroUsuárioDataSet
            // 
            this.cadastroUsuárioDataSet.DataSetName = "CadastroUsuárioDataSet";
            this.cadastroUsuárioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(477, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome:";
            // 
            // txbValorProduto
            // 
            this.txbValorProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txbValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbValorProduto.Location = new System.Drawing.Point(138, 66);
            this.txbValorProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbValorProduto.Name = "txbValorProduto";
            this.txbValorProduto.Size = new System.Drawing.Size(139, 23);
            this.txbValorProduto.TabIndex = 8;
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Location = new System.Drawing.Point(138, 27);
            this.txbNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(369, 22);
            this.txbNomeProduto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(28, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cadastro de Produtos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.MinimumWidth = 6;
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.Width = 125;
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 613);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cadastro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }      

        #endregion

        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbValorProduto;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridViewProduto;
        private CadastroUsuárioDataSet cadastroUsuárioDataSet;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private CadastroUsuárioDataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbDescricaoItem;
        private DataGridViewTextBoxColumn iDPRODUTOSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRECODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private Label label3;
        private TextBox txbQtde;
        private Label label4;
        private TextBox txbNomeProdutos;
        private Label label6;
        private DataGridViewTextBoxColumn QUANTIDADE;
    }
}