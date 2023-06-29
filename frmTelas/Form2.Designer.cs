namespace Cadastro
{
    partial class Form2
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
            this.vENDASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuárioDataSet = new Cadastro.CadastroUsuárioDataSet();
            this.vENDASTableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.VENDASTableAdapter();
            this.fKITENSVENDIDVE756D6ECBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSVENDATableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.ITENSVENDATableAdapter();
            this.fKITENSVENDIDVE756D6ECBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKITENSVENDIDVE756D6ECBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            // vENDASTableAdapter
            // 
            this.vENDASTableAdapter.ClearBeforeFill = true;
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
            // fKITENSVENDIDVE756D6ECBBindingSource1
            // 
            this.fKITENSVENDIDVE756D6ECBBindingSource1.DataMember = "FK__ITENSVEND__ID_VE__756D6ECB";
            this.fKITENSVENDIDVE756D6ECBBindingSource1.DataSource = this.vENDASBindingSource;
            // 
            // fKITENSVENDIDVE756D6ECBBindingSource2
            // 
            this.fKITENSVENDIDVE756D6ECBBindingSource2.DataMember = "FK__ITENSVEND__ID_VE__756D6ECB";
            this.fKITENSVENDIDVE756D6ECBBindingSource2.DataSource = this.vENDASBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(734, 466);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.fKITENSVENDIDVE756D6ECBBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(22, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(676, 386);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ITEM";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_ITEM";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_VENDA";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_VENDA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_PRODUTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_PRODUTO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn4.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRECO_UNITARIO";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRECO_UNITARIO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Itens das Vendas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 479);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Itens das Vendas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKITENSVENDIDVE756D6ECBBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CadastroUsuárioDataSet cadastroUsuárioDataSet;
        private System.Windows.Forms.BindingSource vENDASBindingSource;
        private CadastroUsuárioDataSetTableAdapters.VENDASTableAdapter vENDASTableAdapter;
        private System.Windows.Forms.BindingSource fKITENSVENDIDVE756D6ECBBindingSource;
        private CadastroUsuárioDataSetTableAdapters.ITENSVENDATableAdapter iTENSVENDATableAdapter;
        private System.Windows.Forms.BindingSource fKITENSVENDIDVE756D6ECBBindingSource1;
        private System.Windows.Forms.BindingSource fKITENSVENDIDVE756D6ECBBindingSource2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}