namespace Cadastro.frmTelas
{
    partial class FrmCorrecaoEstoque
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
            System.Windows.Forms.Label dATA_ESTOQUELabel;
            System.Windows.Forms.Label dATA_VENCIMENTOLabel;
            this.Cadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dATA_VENCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eSTOQUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuárioDataSet = new Cadastro.CadastroUsuárioDataSet();
            this.dATA_ESTOQUEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDESTOQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_VENCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.texbIdInclusao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texbQtde = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbIdProduto = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eSTOQUETableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.ESTOQUETableAdapter();
            this.tableAdapterManager = new Cadastro.CadastroUsuárioDataSetTableAdapters.TableAdapterManager();
            dATA_ESTOQUELabel = new System.Windows.Forms.Label();
            dATA_VENCIMENTOLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dATA_ESTOQUELabel
            // 
            dATA_ESTOQUELabel.AutoSize = true;
            dATA_ESTOQUELabel.Location = new System.Drawing.Point(391, 26);
            dATA_ESTOQUELabel.Name = "dATA_ESTOQUELabel";
            dATA_ESTOQUELabel.Size = new System.Drawing.Size(116, 16);
            dATA_ESTOQUELabel.TabIndex = 29;
            dATA_ESTOQUELabel.Text = "DATA ESTOQUE:";
            // 
            // dATA_VENCIMENTOLabel
            // 
            dATA_VENCIMENTOLabel.AutoSize = true;
            dATA_VENCIMENTOLabel.Location = new System.Drawing.Point(827, 29);
            dATA_VENCIMENTOLabel.Name = "dATA_VENCIMENTOLabel";
            dATA_VENCIMENTOLabel.Size = new System.Drawing.Size(139, 16);
            dATA_VENCIMENTOLabel.TabIndex = 30;
            dATA_VENCIMENTOLabel.Text = "DATA VENCIMENTO:";
            // 
            // Cadastro
            // 
            this.Cadastro.AutoEllipsis = true;
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cadastro.Location = new System.Drawing.Point(12, 9);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(261, 29);
            this.Cadastro.TabIndex = 2;
            this.Cadastro.Text = "Correção de Estoque";
            this.Cadastro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(dATA_VENCIMENTOLabel);
            this.groupBox1.Controls.Add(this.dATA_VENCIMENTODateTimePicker);
            this.groupBox1.Controls.Add(dATA_ESTOQUELabel);
            this.groupBox1.Controls.Add(this.dATA_ESTOQUEDateTimePicker);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.texbIdInclusao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.texbQtde);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbIdProduto);
            this.groupBox1.Controls.Add(this.txbNomeProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1275, 534);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dATA_VENCIMENTODateTimePicker
            // 
            this.dATA_VENCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eSTOQUEBindingSource, "DATA_VENCIMENTO", true));
            this.dATA_VENCIMENTODateTimePicker.Location = new System.Drawing.Point(979, 26);
            this.dATA_VENCIMENTODateTimePicker.Name = "dATA_VENCIMENTODateTimePicker";
            this.dATA_VENCIMENTODateTimePicker.Size = new System.Drawing.Size(290, 22);
            this.dATA_VENCIMENTODateTimePicker.TabIndex = 31;
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
            // dATA_ESTOQUEDateTimePicker
            // 
            this.dATA_ESTOQUEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eSTOQUEBindingSource, "DATA_ESTOQUE", true));
            this.dATA_ESTOQUEDateTimePicker.Location = new System.Drawing.Point(513, 23);
            this.dATA_ESTOQUEDateTimePicker.Name = "dATA_ESTOQUEDateTimePicker";
            this.dATA_ESTOQUEDateTimePicker.Size = new System.Drawing.Size(298, 22);
            this.dATA_ESTOQUEDateTimePicker.TabIndex = 30;
            this.dATA_ESTOQUEDateTimePicker.ValueChanged += new System.EventHandler(this.dATA_ESTOQUEDateTimePicker_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDESTOQUEDataGridViewTextBoxColumn,
            this.pRODUTOIDDataGridViewTextBoxColumn,
            this.qUANTIDADEDataGridViewTextBoxColumn,
            this.DATA_VENCIMENTO,
            this.DATA_ESTOQUE});
            this.dataGridView1.DataSource = this.eSTOQUEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 292);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // DATA_VENCIMENTO
            // 
            this.DATA_VENCIMENTO.DataPropertyName = "DATA_VENCIMENTO";
            this.DATA_VENCIMENTO.HeaderText = "DATA_VENCIMENTO";
            this.DATA_VENCIMENTO.MinimumWidth = 6;
            this.DATA_VENCIMENTO.Name = "DATA_VENCIMENTO";
            this.DATA_VENCIMENTO.Width = 125;
            // 
            // DATA_ESTOQUE
            // 
            this.DATA_ESTOQUE.DataPropertyName = "DATA_ESTOQUE";
            this.DATA_ESTOQUE.HeaderText = "DATA_ESTOQUE";
            this.DATA_ESTOQUE.MinimumWidth = 6;
            this.DATA_ESTOQUE.Name = "DATA_ESTOQUE";
            this.DATA_ESTOQUE.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Código da inclusão:";
            // 
            // texbIdInclusao
            // 
            this.texbIdInclusao.BackColor = System.Drawing.SystemColors.Window;
            this.texbIdInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.texbIdInclusao.Location = new System.Drawing.Point(227, 21);
            this.texbIdInclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texbIdInclusao.Name = "texbIdInclusao";
            this.texbIdInclusao.Size = new System.Drawing.Size(139, 23);
            this.texbIdInclusao.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Código Produto:";
            // 
            // texbQtde
            // 
            this.texbQtde.BackColor = System.Drawing.SystemColors.Window;
            this.texbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.texbQtde.Location = new System.Drawing.Point(227, 178);
            this.texbQtde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texbQtde.Name = "texbQtde";
            this.texbQtde.Size = new System.Drawing.Size(139, 23);
            this.texbQtde.TabIndex = 25;
            this.texbQtde.TextChanged += new System.EventHandler(this.texbQtde_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1159, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IncluirEstoque);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome:";
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txbIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbIdProduto.Location = new System.Drawing.Point(227, 77);
            this.txbIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.Size = new System.Drawing.Size(139, 23);
            this.txbIdProduto.TabIndex = 8;
            this.txbIdProduto.TextChanged += new System.EventHandler(this.txbIdProduto_TextChanged);
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Location = new System.Drawing.Point(227, 127);
            this.txbNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(369, 22);
            this.txbNomeProduto.TabIndex = 6;
            this.txbNomeProduto.TextChanged += new System.EventHandler(this.txbNomeProduto_TextChanged);
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
            this.label2.Location = new System.Drawing.Point(93, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            // 
            // eSTOQUETableAdapter
            // 
            this.eSTOQUETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ESTOQUETableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = null;
            this.tableAdapterManager.VENDASTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            // 
            // FrmCorrecaoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cadastro);
            this.Name = "FrmCorrecaoEstoque";
            this.Text = "CorrecaoEstoque";
            this.Load += new System.EventHandler(this.FrmCorrecaoEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbIdProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbQtde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texbIdInclusao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CadastroUsuárioDataSet cadastroUsuárioDataSet;
        private System.Windows.Forms.BindingSource eSTOQUEBindingSource;
        private CadastroUsuárioDataSetTableAdapters.ESTOQUETableAdapter eSTOQUETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTOQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_VENCIMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ESTOQUE;
        private System.Windows.Forms.DateTimePicker dATA_ESTOQUEDateTimePicker;
        private CadastroUsuárioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dATA_VENCIMENTODateTimePicker;
    }
}