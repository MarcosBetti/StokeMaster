namespace Cadastro
{
    partial class frmCadVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEVENDEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuárioDataSet = new Cadastro.CadastroUsuárioDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txbEmailVendedor = new System.Windows.Forms.TextBox();
            this.txbTelefoneVendedor = new System.Windows.Forms.TextBox();
            this.txbNomeVendedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vENDEDORTableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.VENDEDORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.NOME_CLIENTE,
            this.EMAIL,
            this.TELEFONE});
            this.dataGridView1.Location = new System.Drawing.Point(21, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 245);
            this.dataGridView1.TabIndex = 20;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.MinimumWidth = 6;
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Width = 125;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "NOME_CLIENTE";
            this.NOME_CLIENTE.MinimumWidth = 6;
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 125;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.MinimumWidth = 6;
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(147, 81);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(337, 22);
            this.txbEmail.TabIndex = 9;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(147, 130);
            this.txbTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(221, 22);
            this.txbTelefone.TabIndex = 7;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(147, 21);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(369, 22);
            this.txbNome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
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
            this.Cadastro.Size = new System.Drawing.Size(304, 29);
            this.Cadastro.TabIndex = 2;
            this.Cadastro.Text = "Cadastro de Vendedores";
            this.Cadastro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txbEmailVendedor);
            this.groupBox1.Controls.Add(this.txbTelefoneVendedor);
            this.groupBox1.Controls.Add(this.txbNomeVendedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(22, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(617, 447);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVENDEDORDataGridViewTextBoxColumn,
            this.nOMEVENDEDORDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.vENDEDORBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(30, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(559, 227);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // iDVENDEDORDataGridViewTextBoxColumn
            // 
            this.iDVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "ID_VENDEDOR";
            this.iDVENDEDORDataGridViewTextBoxColumn.HeaderText = "ID_VENDEDOR";
            this.iDVENDEDORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDVENDEDORDataGridViewTextBoxColumn.Name = "iDVENDEDORDataGridViewTextBoxColumn";
            this.iDVENDEDORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVENDEDORDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMEVENDEDORDataGridViewTextBoxColumn
            // 
            this.nOMEVENDEDORDataGridViewTextBoxColumn.DataPropertyName = "NOME_VENDEDOR";
            this.nOMEVENDEDORDataGridViewTextBoxColumn.HeaderText = "NOME_VENDEDOR";
            this.nOMEVENDEDORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMEVENDEDORDataGridViewTextBoxColumn.Name = "nOMEVENDEDORDataGridViewTextBoxColumn";
            this.nOMEVENDEDORDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn1.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // vENDEDORBindingSource
            // 
            this.vENDEDORBindingSource.DataMember = "VENDEDOR";
            this.vENDEDORBindingSource.DataSource = this.cadastroUsuárioDataSet;
            // 
            // cadastroUsuárioDataSet
            // 
            this.cadastroUsuárioDataSet.DataSetName = "CadastroUsuárioDataSet";
            this.cadastroUsuárioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(433, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cadastrar);
            // 
            // txbEmailVendedor
            // 
            this.txbEmailVendedor.Location = new System.Drawing.Point(147, 81);
            this.txbEmailVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmailVendedor.Name = "txbEmailVendedor";
            this.txbEmailVendedor.Size = new System.Drawing.Size(337, 22);
            this.txbEmailVendedor.TabIndex = 9;
            // 
            // txbTelefoneVendedor
            // 
            this.txbTelefoneVendedor.Location = new System.Drawing.Point(147, 130);
            this.txbTelefoneVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTelefoneVendedor.Name = "txbTelefoneVendedor";
            this.txbTelefoneVendedor.Size = new System.Drawing.Size(221, 22);
            this.txbTelefoneVendedor.TabIndex = 7;
            // 
            // txbNomeVendedor
            // 
            this.txbNomeVendedor.Location = new System.Drawing.Point(147, 21);
            this.txbNomeVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNomeVendedor.Name = "txbNomeVendedor";
            this.txbNomeVendedor.Size = new System.Drawing.Size(369, 22);
            this.txbNomeVendedor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 18;
            // 
            // vENDEDORTableAdapter
            // 
            this.vENDEDORTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cadastro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmCadVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vendedor";
            this.Load += new System.EventHandler(this.frmCadVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbEmailVendedor;
        private System.Windows.Forms.TextBox txbTelefoneVendedor;
        private System.Windows.Forms.TextBox txbNomeVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CadastroUsuárioDataSet cadastroUsuárioDataSet;
        private System.Windows.Forms.BindingSource vENDEDORBindingSource;
        private CadastroUsuárioDataSetTableAdapters.VENDEDORTableAdapter vENDEDORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEVENDEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}